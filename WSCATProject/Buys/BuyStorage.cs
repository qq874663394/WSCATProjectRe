using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using HelperUtility.Encrypt;
using DAL;
using DevComponents.DotNetBar.SuperGrid;

namespace WSCATProject.Buys
{
    public partial class BuyStorage : Form
    {
        public BuyStorage()
        {
            InitializeComponent();
        }
        CodingHelper ch = new CodingHelper();
        StockDetailManager stock = new StockDetailManager();

        //初始加载的时候
        private void BuyStorage_Load(object sender, EventArgs e)
        {
            loadTree();
            Band();
            AddDataTime();
            BanList();
        }
        #region 窗体初始化
        //加载TreeView
        private void loadTree()
        {
            treeView1.Nodes.Clear();
            MaterialTypeManager mType = new MaterialTypeManager();
            DataTable dt = mType.GetListToTable("");
            AddTree("", null, dt);
        }
        //递归添加树的节点
        private void AddTree(string ParentID, TreeNode pNode, DataTable table)
        {
            if (ParentID == "")
            {
                ParentID = "D4";
            }
            string ParentId = "MT_ParentID";
            string Code = "MT_Code";
            string Name = "MT_Name";

            DataView dvTree = new DataView(table);
            //过滤ParentID,得到当前的所有子节点
            dvTree.RowFilter = string.Format("{0} = '{1}'", ParentId, ParentID);
            foreach (DataRowView Row in dvTree)
            {
                TreeNode Node = new TreeNode();
                if (pNode == null)
                {
                    //添加根节点
                    Node.Text = XYEEncoding.strHexDecode(Row[Name].ToString());
                    Node.Tag = XYEEncoding.strHexDecode(Row[Code].ToString());
                    treeView1.Nodes.Add(Node);
                    AddTree(Row[Code].ToString(), Node, table);
                    //展开第一级节点
                    Node.Expand();
                }
                else
                {
                    //添加当前节点的子节点
                    Node.Text = XYEEncoding.strHexDecode(Row[Name].ToString());
                    Node.Tag = XYEEncoding.strHexDecode(Row[Code].ToString());
                    pNode.Nodes.Add(Node);
                    AddTree(Row[Code].ToString(), Node, table);//再次递归 
                }
            }
        }
        //绑定DataGirdView
        private void Band()
        {
            try
            {
                superGridControl1.PrimaryGrid.ShowInsertRow = false;
                superGridControl1.PrimaryGrid.AutoGenerateColumns = false;
                superGridControl1.PrimaryGrid.DataSource = stock.GetList("");
                GridPanel panel = superGridControl1.PrimaryGrid;
                GridColumnCollection columns = panel.Columns;

                panel.ColumnHeader.GroupHeaders.Add(GetSlCompanyInfoHeader(columns, "huopingxinxi", "货品信息", "gridColumn1", "gridColumn24"));
                panel.ColumnHeader.GroupHeaders.Add(GetSlCompanyInfoHeader(columns, "chuqi", "初期", "gridColumn15", "gridColumn16"));
                panel.ColumnHeader.GroupHeaders.Add(GetSlCompanyInfoHeader(columns, "benqi", "本期收入", "gridColumn17", "gridColumn18"));
                panel.ColumnHeader.GroupHeaders.Add(GetSlCompanyInfoHeader(columns, "benqifac", "现存情况", "gridColumn19", "gridColumn22"));
            }
            catch (Exception)
            {

                throw;
            }
        }
        //在toolstrip上绑定DataTime控件
        private void AddDataTime()
        {
            //开始时间
            DateTimePicker begin = new DateTimePicker();
            begin.Format = DateTimePickerFormat.Custom;//自动设置
            begin.CustomFormat = "MM月dd日";//自定义格式 
            begin.Width = 80;
            //截止时间
            DateTimePicker end = new DateTimePicker();
            end.Format = DateTimePickerFormat.Custom;//自动设置
            end.CustomFormat = "MM月dd日";//自定义格式 
            end.Width = 80;
            Controls.Add(begin);
            Controls.Add(end);
            //添加的位置
            this.toolStrip1.Items.Insert(5, new ToolStripControlHost(begin));
            this.toolStrip1.Items.Insert(7, new ToolStripControlHost(end));
        }
        //绑定仓库下拉框
        private void BanList()
        {
           
            StockManager st = new StockManager();
            DataTable dt = st.SelStockTable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tsbc_chuangk.Items.Add(dt.Rows[0].ItemArray[2]);
            }
        }
 

        /// <summary>
        /// 合并列方法
        /// </summary>
        /// <returns></returns>
        private ColumnGroupHeader GetSlCompanyInfoHeader(GridColumnCollection columns, string
    name, string headerText, string startName, string endName)
        {
            ColumnGroupHeader cgh = new ColumnGroupHeader();

            cgh.Name = name;
            cgh.HeaderText = headerText;

            cgh.MinRowHeight = 36;

            cgh.StartDisplayIndex = GetDisplayIndex(columns, startName);
            cgh.EndDisplayIndex = GetDisplayIndex(columns, endName);

            //superGridControl1.PrimaryGrid
            return (cgh);
        }
        private int GetDisplayIndex(GridColumnCollection columns, string name)
        {
            return (columns.GetDisplayIndex(columns[name]));
        }

        //TreeView的改变事件
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string treeTag = treeView1.SelectedNode.Tag.ToString();
            superGridControl1.PrimaryGrid.DataSource = stock.GetList(" tm.Ma_TypeID='"+ XYEEncoding.strCodeHex(treeTag)+ "'");
        }

        #endregion

        #region  根据条件模糊查询
        //根据条件模糊查询
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {

                string SQLWhere = "";
                string treeName = treeView1.SelectedNode.Text;
                string treeTag = treeView1.SelectedNode.Tag.ToString();
                string searchType = toolStripComboBox1.Text.Trim();
                string searchKey = XYEEncoding.strCodeHex(toolStripTextBox3.Text.Trim());

                if (treeView1.SelectedNode == null)  //如果TreeView选中项为空
                {
                    return;
                }
                if (string.IsNullOrWhiteSpace(toolStripTextBox3.Text.Trim()))  //如果搜索关键字为空
                {
                    return;
                }
                SQLWhere += string.Format(" tm.Ma_TypeID = '{0}'", XYEEncoding.strCodeHex(treeTag));

                //模糊货品信息
                switch (searchType) //搜索框内容加密后
                {
                    case "货品编号":
                        SQLWhere += string.Format(" and td.Sto_MaCode  like '%{0}%'", searchKey);
                        break;
                    case "货品名称":
                        SQLWhere += string.Format(" and td.Sto_MaName like '%{0}%'", searchKey);
                        break;
                    case "货品规格":
                        SQLWhere += string.Format(" and td.Sto_MaModel like '%{0}%'", searchKey);
                        break;
                    default:
                        MessageBox.Show("类型选择错误，请重新选择！");
                        break;
                }
                superGridControl1.PrimaryGrid.DataSource = stock.GetList(SQLWhere);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}

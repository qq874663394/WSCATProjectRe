using HelperUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCATProject.Sell
{
    public partial class InSellForm : TemplateForm
    {
        public InSellForm()
        {
            InitializeComponent();
        }
        #region 数据字段
        /// <summary>
        /// 所有商品列表
        /// </summary>
        private DataSet _AllMaterial = null;
        /// <summary>
        /// 所有仓库列表
        /// </summary>
        private DataSet _AllStorage = null;
        /// <summary>
        /// 所有的供应商列表
        /// </summary>
        private DataTable _AllSupplier = null;
        /// <summary>
        /// 选择的仓库
        /// </summary>
        private KeyValuePair<string, string> _ClickStorage;
        /// <summary>
        /// 采购单单号
        /// </summary>
        private string _BuyOdd = "";
        /// <summary>
        /// 供应商编号
        /// </summary>
        private string _ProfeCode = "";
        /// <summary>
        /// 点击的项,1为仓库,2为供应商
        /// </summary>
        private int _Click = 0;
        /// <summary>
        /// 用户选择的商品总数
        /// </summary>
        private decimal _MaterialNumber = 0m;
        /// <summary>
        /// 用户选择的商品总值
        /// </summary>
        private decimal _MaterialMoney = 0.00m;

        public string BuyOdd
        {
            get
            {
                return _BuyOdd;
            }

            set
            {
                _BuyOdd = value;
            }
        }

        public string pbName;

        //控制面板是否显示
        private bool _btnAdd = false;

        protected bool BtnAdd
        {
            get { return _btnAdd; }
            set { _btnAdd = value; }
        }
        #endregion
        private void InSellForm_Load(object sender, EventArgs e)
        {
            //销售单单号
            BuyOdd = BuildCode.ModuleCode("SS");
            textBoxOddNumbers.Text = BuyOdd;

            //绑定事件 双击事填充内容并隐藏列表
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            dataGridViewFujia.CellDoubleClick += DataGridViewFujia_CellDoubleClick;
        }
        /// <summary>
        /// 绑定pictureBox表格的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewFujia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (pbName)
            {
                //客户
                case "pictureBox2":
                    //labtextboxTop1.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    labtextboxTop2.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[2].Value.ToString();//客户
                    labtextboxTop5.Text = "";//往来金额
                    labtextboxTop7.Text = "";//送货地址
                    labtextboxTop8.Text = "";//联系人
                    labtextboxTop9.Text = "";//联系电话
                    break;
                //收款账号
                case "pictureBox3":
                    labtextboxTop4.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }
        }
        /// <summary>
        /// 绑定中间添加销售商品的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 点击图片显示DataGirdView数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ClickPicBox(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pbName = pb.Name;
            switch (pb.Name)
            {
                //供应商
                case "pictureBox2":
                    //resizablePanel1.Location = new Point(180, 110);
                    //dataGridViewFujia.DataSource = sm.SelSupplierTable2();
                    //dataGridViewFujia.Columns[2].Visible = false;
                    break;
                //收款账号
                case "pictureBox3":
                    //resizablePanel1.Location = new Point(190, 260);
                    //DataTable dt = ch.DataTableReCoding(em.SelEmp2("").Tables[0]);
                    //dataGridViewFujia.DataSource = dt;
                    break;
            }
            if (!_btnAdd)
            {
                resizablePanel1.Visible = true;
                _btnAdd = true;
            }
            else
            {
                resizablePanel1.Size = new System.Drawing.Size(248, 144);
                resizablePanel1.Visible = true;
                resizablePanel1.Focus();
            }

        }
    }
}

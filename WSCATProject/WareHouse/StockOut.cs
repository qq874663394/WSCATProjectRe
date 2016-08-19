using BLL;
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

namespace WSCATProject.WareHouse
{
    public partial class StockOut : TemplateForm
    {
        public StockOut()
        {
            InitializeComponent();
        }
        #region  数据字段
        /// <summary>
        /// 所有仓库列表
        /// </summary>
        private DataSet _AllStorage = null;
        /// <summary>
        /// 所有客户
        /// </summary>
        private DataSet _AllClient = null;
        /// <summary>
        /// 点击的项,1为仓库,2客户
        /// </summary>
        private int _Click = 0;

        #endregion

        private void StockOut_Load(object sender, EventArgs e)
        {
            #region 隐藏控件
            checkBox1.Visible = false;
            labTop4.Visible = false;
            labTop5.Visible = false;
            labTop6.Visible = false;
            labTop7.Visible = false;
            labTop8.Visible = false;
            labTop9.Visible = false;
            labtextboxTop4.Visible = false;
            labtextboxTop5.Visible = false;
            labtextboxTop6.Visible = false;
            labtextboxTop7.Visible = false;
            labtextboxTop8.Visible = false;
            labtextboxTop9.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            #endregion

            StorageManager sm = new StorageManager();//仓库
            ClientManager cm = new ClientManager();//客户
            _AllStorage = sm.GetList("");
            _AllClient = cm.GetList("");

            //禁用自动创建列
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewFujia.AutoGenerateColumns = false;

            //出库单单号
            textBoxOddNumbers.Text = BuildCode.ModuleCode("OO");

            //绑定事件 双击事填充内容并隐藏列表
            dataGridViewFujia.CellDoubleClick += DataGridViewFujia_CellDoubleClick;
            // 将dataGridView中的内容居中显示
            dataGridViewFujia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        /// <summary>
        /// 点击panel隐藏扩展panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void panel6_Click(object sender, EventArgs e)
        {
            resizablePanel1.Visible = false;
        }

        #region 初始化数据
        /// <summary>
        /// 初始化仓库列和数据
        /// </summary>
        private void InitStorageList()
        {
            if (_Click != 1)
            {
                _Click = 1;
                dataGridViewFujia.DataSource = null;
                dataGridViewFujia.Columns.Clear();

                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "St_Code";
                dgvc.HeaderText = "编码";
                dgvc.DataPropertyName = "St_Code";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "St_Name";
                dgvc.HeaderText = "仓库名称";
                dgvc.DataPropertyName = "St_Name";
                dataGridViewFujia.Columns.Add(dgvc);
                resizablePanel1.Location = new Point(190, 145);
                dataGridViewFujia.DataSource = _AllStorage.Tables[0];
            }
        }
        /// <summary>
        /// 初始化客户
        /// </summary>
        private void InitClient()
        {
            if (_Click != 2)
            {
                _Click = 2;
                dataGridViewFujia.DataSource = null;
                dataGridViewFujia.Columns.Clear();

                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_Code";
                dgvc.HeaderText = "编码";
                dgvc.DataPropertyName = "Cli_Code";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_Name";
                dgvc.HeaderText = "客户名称";
                dgvc.DataPropertyName = "Cli_Name";
                dataGridViewFujia.Columns.Add(dgvc);
                resizablePanel1.Location = new Point(480, 115);
                dataGridViewFujia.DataSource = _AllClient;
            }
        }
        #endregion

        #region picture  图标点击事件

        //仓库图标的点击事件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_Click != 1)
            {
                InitStorageList();
            }
        }

        //客户图标的点击事件
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (_Click != 2)
            {
                InitClient();
            }
        }
      
        #endregion

        #region  绑定pictureBox表格的数据
        /// <summary>
        /// 绑定pictureBox表格的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewFujia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //仓库信息
            if (_Click == 1)
            {
                string name = dataGridViewFujia.Rows[e.RowIndex].Cells["St_Name"].Value.ToString();
                labtextboxTop3.Text = name;
                resizablePanel1.Visible = false;
            }

            //客户
            if (_Click == 2)
            {
                // string code = dataGridViewFujia.Rows[e.RowIndex].Cells["Su_Code"].Value.ToString();
                string name = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_Name"].Value.ToString();
                labtextboxTop2.Text = name;
                resizablePanel1.Visible = false;
            }
        }
        #endregion

    }
}

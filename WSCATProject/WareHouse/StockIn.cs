using BLL;
using DevComponents.DotNetBar.SuperGrid;
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
    public partial class StockIn : TemplateForm
    {
        public StockIn()
        {
            InitializeComponent();
        }
        #region 数据字段
        /// <summary>
        /// 所有仓库列表
        /// </summary>
        private DataSet _AllStorage = null;
        /// <summary>
        /// 所有供应商
        /// </summary>
        private DataTable _AllSupply = null;
        /// <summary>
        /// 点击的项,1为仓库,2供应商
        /// </summary>
        private int _Click = 0;

        #endregion

        private void StockIn_Load(object sender, EventArgs e)
        {
            StorageManager sm = new StorageManager();//仓库
            SupplierManager supply = new SupplierManager();//供应商
            _AllStorage = sm.GetList("");
            _AllSupply = supply.SelSupplierTable();

            //禁用自动创建列
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewFujia.AutoGenerateColumns = false;

            //入库单单号
            textBoxOddNumbers.Text = BuildCode.ModuleCode("OI");

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
        private void label3_Click(object sender, EventArgs e)
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
        /// 初始化供应商
        /// </summary>
        private void InitSupply()
        {
            if (_Click != 2)
            {
                _Click = 2;
                dataGridViewFujia.DataSource = null;
                dataGridViewFujia.Columns.Clear();

                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Su_Code";
                dgvc.HeaderText = "编码";
                dgvc.DataPropertyName = "编码";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Su_Name";
                dgvc.HeaderText = "单位名称";
                dgvc.DataPropertyName = "单位名称";
                dataGridViewFujia.Columns.Add(dgvc);
                resizablePanel1.Location = new Point(490, 115);
                dataGridViewFujia.DataSource = _AllSupply;
            }
        }
        #endregion

        #region picture  图标点击事件

        //供应商图标的点击事件
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (_Click != 2)
            {
                InitSupply();
            }
        }
        //仓库图标的点击事件
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (_Click != 1)
            {
                InitStorageList();
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

            //供应商
            if (_Click == 2)
            {
               // string code = dataGridViewFujia.Rows[e.RowIndex].Cells["Su_Code"].Value.ToString();
                string name = dataGridViewFujia.Rows[e.RowIndex].Cells["Su_Name"].Value.ToString();
                labtextboxTop2.Text = name;
                resizablePanel1.Visible = false;
            }
        }
        #endregion

    }
}
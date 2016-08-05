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

            //初始化商品下拉列表
            InitMaterialDataGridView();
           // dataGridView1.DataSource = _AllMaterial.Tables[0];
            //初始化datagridview
            InitDataGridView();
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
        /// 绑定中间添加销售商品的数据 双击物料信息填写在表格里面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //是否要新增一行的标记
            bool newAdd = false;
            GridRow gr = (GridRow)superGridControl1.PrimaryGrid.Rows[ClickRowIndex];
            //id字段为空 说明是没有数据的行 不是修改而是新增
            if (gr.Cells["gridColumnid"].Value == null)
            {
                newAdd = true;
            }
            gr.Cells["gridColumnid"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_ID"].Value;
            gr.Cells["gridColumnpic"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_PicName"].Value;
            gr.Cells["gridColumnRfid"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_RFID"].Value;
            gr.Cells["gridColumnBarcode"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Code"].Value;
            gr.Cells["gridColumnTypeid"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_TypeID"].Value;
            //gr.Cells["gridColumnStock"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_TypeID"].Value;
            gr.Cells["gridColumnMaID"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_ID"].Value;
            gr.Cells["material"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_zhujima"].Value;
            gr.Cells["gridColumnName"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Name"].Value;
            gr.Cells["gridColumnModel"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Model"].Value;
            gr.Cells["gridColumnUnit"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Unit"].Value;
            gr.Cells["gridColumnNumber"].Value = 1;
            decimal price = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Ma_Price"].Value.Equals("") ?
                0 : dataGridView1.Rows[e.RowIndex].Cells["Ma_Price"].Value);
            gr.Cells["gridColumnPrice"].Value = price;
            gr.Cells["gridColumnDis"].Value = 100;
            gr.Cells["gridColumnDisPrice"].Value = price;
            gr.Cells["gridColumnMoney"].Value = price;
            //gr.Cells["gridColumnRemark"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Unit"].Value;
            resizablePanelData.Visible = false;

            //当上一次有选择仓库时 默认本次也为上次选择仓库
            if (!string.IsNullOrEmpty(_ClickStorage.Value) && !string.IsNullOrEmpty(_ClickStorage.Key))
            {
                gr.Cells["gridColumnStockCode"].Value = _ClickStorage.Key;
                gr.Cells["gridColumnStock"].Value = _ClickStorage.Value;
            }
            if (newAdd)
            {
                //新增一行
                superGridControl1.PrimaryGrid.NewRow(superGridControl1.PrimaryGrid.Rows.Count);
                //递增数量和金额 默认为1和单价
                gr = (GridRow)superGridControl1.PrimaryGrid.LastSelectableRow;
                _MaterialNumber += 1;
                _MaterialMoney += price;
                gr.Cells["gridColumnNumber"].Value = _MaterialNumber;
                gr.Cells["gridColumnMoney"].Value = _MaterialMoney;
                textBoxX3.Text = _MaterialMoney.ToString();
                textBoxX2.Text = 100.ToString();
                labtextboxTop5.Text = _MaterialMoney.ToString();
            }
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

        #region 初始化数据
        private void InitDataGridView()
        {
            //改为点击可编辑
            superGridControl1.PrimaryGrid.MouseEditMode = MouseEditMode.SingleClick;
            //新增一行 用于给客户操作
            superGridControl1.PrimaryGrid.NewRow(true);
            //最后一行做统计行
            GridRow gr = (GridRow)superGridControl1.PrimaryGrid.
                Rows[superGridControl1.PrimaryGrid.Rows.Count - 1];
            gr.ReadOnly = true;
            gr.CellStyles.Default.Background.Color1 = Color.Gray;
            gr.Cells["gridColumnStock"].Value = "合计";
            gr.Cells["gridColumnStock"].CellStyles.Default.Alignment =
                DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gr.Cells["gridColumnNumber"].Value = 0;
            gr.Cells["gridColumnNumber"].CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gr.Cells["gridColumnNumber"].CellStyles.Default.Background.Color1 = Color.Red;
            gr.Cells["gridColumnMoney"].Value = 0;
            gr.Cells["gridColumnMoney"].CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gr.Cells["gridColumnMoney"].CellStyles.Default.Background.Color1 = Color.Red;
        }

        /// <summary>
        /// 初始化商品下拉别表的数据
        /// </summary>
        private void InitMaterialDataGridView()
        {
            DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_ID";
            dgvc.Visible = false;
            dgvc.HeaderText = "maid";
            dgvc.DataPropertyName = "Ma_ID";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_PicName";
            dgvc.Visible = false;
            dgvc.HeaderText = "pic";
            dgvc.DataPropertyName = "Ma_PicName";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_RFID";
            dgvc.Visible = false;
            dgvc.HeaderText = "rfid";
            dgvc.DataPropertyName = "Ma_RFID";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Code";
            dgvc.Visible = false;
            dgvc.HeaderText = "code";
            dgvc.DataPropertyName = "Ma_Code";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_TypeID";
            dgvc.Visible = false;
            dgvc.HeaderText = "TypeID";
            dgvc.DataPropertyName = "Ma_TypeID";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_TypeName";
            dgvc.Visible = false;
            dgvc.HeaderText = "TypeName";
            dgvc.DataPropertyName = "Ma_TypeName";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Price";
            dgvc.Visible = false;
            dgvc.HeaderText = "price";
            dgvc.DataPropertyName = "Ma_Price";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_PriceA";
            dgvc.Visible = false;
            dgvc.HeaderText = "priceA";
            dgvc.DataPropertyName = "Ma_PriceA";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_PriceB";
            dgvc.Visible = false;
            dgvc.HeaderText = "priceB";
            dgvc.DataPropertyName = "Ma_PriceB";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_PriceC";
            dgvc.Visible = false;
            dgvc.HeaderText = "priceC";
            dgvc.DataPropertyName = "Ma_PriceC";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_PriceD";
            dgvc.Visible = false;
            dgvc.HeaderText = "priceD";
            dgvc.DataPropertyName = "Ma_PriceD";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_PriceE";
            dgvc.Visible = false;
            dgvc.HeaderText = "priceE";
            dgvc.DataPropertyName = "Ma_PriceE";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_CreateDate";
            dgvc.Visible = false;
            dgvc.HeaderText = "CreateDate";
            dgvc.DataPropertyName = "Ma_CreateDate";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Supplier";
            dgvc.Visible = false;
            dgvc.HeaderText = "Supplier";
            dgvc.DataPropertyName = "Ma_Supplier";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_SupID";
            dgvc.Visible = false;
            dgvc.HeaderText = "SupID";
            dgvc.DataPropertyName = "Ma_SupID";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Unit";
            dgvc.Visible = false;
            dgvc.HeaderText = "Unit";
            dgvc.DataPropertyName = "Ma_Unit";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_InPrice";
            dgvc.Visible = false;
            dgvc.HeaderText = "InPrice";
            dgvc.DataPropertyName = "Ma_InPrice";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_InDate";
            dgvc.Visible = false;
            dgvc.HeaderText = "InDate";
            dgvc.DataPropertyName = "Ma_InDate";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Remark";
            dgvc.Visible = false;
            dgvc.HeaderText = "Remark";
            dgvc.DataPropertyName = "Ma_Remark";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Enable";
            dgvc.Visible = false;
            dgvc.HeaderText = "Enable";
            dgvc.DataPropertyName = "Ma_Enable";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Clear";
            dgvc.Visible = false;
            dgvc.HeaderText = "Clear";
            dgvc.DataPropertyName = "Ma_Clear";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Safeyone";
            dgvc.Visible = false;
            dgvc.HeaderText = "Safeyone";
            dgvc.DataPropertyName = "Ma_Safeyone";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Safetytwo";
            dgvc.Visible = false;
            dgvc.HeaderText = "Safetytwo";
            dgvc.DataPropertyName = "Ma_Safetytwo";
            dataGridView1.Columns.Add(dgvc);


            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_zhujima";
            dgvc.Visible = true;
            dgvc.HeaderText = "助记码";
            dgvc.DataPropertyName = "Ma_zhujima";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Name";
            dgvc.Visible = true;
            dgvc.HeaderText = "物料名称";
            dgvc.DataPropertyName = "Ma_Name";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Model";
            dgvc.Visible = true;
            dgvc.HeaderText = "规格型号";
            dgvc.DataPropertyName = "Ma_Model";
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Ma_Barcode";
            dgvc.Visible = true;
            dgvc.HeaderText = "条码";
            dgvc.DataPropertyName = "Ma_Barcode";
            dataGridView1.Columns.Add(dgvc);
        }

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
                dgvc.Visible = false;
                dgvc.HeaderText = "code";
                dgvc.DataPropertyName = "St_Code";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "St_Name";
                dgvc.Visible = true;
                dgvc.HeaderText = "仓库名称";
                dgvc.DataPropertyName = "St_Name";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "St_Address";
                dgvc.Visible = true;
                dgvc.HeaderText = "仓库地址";
                dgvc.DataPropertyName = "St_Address";
                dataGridViewFujia.Columns.Add(dgvc);

                dataGridViewFujia.DataSource = _AllStorage.Tables[0];
            }
        }
        #endregion
    }
}

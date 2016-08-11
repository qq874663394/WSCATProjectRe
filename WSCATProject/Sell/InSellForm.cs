using BLL;
using DevComponents.DotNetBar.Controls;
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
using Model;
using HelperUtility.Encrypt;

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
        /// 所有的客户列表
        /// </summary>
        private DataSet _AllClient = null;
        /// <summary>
        /// 所有收款账号
        /// </summary>
        private DataTable _AllBank = null;
        /// <summary>
        /// 选择的仓库
        /// </summary>
        private KeyValuePair<string, string> _ClickStorage;
        /// <summary>
        /// 销售单单号
        /// </summary>
        private string _SellOdd = "";
        /// <summary>
        /// 客户编号
        /// </summary>
        private string _ClientCode = "";
        /// <summary>
        /// 账号Code
        /// </summary>
        private string _BankCode = "";
        /// <summary>
        /// 保存仓库的Code
        /// </summary>
        private string _StorageCode = "";
        /// <summary>
        /// 保存商品Code
        /// </summary>
        private string _MaterialCode = "";
        /// <summary>
        /// 点击小拉列表搜索
        /// </summary>
        private bool _SosoStater = false;
        /// <summary>
        /// 点击的项,1为仓库,2为客户,3为收款账号
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

        public string SellOdd
        {
            get { return _SellOdd; }

            set { _SellOdd = value; }
        }

        private double queshaoshu = 0;//缺少数量

        //全局变量的状态判断是开单还是补货
        private int _state;
        public int State
        {
            get { return _state; }

            set { _state = value; }
        }
        #endregion
        private void InSellForm_Load(object sender, EventArgs e)
        {

            MaterialManager mm = new MaterialManager();//商品
            StorageManager sm = new StorageManager();//仓库
            ClientManager clien = new ClientManager();//客户
            BankAccountManager bank = new BankAccountManager();//收款账号
            _AllMaterial = mm.GetList("");
            _AllStorage = sm.GetList("");
            _AllClient = clien.GetList("");
            _AllBank = bank.SelBankAccount2();

            //禁用自动创建列
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewFujia.AutoGenerateColumns = false;
            //初始化商品下拉列表
            InitMaterialDataGridView();
            //初始化datagridview
            InitDataGridView();

            dataGridView1.DataSource = _AllMaterial.Tables[0];
            //销售单单号
            SellOdd = BuildCode.ModuleCode("SS");
            textBoxOddNumbers.Text = SellOdd;

            //绑定事件 双击事填充内容并隐藏列表
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            dataGridViewFujia.CellDoubleClick += DataGridViewFujia_CellDoubleClick;

            //使控件只能输入正确的数字和小数点
            textBoxX2.CommandKeyDown += textBox_CommandKeyDown;
            textBoxX3.CommandKeyDown += textBox_CommandKeyDown;
            labtextboxTop3.CommandKeyDown += textBox_CommandKeyDown;
            labtextboxTop5.CommandKeyDown += textBox_CommandKeyDown;
            //需求数量
            GridDoubleInputEditControl gdiecNumber = superGridControl1.PrimaryGrid.Columns["gridColumnNumber"].EditControl as GridDoubleInputEditControl;
            gdiecNumber.MinValue = 0;
            gdiecNumber.MaxValue = 999999999;
            //实发数量
            GridDoubleInputEditControl gdiecShifa = superGridControl1.PrimaryGrid.Columns["gridColumnshifashu"].EditControl as GridDoubleInputEditControl;
            gdiecShifa.MinValue = 0;
            gdiecShifa.MaxValue = 999999999;
            //缺少数量
            GridDoubleInputEditControl gdiecQushao = superGridControl1.PrimaryGrid.Columns["gridColumnqueshao"].EditControl as GridDoubleInputEditControl;
            gdiecQushao.MinValue = 0;
            gdiecQushao.MaxValue = 999999999;
            //单价  
            GridDoubleInputEditControl gdiecdanjia = superGridControl1.PrimaryGrid.Columns["gridColumnPrice"].EditControl as GridDoubleInputEditControl;
            gdiecdanjia.MinValue = 0;
            gdiecdanjia.MaxValue = 999999999;

        }
        /// <summary>
        /// 绑定pictureBox表格的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewFujia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //绑定客户信息的
            if (_Click == 2)
            {
                string code = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_Code"].Value.ToString();
                string name = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_Name"].Value.ToString();
                string area = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_area"].Value.ToString();
                string address = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_Address"].Value.ToString();
                string linkMan = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_LinkMan"].Value.ToString();
                string phone = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_Phone"].Value.ToString();//手机
                string phone2 = dataGridViewFujia.Rows[e.RowIndex].Cells["Cli_PhoneTwo"].Value.ToString();//座机
                _ClientCode = code;
                labtextboxTop2.Text = name;
                this.labtextboxTop7.Text = area.Replace("/", "") + address;
                this.labtextboxTop8.Text = linkMan;
                this.labtextboxTop9.Text = phone + ";" + phone2;
                _SosoStater = true;
                resizablePanel1.Visible = false;
            }
            //仓库信息
            if (_Click == 1)
            {
                GridRow gr = (GridRow)superGridControl1.PrimaryGrid.Rows[ClickRowIndex];
                string code = dataGridViewFujia.Rows[e.RowIndex].Cells["St_Code"].Value.ToString();
                string name = dataGridViewFujia.Rows[e.RowIndex].Cells["St_Name"].Value.ToString();
                gr.Cells["gridColumnStockCode"].Value = code;
                gr.Cells["gridColumnStock"].Value = name;
                _ClickStorage = new KeyValuePair<string, string>(code, name);
                _StorageCode = code;
                resizablePanel1.Visible = false;
            }
            //绑定收款账号的
            if (_Click == 3)
            {
                string code = dataGridViewFujia.Rows[e.RowIndex].Cells["Ba_Code"].Value.ToString();
                string name = dataGridViewFujia.Rows[e.RowIndex].Cells["Ba_OpenBank"].Value.ToString();
                _BankCode = code;
                labtextboxTop4.Text = name;
                _SosoStater = true;
                resizablePanel1.Visible = false;
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
            gr.Cells["gridColumnBarcode"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Barcode"].Value;
            
            gr.Cells["gridColumnTypeid"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_TypeID"].Value;
            //gr.Cells["gridColumnStock"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_TypeID"].Value;
            gr.Cells["gridColumnMaCode"].Value = dataGridView1.Rows[e.RowIndex].Cells["Ma_Code"].Value;
            _MaterialCode = gr.Cells["gridColumnMaCode"].Value.ToString();
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
                //labtextboxTop5.Text = _MaterialMoney.ToString();

            }
            dataGridView1.Focus();
            SendKeys.Send("^{End}{Home}");
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
            gr.CellStyles.Default.Background.Color1 = Color.SkyBlue;
            gr.Cells["gridColumnStock"].Value = "合计";
            gr.Cells["gridColumnStock"].CellStyles.Default.Alignment =
                DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gr.Cells["gridColumnNumber"].Value = 0;
            gr.Cells["gridColumnNumber"].CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gr.Cells["gridColumnNumber"].CellStyles.Default.Background.Color1 = Color.Orange;
            gr.Cells["gridColumnMoney"].Value = 0;
            gr.Cells["gridColumnMoney"].CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gr.Cells["gridColumnMoney"].CellStyles.Default.Background.Color1 = Color.Orange;
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
        /// <summary>
        /// 初始化客户信息
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
                dgvc.Visible = false;
                dgvc.HeaderText = "code";
                dgvc.DataPropertyName = "Cli_Code";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_ID";
                dgvc.Visible = true;
                dgvc.HeaderText = "ID";
                dgvc.DataPropertyName = "Cli_ID";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_Name";
                dgvc.Visible = true;
                dgvc.HeaderText = "客户名称";
                dgvc.DataPropertyName = "Cli_Name";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_area";
                dgvc.Visible = false;
                dgvc.HeaderText = "地区";
                dgvc.DataPropertyName = "Cli_area";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_Address";
                dgvc.Visible = false;
                dgvc.HeaderText = "详细地址";
                dgvc.DataPropertyName = "Cli_Address";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_LinkMan";
                dgvc.Visible = false;
                dgvc.HeaderText = "联系人";
                dgvc.DataPropertyName = "Cli_LinkMan";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_Phone";
                dgvc.Visible = false;
                dgvc.HeaderText = "手机";
                dgvc.DataPropertyName = "Cli_Phone";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Cli_PhoneTwo";
                dgvc.Visible = false;
                dgvc.HeaderText = "座机";
                dgvc.DataPropertyName = "Cli_PhoneTwo";
                dataGridViewFujia.Columns.Add(dgvc);

                dataGridViewFujia.DataSource = _AllClient.Tables[0];
            }
        }
        /// <summary>
        /// 初始化收款账号
        /// </summary>
        private void InitBank()
        {
            if (_Click != 3)
            {
                _Click = 3;
                dataGridViewFujia.DataSource = null;
                dataGridViewFujia.Columns.Clear();

                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Ba_Code";
                dgvc.Visible = true;
                dgvc.HeaderText = "code";
                dgvc.DataPropertyName = "编号";
                dataGridViewFujia.Columns.Add(dgvc);

                dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = "Ba_OpenBank";
                dgvc.Visible = true;
                dgvc.HeaderText = "账号名称";
                dgvc.DataPropertyName = "账户名称";
                dataGridViewFujia.Columns.Add(dgvc);

                dataGridViewFujia.DataSource = _AllBank;
            }
        }
        #endregion

        #region 按钮的事件
        //验证完全后,统计单元格数据
        private void superGridControl1_CellValidated(object sender, GridCellValidatedEventArgs e)
        {
            GridRow gr = e.GridPanel.Rows[e.GridCell.RowIndex] as GridRow;
            //若是没数据的行则不做处理
            if (gr.Cells["gridColumnid"].Value == null)
            {
                return;
            }
            if (e.GridCell.GridColumn.Name == "gridColumnNumber" ||
                e.GridCell.GridColumn.Name == "gridColumnshifashu")
            {
                double xuyaoshu = Convert.ToDouble(gr.Cells["gridColumnNumber"].FormattedValue);//需求数量
                double shifanshu = Convert.ToDouble(gr.Cells["gridColumnshifashu"].FormattedValue);//实发数量
                if (shifanshu > xuyaoshu)//实发数量大于需要数量
                {
                    gr.Cells["gridColumnshifashu"].Value = xuyaoshu.ToString();
                }
                if (shifanshu < xuyaoshu)//实发数量小于需求数量
                {
                    queshaoshu = xuyaoshu - shifanshu;
                    gr.Cells["gridColumnqueshao"].Value = queshaoshu.ToString();

                }
                if (shifanshu == xuyaoshu)//实发数量等于需要数量
                {
                    gr.Cells["gridColumnqueshao"].Value = 0;
                }
            }
            if (e.GridCell.GridColumn.Name == "gridColumnNumber" ||
                e.GridCell.GridColumn.Name == "gridColumnPrice" ||
                e.GridCell.GridColumn.Name == "gridColumnDis")
            {
                //添加对应的单价和总价
                if (e.GridCell.GridColumn.Name == "gridColumnNumber" &&
                    !string.IsNullOrEmpty(e.GridCell.FormattedValue))
                {
                    _MaterialNumber += decimal.Parse(e.GridCell.FormattedValue);
                }
                if (e.GridCell.GridColumn.Name == "gridColumnPrice" &&
                    !string.IsNullOrEmpty(e.GridCell.FormattedValue))
                {
                    _MaterialMoney += decimal.Parse(e.GridCell.FormattedValue);
                }
                //计算金额
                decimal number = Convert.ToDecimal(gr.Cells["gridColumnNumber"].FormattedValue);
                decimal dis = Convert.ToDecimal(gr.Cells["gridColumnDis"].FormattedValue) / 100;
                decimal price = Convert.ToDecimal(gr.Cells["gridColumnPrice"].FormattedValue);
                decimal disPrice = price * dis;
                decimal allPrice = number * disPrice;
                gr.Cells["gridColumnDisPrice"].Value = disPrice;
                gr.Cells["gridColumnMoney"].Value = allPrice;
                //逐行统计数据总数
                decimal tempAllNumber = 0;
                decimal tempAllMoney = 0;
                for (int i = 0; i < superGridControl1.PrimaryGrid.Rows.Count - 1; i++)
                {
                    GridRow tempGR = superGridControl1.PrimaryGrid.Rows[i] as GridRow;
                    tempAllNumber += Convert.ToDecimal(tempGR["gridColumnNumber"].FormattedValue);
                    tempAllMoney += Convert.ToDecimal(tempGR["gridColumnMoney"].FormattedValue);
                }
                _MaterialMoney = tempAllMoney;
                _MaterialNumber = tempAllNumber;
                gr = (GridRow)superGridControl1.PrimaryGrid.LastSelectableRow;
                gr["gridColumnNumber"].Value = _MaterialNumber.ToString();
                gr["gridColumnMoney"].Value = _MaterialMoney.ToString();
                textBoxX3.Text = _MaterialMoney.ToString();
                labtextboxTop5.Text = _MaterialMoney.ToString();

                labtextboxTop3.Text = (Convert.ToDecimal(textBoxX3.Text) *
                (Convert.ToDecimal(textBoxX2.Text) / 100)).ToString();
                labtextboxTop5.Text = (Convert.ToDecimal(textBoxX3.Text) -
                    Convert.ToDecimal(labtextboxTop3.Text)).ToString();
            }
        }

        //只允许输入数字/小数点/删除键
        private void textBox_CommandKeyDown(object sender, KeyEventArgs e)
        {
            TextBoxX tbx = sender as TextBoxX;
            if ((e.KeyValue < 48 || e.KeyValue > 57) &&
                e.KeyValue != 8 &&
                (e.KeyValue < 96 || e.KeyValue > 105) &&
                e.KeyValue != 110 &&
                e.KeyValue != 13)
            {
                e.Handled = true;
            }
            if (e.KeyValue == 110) //小数点
            {
                if (tbx.Text.Length <= 0)
                    e.Handled = true;//小数点不能在第一位
                else
                {
                    bool b1 = false;
                    b1 = tbx.Text.Contains(".");
                    if (b1)
                    {
                        e.Handled = true;
                    }
                }
            }
            if (e.KeyValue == 13)
            {
                superGridControl1.Focus();
            }
        }

        //审核过账按钮
        private void buttonExamine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_ClientCode))
            {
                MessageBox.Show("客户不可为空,请选择客户!");
                return;
            }
            SellManager sm = new SellManager();
            GridItemsCollection grs = superGridControl1.PrimaryGrid.Rows;
            List<SellDetail> buyDetailList = new List<SellDetail>();
            Model.Sell sell = new Model.Sell();
            if (grs.Count > 1)
            {

                sell.Sell_Type = XYEEncoding.strCodeHex("销售开单");
                sell.Sell_Code = XYEEncoding.strCodeHex(_SellOdd);
                sell.Sell_Date = this.dateTimePicker1.Value;
                sell.Sell_ClientName = XYEEncoding.strCodeHex(this.labtextboxTop2.Text);
                sell.Sell_AccountCode = XYEEncoding.strCodeHex(_BankCode);
                sell.Sell_OddMoney = XYEEncoding.strCodeHex(this.textBoxX3.Text);
                sell.Sell_InMoney = XYEEncoding.strCodeHex(this.labtextboxTop3.Text);
                sell.Sell_LastMoney = XYEEncoding.strCodeHex(this.labtextboxTop5.Text);
                sell.Sell_TransportType = XYEEncoding.strCodeHex(this.comboBoxEx.Text);
                sell.Sell_Remark = XYEEncoding.strCodeHex(this.labtextboxBotton2.Text);
                sell.Sell_Salesman = XYEEncoding.strCodeHex(this.labtextboxBotton1.Text);
                sell.Sell_Operation = XYEEncoding.strCodeHex(this.labtextboxBotton3.Text);
                sell.Sell_Auditman = XYEEncoding.strCodeHex(this.labtextboxBotton4.Text);
                //sell.sell = XYEEncoding.strCodeHex(this.comboBoxEx1.Text);//收款方式
                sell.Sell_Clear = 1;
                //判断是否付款
                if (Convert.ToDecimal(labtextboxTop5.Text) == 0)
                {
                    sell.Sell_IsPay = 2;
                }
                if (Convert.ToDecimal(this.labtextboxTop5.Text) < Convert.ToDecimal(textBoxX3.Text))
                {
                    sell.Sell_IsPay = 1;
                }
                if (Convert.ToDecimal(this.labtextboxTop5.Text) == Convert.ToDecimal(textBoxX3.Text))
                {
                    sell.Sell_IsPay = 0;
                }
                //预付款的百分百
                if (Convert.ToInt32(XYEEncoding.strCodeHex(this.textBoxX2.Text)) > 100)
                {
                    sell.Sell_PayMathod = Convert.ToInt32(XYEEncoding.strCodeHex(this.textBoxX2.Text));
                }
                else
                {
                    MessageBox.Show("预付金额不能大于100%！");
                    return;
                }
                sell.Sell_IsPutSto = 0;
                sell.Sell_Review = 1;
                //判断发货状态
                if (queshaoshu > 0)
                {
                    sell.Sell_OddStatus = 1;
                }
                if (queshaoshu == 0)
                {
                    sell.Sell_OddStatus = 2;
                }
                int i = 0;
                foreach (GridRow gr in grs)
                {
                    i++;
                    SellDetail selldetail = new SellDetail();
                    if (gr["gridColumnName"].Value == null)
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(gr["gridColumnName"].Value.ToString()))
                    {
                        continue;
                    }
                    if (gr["gridColumnStock"].Value == null || gr["gridColumnStockCode"].Value == null)
                    {
                        MessageBox.Show("货品" +
                            gr["gridColumnName"].Value.ToString() + "仓库未选择,请选择!");
                        return;
                    }
                    if (gr["gridColumnStock"].Value.ToString() == "" ||
                        gr["gridColumnStockCode"].Value.ToString() == "")
                    {
                        MessageBox.Show("货品" +
                            gr["gridColumnName"].Value.ToString() + "仓库未选择,请选择!");
                        return;
                    }

                    selldetail.Sell_LineCode = _SellOdd+"_"+i.ToString();//列表单号
                    selldetail.Sell_StockCode = gr["gridColumnStockCode"].Value.ToString();
                    selldetail.Sell_StockName = gr["gridColumnStock"].Value.ToString();
                    selldetail.Sell_Code = _SellOdd;
                    selldetail.Sell_MaID = gr["gridColumnMaID"].Value.ToString();
                    selldetail.Sell_MaName = gr["gridColumnName"].Value.ToString();
                    selldetail.Sell_Model = gr["gridColumnModel"].Value.ToString();
                    selldetail.Sell_Unit = gr["gridColumnUnit"].Value.ToString();
                    selldetail.Sell_CurNumber = gr["gridColumnNumber"].Value.ToString();//先保存string
                    selldetail.Sell_ReNumber = gr["gridColumnshifashu"].Value.ToString();
                    selldetail.Sell_LostNumber = gr["gridColumnqueshao"].Value.ToString();
                    selldetail.Sell_DiscountAPrice = Convert.ToDecimal(gr["gridColumnPrice"].Value);
                    selldetail.Sell_Discount = Convert.ToDecimal(gr["gridColumnDis"].Value);
                    selldetail.Sell_DiscountBPrice = Convert.ToDecimal(gr["gridColumnDisPrice"].Value);
                    selldetail.Sell_Money = Convert.ToDecimal(gr["gridColumnMoney"].Value);
                    selldetail.Sell_Clear = 1;
                    selldetail.Sell_Remark = gr["gridColumnRemark"].Value == null ?
                        "" : gr["gridColumnRemark"].Value.ToString();

                    buyDetailList.Add(selldetail);
                }
                SellProcess sellp = new SellProcess();//操作流程
                sellp.Sp_Code = XYEEncoding.strCodeHex(BuildCode.ModuleCode("Sl"));
                sellp.Sp_Datetime = this.dateTimePicker1.Value;
                sellp.Sp_SellLineno = XYEEncoding.strCodeHex(_SellOdd);
                sellp.Sp_Ope = XYEEncoding.strCodeHex(this.labtextboxBotton3.Text);
                sellp.Sp_Opt = XYEEncoding.strCodeHex("审核过账");
                sellp.Sp_Remark = XYEEncoding.strCodeHex(labtextboxBotton2.Text);
                sellp.Sp_Clear = 0;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误代码：1201-审核过账出现异常，错误代码=" + ex.Message);
                    throw;
                }
            }
        }

        //保存并新增按钮
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_ClientCode))
            {
                MessageBox.Show("客户不可为空,请选择客户!");
                return;
            }
            SellManager sm = new SellManager();
            GridItemsCollection grs = superGridControl1.PrimaryGrid.Rows;
            List<SellDetail> buyDetailList = new List<SellDetail>();
            Model.Sell sell = new Model.Sell();
            if (grs.Count > 1)
            {

                sell.Sell_Type = XYEEncoding.strCodeHex("销售开单");
                sell.Sell_Code = XYEEncoding.strCodeHex(_SellOdd);
                sell.Sell_Date = this.dateTimePicker1.Value;
                sell.Sell_ClientName = XYEEncoding.strCodeHex(this.labtextboxTop2.Text);
                sell.Sell_AccountCode = XYEEncoding.strCodeHex(_BankCode);
                sell.Sell_OddMoney = XYEEncoding.strCodeHex(this.textBoxX3.Text);
                sell.Sell_InMoney = XYEEncoding.strCodeHex(this.labtextboxTop3.Text);
                sell.Sell_LastMoney = XYEEncoding.strCodeHex(this.labtextboxTop5.Text);
                sell.Sell_TransportType = XYEEncoding.strCodeHex(this.comboBoxEx.Text);
                sell.Sell_Remark = XYEEncoding.strCodeHex(this.labtextboxBotton2.Text);
                sell.Sell_Salesman = XYEEncoding.strCodeHex(this.labtextboxBotton1.Text);
                sell.Sell_Operation = XYEEncoding.strCodeHex(this.labtextboxBotton3.Text);
                sell.Sell_Auditman = XYEEncoding.strCodeHex(this.labtextboxBotton4.Text);
                //sell.sell = XYEEncoding.strCodeHex(this.comboBoxEx1.Text);//收款方式
                sell.Sell_Clear = 1;
                //判断是否付款
                if (Convert.ToDecimal(labtextboxTop5.Text) == 0)
                {
                    sell.Sell_IsPay = 2;
                }
                if (Convert.ToDecimal(this.labtextboxTop5.Text) < Convert.ToDecimal(textBoxX3.Text))
                {
                    sell.Sell_IsPay = 1;
                }
                if (Convert.ToDecimal(this.labtextboxTop5.Text) == Convert.ToDecimal(textBoxX3.Text))
                {
                    sell.Sell_IsPay = 0;
                }
                //预付款的百分百
                if (Convert.ToInt32(XYEEncoding.strCodeHex(this.textBoxX2.Text)) > 100)
                {
                    sell.Sell_PayMathod = Convert.ToInt32(XYEEncoding.strCodeHex(this.textBoxX2.Text));
                }
                else
                {
                    MessageBox.Show("预付金额不能大于100%！");
                    return;
                }
                sell.Sell_IsPutSto = 0;
                sell.Sell_Review = 0;
                //判断发货状态
                sell.Sell_OddStatus = 0;
                int i = 0;
                foreach (GridRow gr in grs)
                {
                    i++;
                    SellDetail selldetail = new SellDetail();
                    if (gr["gridColumnName"].Value == null)
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(gr["gridColumnName"].Value.ToString()))
                    {
                        continue;
                    }
                    if (gr["gridColumnStock"].Value == null || gr["gridColumnStockCode"].Value == null)
                    {
                        MessageBox.Show("货品" +
                            gr["gridColumnName"].Value.ToString() + "仓库未选择,请选择!");
                        return;
                    }
                    if (gr["gridColumnStock"].Value.ToString() == "" ||
                        gr["gridColumnStockCode"].Value.ToString() == "")
                    {
                        MessageBox.Show("货品" +
                            gr["gridColumnName"].Value.ToString() + "仓库未选择,请选择!");
                        return;
                    }

                    selldetail.Sell_LineCode = _SellOdd + "_" + i.ToString();//列表单号
                    selldetail.Sell_StockCode = gr["gridColumnStockCode"].Value.ToString();
                    selldetail.Sell_StockName = gr["gridColumnStock"].Value.ToString();
                    selldetail.Sell_Code = _SellOdd;
                    selldetail.Sell_MaID = gr["gridColumnMaID"].Value.ToString();
                    selldetail.Sell_MaName = gr["gridColumnName"].Value.ToString();
                    selldetail.Sell_Model = gr["gridColumnModel"].Value.ToString();
                    selldetail.Sell_Unit = gr["gridColumnUnit"].Value.ToString();
                    selldetail.Sell_CurNumber = gr["gridColumnNumber"].Value.ToString();//先保存string
                    selldetail.Sell_ReNumber = gr["gridColumnshifashu"].Value.ToString();
                    selldetail.Sell_LostNumber = gr["gridColumnqueshao"].Value.ToString();
                    selldetail.Sell_DiscountAPrice = Convert.ToDecimal(gr["gridColumnPrice"].Value);
                    selldetail.Sell_Discount = Convert.ToDecimal(gr["gridColumnDis"].Value);
                    selldetail.Sell_DiscountBPrice = Convert.ToDecimal(gr["gridColumnDisPrice"].Value);
                    selldetail.Sell_Money = Convert.ToDecimal(gr["gridColumnMoney"].Value);
                    selldetail.Sell_Clear = 1;
                    selldetail.Sell_Remark = gr["gridColumnRemark"].Value == null ?
                        "" : gr["gridColumnRemark"].Value.ToString();

                    buyDetailList.Add(selldetail);
                }
                SellProcess sellp = new SellProcess();//操作流程
                sellp.Sp_Code = XYEEncoding.strCodeHex(BuildCode.ModuleCode("Sl"));
                sellp.Sp_Datetime = this.dateTimePicker1.Value;
                sellp.Sp_SellLineno = XYEEncoding.strCodeHex(_SellOdd);
                sellp.Sp_Ope = XYEEncoding.strCodeHex(this.labtextboxBotton3.Text);
                sellp.Sp_Opt = XYEEncoding.strCodeHex("销售开单");
                sellp.Sp_Remark = XYEEncoding.strCodeHex(labtextboxBotton2.Text);
                sellp.Sp_Clear = 0;

                try
                {
                    //int influence = bm.AddBatch(buy, buyDetailList);
                    //if (influence < 1)
                    //{
                    //    MessageBox.Show("未新增任何数据,请检查是否未录入数据,或是存在数据为空");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("申请采购单成功,该单正在等待审核中.");
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误代码-1202-保存新增审核单出现异常，错误代码=" + ex.Message);
                    throw;
                }
            }
        }
        //关闭退出按钮
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        //双击隐藏下拉列表
        private void superGridControl1_Click(object sender, EventArgs e)
        {
            resizablePanelData.Visible = false;
            resizablePanel1.Visible = false;


        }
        //点击表格的第一列绑定仓库
        private void superGridControl1_BeginEdit(object sender, GridEditEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "gridColumnStock")
            {
                //绑定仓库列表
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
        //收款账号图标的点击事件
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (_Click != 3)
            {
                InitBank();
            }
        }

        //输入应付金额后面验证
        private void labtextboxTop3_Validated(object sender, EventArgs e)
        {
            try
            {
                labtextboxTop5.Text = (Convert.ToDecimal(textBoxX3.Text) -
                Convert.ToDecimal(labtextboxTop3.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("请输入本次付款金额！" + ex.Message);
            }

        }

        #endregion
        #region 验证客户文本框
        //根据文本框的值，模糊查询 未写
        private void labtextboxTop2_TextChanged(object sender, EventArgs e)
        {
            //SellManager.a(,)
        }

        //获取客户焦点事件
        private void labtextboxTop2_Enter(object sender, EventArgs e)
        {
            _SosoStater = false;
            pictureBox2_Click(sender, e);
            resizablePanel1.Location = new Point(400, 100);
            resizablePanel1.Visible = true;
        }
        //失去客户焦点事件
        private void labtextboxTop2_Leave(object sender, EventArgs e)
        {
            if (_SosoStater == true)
            {
                return;
            }
            if (_SosoStater == false)
            {
                this.labtextboxTop2.Text = "";

                return;
            }
        }

        #endregion
        //隐藏窗体
        private void label3_Click(object sender, EventArgs e)
        {
            resizablePanel1.Visible = false;
        }

        private void panel6_Click_1(object sender, EventArgs e)
        {
            resizablePanel1.Visible = false;
        }
    }
}

using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace WSCATProject.SellForm
{
    public partial class InSellForm : TemplateForm
    {
        public InSellForm()
        {
            InitializeComponent();
        }

        private DataSet _clientDS = null;
        private DataSet _accountDS = null;
        private DataSet _material = null;

        //初始化标题菜单
        protected override void InitTopLab()
        {
            base.InitTopLab();
            labelTitle.Text = "销售开单";
            labelTitle.Font = new System.Drawing.Font(labelTitle.Name,21f,
                FontStyle.Bold | FontStyle.Italic,labelTitle.Font.Unit);

            labTop1.Text = "单据类型：";

            labTop5.Enabled = false;
            labtextboxTop5.Enabled = false;

            pictureBox1.Visible = false;
        }

        //初始上方textbox和lab列表
        protected override void InitTopLabText()
        {
            base.InitTopLabText();
            labtextboxTop1.Text = "销售开单";
        }

        //初始化datagridview列标题
        protected override void InitDataGridViewHeaderColumn()
        {
            base.InitDataGridViewHeaderColumn();

            GridColumn dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inStorage";
            dgvTextBoxColumn.HeaderText = "仓库名称";
            dgvTextBoxColumn.DataPropertyName = "StorageName";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "material";
            dgvTextBoxColumn.HeaderText = "编码、名称、型号";
            dgvTextBoxColumn.DataPropertyName = "inBarcode";
            dgvTextBoxColumn.Width = 150;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inOrderName";
            dgvTextBoxColumn.HeaderText = "货品名称";
            dgvTextBoxColumn.DataPropertyName = "orderName";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inType";
            dgvTextBoxColumn.HeaderText = "规格型号";
            dgvTextBoxColumn.DataPropertyName = "inType";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inUnit";
            dgvTextBoxColumn.HeaderText = "单位";
            dgvTextBoxColumn.DataPropertyName = "inUnit";
            dgvTextBoxColumn.Width = 80;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inNumber";
            dgvTextBoxColumn.HeaderText = "数量";
            dgvTextBoxColumn.DataPropertyName = "inNumber";
            dgvTextBoxColumn.Width = 80;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inPrice";
            dgvTextBoxColumn.HeaderText = "单价";
            dgvTextBoxColumn.DataPropertyName = "inPrice";
            dgvTextBoxColumn.Width = 80;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);


            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inDiscount";
            dgvTextBoxColumn.HeaderText = "折扣率%";
            dgvTextBoxColumn.DataPropertyName = "inDiscount";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inConvertMoney";
            dgvTextBoxColumn.HeaderText = "折后单价";
            dgvTextBoxColumn.DataPropertyName = "inConvertMoney";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inAllPrice";
            dgvTextBoxColumn.HeaderText = "总金额";
            dgvTextBoxColumn.DataPropertyName = "inAllPrice";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inRemark";
            dgvTextBoxColumn.HeaderText = "备注";
            dgvTextBoxColumn.DataPropertyName = "inRemark";
            dgvTextBoxColumn.Width = 80;
            dgvTextBoxColumn.AllowEdit = false;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            this.dataGridViewFujia.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
        }

        /// <summary>
        /// 初始化客户数据的下拉列表
        /// </summary>
        private void addClientDataGridViewColumn()
        {
            dataGridViewFujia.DataSource = null;
            dataGridViewFujia.Columns.Clear();

            DataGridViewColumn dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_Code";
            dgvc.Visible = false;
            dgvc.HeaderText = "编号";
            dgvc.DataPropertyName = "Cli_Code";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_Name";
            dgvc.Visible = true;
            dgvc.HeaderText = "客户名称";
            dgvc.DataPropertyName = "Cli_Name";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_Phone";
            dgvc.Visible = false;
            dgvc.HeaderText = "电话";
            dgvc.DataPropertyName = "Cli_Phone";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_PhoneTwo";
            dgvc.Visible = false;
            dgvc.HeaderText = "手机";
            dgvc.DataPropertyName = "Cli_PhoneTwo";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_Address";
            dgvc.Visible = false;
            dgvc.HeaderText = "地址";
            dgvc.DataPropertyName = "Cli_Address";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_LinkMan";
            dgvc.Visible = false;
            dgvc.HeaderText = "联系人";
            dgvc.DataPropertyName = "Cli_LinkMan";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_Company";
            dgvc.Visible = true;
            dgvc.HeaderText = "公司";
            dgvc.DataPropertyName = "Cli_Company";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Cli_Remark";
            dgvc.Visible = true;
            dgvc.HeaderText = "备注";
            dgvc.DataPropertyName = "Cli_Remark";
            dataGridViewFujia.Columns.Add(dgvc);
        }

        /// <summary>
        /// 加载账户数据
        /// </summary>
        private void addAccountDataGridViewColumn()
        {
            dataGridViewFujia.DataSource = null;
            dataGridViewFujia.Columns.Clear();

            DataGridViewColumn dgvc = new DataGridViewColumn();
            dgvc.Name = "Ba_Code";
            dgvc.Visible = false;
            dgvc.HeaderText = "编号";
            dgvc.DataPropertyName = "Ba_Code";
            dataGridViewFujia.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Ba_OpenBank";
            dgvc.Visible = true;
            dgvc.HeaderText = "编号";
            dgvc.DataPropertyName = "Ba_OpenBank";
            dataGridViewFujia.Columns.Add(dgvc);
        }

        private void InSellForm_Load(object sender, EventArgs e)
        {
            //单击编辑
            superGridControl1.PrimaryGrid.MouseEditMode = MouseEditMode.SingleClick;
            ClientManager client = new ClientManager();
            _clientDS = client.GetList("");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        //单据类型
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        //客户
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClientManager cm = new ClientManager();
            DataSet ds = cm.GetListInSimple();
            addClientDataGridViewColumn();
        }

        //收款账户
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //运输方式 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        

        
    }
}

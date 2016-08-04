using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSCATProject.StockForm
{
    public partial class InStorageForm : TemplateForm
    {
        public InStorageForm()
        {
            InitializeComponent();
        }

        protected override void InitDataGridViewHeaderColumn()
        {
            DataGridViewTextBoxColumn dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inStorage";
            dgvTextBoxColumn.HeaderText = "仓库名称";
            dgvTextBoxColumn.DataPropertyName = "StorageName";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inBarcode";
            dgvTextBoxColumn.HeaderText = "编码、名称、型号";
            dgvTextBoxColumn.DataPropertyName = "inBarcode";
            dgvTextBoxColumn.Width = 150;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inOrderName";
            dgvTextBoxColumn.HeaderText = "货品名称";
            dgvTextBoxColumn.DataPropertyName = "orderName";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inType";
            dgvTextBoxColumn.HeaderText = "规格型号";
            dgvTextBoxColumn.DataPropertyName = "inType";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inUnit";
            dgvTextBoxColumn.HeaderText = "单位";
            dgvTextBoxColumn.DataPropertyName = "inUnit";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inNumber";
            dgvTextBoxColumn.HeaderText = "数量";
            dgvTextBoxColumn.DataPropertyName = "inNumber";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inPrice";
            dgvTextBoxColumn.HeaderText = "单价";
            dgvTextBoxColumn.DataPropertyName = "inPrice";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);


            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inDiscount";
            dgvTextBoxColumn.HeaderText = "折扣率%";
            dgvTextBoxColumn.DataPropertyName = "inDiscount";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inConvertMoney";
            dgvTextBoxColumn.HeaderText = "折后单价";
            dgvTextBoxColumn.DataPropertyName = "inConvertMoney";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inAllPrice";
            dgvTextBoxColumn.HeaderText = "总金额";
            dgvTextBoxColumn.DataPropertyName = "inAllPrice";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inRemark";
            dgvTextBoxColumn.HeaderText = "备注";
            dgvTextBoxColumn.DataPropertyName = "inRemark";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);
        }

        protected override void InitTopLab()
        {
            labelTitle.Text = "付款单";
            labelTitle.ForeColor = Color.Orange;
            labTop2.Text = "供 应 商：";
            labTop4.Text = "付款账户：";
            labTop6.Text = "自定义一：";
            labTop7.Text = "自定义二：";
            labTop8.Visible = false;
            labTop9.Visible = false;
        }

        protected override void InitTopLabText()
        {
            labtextboxTop8.Visible = false;
            labtextboxTop9.Visible = false;
        }

        protected override void InitBottomLab()
        {
            labBotton3.Enabled = false;
            labBotton4.Enabled = false;
        }

        protected override void InitBottonLabText()
        {
            labtextboxBotton3.Enabled = false;
            labtextboxBotton4.Enabled = false;
        }
    }
}

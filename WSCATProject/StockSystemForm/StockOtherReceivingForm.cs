using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSCATProject.StockSystemForm
{
    public partial class StockOtherReceivingForm : TemplateForm
    {
        public StockOtherReceivingForm()
        {
            InitializeComponent();
        }

        protected override void InitTopLab()
        {
            base.InitTopLab();
            labelTitle.Text = "其他收获单";
            labelTitle.Font = new System.Drawing.Font(labelTitle.Font.Name, 21f,
                FontStyle.Italic | FontStyle.Bold, labelTitle.Font.Unit);

            labTop1.Text = "仓库：";
            labTop3.Text = "自定义一：";

            labTop2.Visible = false;
            labTop4.Visible = false;
            labTop5.Visible = false;
            labTop6.Visible = false;
            labTop7.Visible = false;
            labTop8.Visible = false;
            labTop9.Visible = false;

            labtextboxTop2.Visible = false;
            labtextboxTop4.Visible = false;
            labtextboxTop5.Visible = false;
            labtextboxTop6.Visible = false;
            labtextboxTop7.Visible = false;
            labtextboxTop8.Visible = false;
            labtextboxTop9.Visible = false;

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            checkBox1.Visible = false;
        }

        protected override void InitDataGridViewHeaderColumn()
        {
            base.InitDataGridViewHeaderColumn();

            DataGridViewTextBoxColumn dgvTextBoxColumn = new DataGridViewTextBoxColumn();

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
            dgvTextBoxColumn.Name = "StockMoney";
            dgvTextBoxColumn.HeaderText = "金额";
            dgvTextBoxColumn.DataPropertyName = "StockMoney";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "inRemark";
            dgvTextBoxColumn.HeaderText = "备注";
            dgvTextBoxColumn.DataPropertyName = "inRemark";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "StockCustom";
            dgvTextBoxColumn.HeaderText = "自定义一";
            dgvTextBoxColumn.DataPropertyName = "StockCustom";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            this.dataGridViewFujia.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
        }
    }
}

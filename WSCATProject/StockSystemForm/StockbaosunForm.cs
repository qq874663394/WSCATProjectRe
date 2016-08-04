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
    public partial class StockbaosunForm : TemplateForm
    {
        public StockbaosunForm()
        {
            InitializeComponent();
        }

        protected override void InitTopLab()
        {
            base.InitTopLab();
            labelTitle.Text = "其他报损单";
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
            DataGridViewTextBoxColumn dgvTextBoxColumn = new DataGridViewTextBoxColumn();

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageBarcode";
            dgvTextBoxColumn.HeaderText = "编码、名称、型号";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageBarcode";
            dgvTextBoxColumn.Width = 150;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageOrder";
            dgvTextBoxColumn.HeaderText = "货品名称";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageOrder";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageType";
            dgvTextBoxColumn.HeaderText = "规格型号";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageType";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageUnit";
            dgvTextBoxColumn.HeaderText = "单位";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageUnit";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageNumber";
            dgvTextBoxColumn.HeaderText = "数量";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageNumber";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakagePrice";
            dgvTextBoxColumn.HeaderText = "单价";
            dgvTextBoxColumn.DataPropertyName = "stockBreakagePrice";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageMoney";
            dgvTextBoxColumn.HeaderText = "金额";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageMoney";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageRemark";
            dgvTextBoxColumn.HeaderText = "备注";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageRemark";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockBreakageCustom";
            dgvTextBoxColumn.HeaderText = "自定义一";
            dgvTextBoxColumn.DataPropertyName = "stockBreakageCustom";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

        }
    }
}

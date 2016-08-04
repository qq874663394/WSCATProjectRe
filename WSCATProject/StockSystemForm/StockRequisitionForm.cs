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
    public partial class StockRequisitionForm : TemplateForm
    {
        public StockRequisitionForm()
        {
            InitializeComponent();
        }

        protected override void InitTopLab()
        {
            base.InitTopLab();
            labelTitle.Text = "领料单";
            labelTitle.Font = new System.Drawing.Font(labelTitle.Font.Name, 21f,
                FontStyle.Italic | FontStyle.Bold, labelTitle.Font.Unit);

            labTop1.Text = "单据类型：";
            labTop2.Text = "仓库：";
            labTop3.Text = "自定义一：";

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
            checkBox1.Visible = false;
        }

        protected override void InitDataGridViewHeaderColumn()
        {
            DataGridViewTextBoxColumn dgvTextBoxColumn = new DataGridViewTextBoxColumn();

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionBarcode";
            dgvTextBoxColumn.HeaderText = "编码、名称、型号";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionBarcode";
            dgvTextBoxColumn.Width = 150;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionOrder";
            dgvTextBoxColumn.HeaderText = "货品名称";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionOrder";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionType";
            dgvTextBoxColumn.HeaderText = "规格型号";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionType";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionUnit";
            dgvTextBoxColumn.HeaderText = "单位";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionUnit";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionNumber";
            dgvTextBoxColumn.HeaderText = "数量";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionNumber";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionPrice";
            dgvTextBoxColumn.HeaderText = "单价";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionPrice";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionMoney";
            dgvTextBoxColumn.HeaderText = "金额";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionMoney";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockRequisitionRemark";
            dgvTextBoxColumn.HeaderText = "备注";
            dgvTextBoxColumn.DataPropertyName = "stockRequisitionRemark";
            dgvTextBoxColumn.Width = 200;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

        }
    }
}

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
    public partial class StockdiaoboForm : TemplateForm
    {
        public StockdiaoboForm()
        {
            InitializeComponent();
        }

        protected override void InitTopLab()
        {
            labelTitle.Text = "同价调拨单";
            labelTitle.Font = new System.Drawing.Font(labelTitle.Font.Name, 21f,
                FontStyle.Italic | FontStyle.Bold, labelTitle.Font.Unit);

            labTop1.Text = "单据类型：";
            labTop3.Text = "调出仓库：";
            labTop4.Text = "调入仓库：";

            labTop2.Visible = false;
            labTop5.Visible = false;
            labTop6.Visible = false;
            labTop7.Visible = false;
            labTop8.Visible = false;
            labTop9.Visible = false;

            labtextboxTop2.Visible = false;
            labtextboxTop5.Visible = false;
            labtextboxTop6.Visible = false;
            labtextboxTop7.Visible = false;
            labtextboxTop8.Visible = false;
            labtextboxTop9.Visible = false;

            pictureBox2.Location = new Point(191, 51);
            pictureBox3.Location = new Point(472, 50);
            pictureBox4.Visible = false;
            checkBox1.Visible = false;
        }

        private bool _btnAdd = false;
        protected override void ClickPicBox(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            switch (pb.Name)
            {
                case "pictureBox1":
                    resizablePanel1.Location = new Point(120, 102);
                    break;
                case "pictureBox2":
                    resizablePanel1.Location = new Point(120, 132);
                    break;
                case "pictureBox3":
                    resizablePanel1.Location = new Point(400, 132);
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

        protected override void InitDataGridViewHeaderColumn()
        {
            DataGridViewTextBoxColumn dgvTextBoxColumn = new DataGridViewTextBoxColumn();

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotBarcode";
            dgvTextBoxColumn.HeaderText = "编码、名称、型号";
            dgvTextBoxColumn.DataPropertyName = "stockAllotBarcode";
            dgvTextBoxColumn.Width = 150;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotOrderName";
            dgvTextBoxColumn.HeaderText = "货品名称";
            dgvTextBoxColumn.DataPropertyName = "stockAllotorderName";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotType";
            dgvTextBoxColumn.HeaderText = "规格型号";
            dgvTextBoxColumn.DataPropertyName = "stockAllotType";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotUnit";
            dgvTextBoxColumn.HeaderText = "单位";
            dgvTextBoxColumn.DataPropertyName = "stockAllotUnit";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotNumber";
            dgvTextBoxColumn.HeaderText = "数量";
            dgvTextBoxColumn.DataPropertyName = "stockAllotNumber";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotPrice";
            dgvTextBoxColumn.HeaderText = "单价";
            dgvTextBoxColumn.DataPropertyName = "stockAllotPrice";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotMoney";
            dgvTextBoxColumn.HeaderText = "金额";
            dgvTextBoxColumn.DataPropertyName = "stockAllotMoney";
            dgvTextBoxColumn.Width = 100;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextBoxColumn.Name = "stockAllotRemark";
            dgvTextBoxColumn.HeaderText = "备注";
            dgvTextBoxColumn.DataPropertyName = "stockAllotRemark";
            dgvTextBoxColumn.Width = 80;
            dataGridViewFujia.Columns.Add(dgvTextBoxColumn);

        }
    }
}

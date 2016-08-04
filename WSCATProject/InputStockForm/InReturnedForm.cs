using DevComponents.DotNetBar.SuperGrid;
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
    public partial class InReturnedForm : TemplateForm
    {
        public InReturnedForm()
        {
            InitializeComponent();
        }

        protected override void InitDataGridViewHeaderColumn()
        {
            GridColumn dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inStorage";
            dgvTextBoxColumn.HeaderText = "仓库名称";
            dgvTextBoxColumn.DataPropertyName = "StorageName";
            dgvTextBoxColumn.Width = 100;
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

            dgvTextBoxColumn = new GridColumn();
            dgvTextBoxColumn.Name = "inBarcode";
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
            superGridControl1.PrimaryGrid.Columns.Add(dgvTextBoxColumn);

        }

        protected override void InitTopLab()
        {
            labelTitle.Text = "采购退货单";
            labelTitle.ForeColor = Color.Orange;
            labelTitle.Font = new Font(labelTitle.Name, 21.0f 
                ,FontStyle.Bold, labelTitle.Font.Unit);
            //
            labTop2.Text = "供 应 商：";
            labTop4.Text = "付款账户："; 
            labTop6.Text = "自定义一：";
            labTop7.Text = "自定义二：";
            labTop8.Visible = false;
            labTop9.Visible = false;
            labtextboxTop8.Visible = false;
            labtextboxTop9.Visible = false;
        }
    }
}

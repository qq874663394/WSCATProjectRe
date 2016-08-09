using BLL;
using DevComponents.DotNetBar.Controls;
using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCATProject.Base.Buys
{
    public partial class BuyCheckDetailForm : TemplateForm
    {
        BuyDetailManager bdm = new BuyDetailManager();
        BuyManager bm = new BuyManager();
        SupplierManager sm = new SupplierManager();
        public string code { get; set; }
        public string typeState { get; set; }
        public string picboxname { get; set; }
        public int? auditState { get; set; }
        public BuyCheckDetailForm()
        {
            InitializeComponent();
        }

        private void BuyCheckDetailForm_Load(object sender, EventArgs e)
        {
            Text = "审核申请单";

            try
            {
                Buy bd = bm.SelBuyByCodeToModel(code);
                auditState = bd.Buy_AuditStatus;

                labtextboxTop1.Enabled = false;
                labtextboxTop1.BackColor = Color.White;
                pictureBox1.Enabled = false;
                Supplier su = sm.SelUpdateSupplierByCode(bd.Buy_SupplierCode);
                labtextboxTop1.Text = bd.Buy_Class;
                labtextboxTop2.Text = bd.Buy_SupplierName;
                labtextboxTop3.Text = "";
                labtextboxTop4.Text = su.Su_Bank;
                labtextboxTop5.Text = su.Su_Surplus;

                //业务员
                labtextboxBotton1.Text = bd.Buy_SalesMan;
                //摘要
                labtextboxBotton2.Text = bd.Buy_Remark;
                //制单人
                labtextboxBotton3.Text = bd.Buy_Operation;
                //审核人
                labtextboxBotton4.Text = bd.Buy_AuditMan;
                textBoxOddNumbers.Text = code;
                superGridControl1.PrimaryGrid.DataSource = bdm.SelBuyDetailByCodeToTable(code);
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3203-审核申请单加载时异常，异常信息：" + ex.Message);
            }
        }
        protected override void dataGridViewFujia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string TextValue = dataGridViewFujia.CurrentRow.Cells["ColumnsValue"].Value.ToString();
            switch (picboxname)
            {
                case "pictureBox1":
                    labtextboxTop1.Text = TextValue;
                    break;
                case "pictureBox2":
                    labtextboxTop2.Text = TextValue;
                    break;
                case "pictureBox3":
                    labtextboxTop4.Text = TextValue;
                    break;
                case "pictureBox4":
                    labtextboxTop6.Text = TextValue;
                    break;
            }
            resizablePanel1.Visible = false;
            BtnAdd = false;
        }
        protected override void ClickPicBox(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn gc;
            PictureBox pb = sender as PictureBox;
            picboxname = pb.Name;
            try
            {
                switch (pb.Name)
                {
                    case "pictureBox1":
                        dataGridViewFujia.Columns.Clear();
                        OrderTypeManager otm = new OrderTypeManager();
                        dataGridViewFujia.AutoGenerateColumns = false;
                        gc = new DataGridViewTextBoxColumn();
                        gc.DataPropertyName = "Ot_Name";
                        gc.Name = "ColumnsValue";
                        gc.HeaderText = "类型名称";
                        dataGridViewFujia.Columns.Add(gc);
                        dataGridViewFujia.DataSource = otm.SelOrderType();
                        resizablePanel1.Location = new Point(120, 100);
                        break;
                    case "pictureBox2":
                        dataGridViewFujia.Columns.Clear();
                        SupplierManager sm = new SupplierManager();
                        dataGridViewFujia.AutoGenerateColumns = false;
                        gc = new DataGridViewTextBoxColumn();
                        gc.DataPropertyName = "单位名称";
                        gc.Name = "ColumnsValue";
                        gc.HeaderText = "供应商名称";
                        dataGridViewFujia.Columns.Add(gc);
                        dataGridViewFujia.DataSource = sm.SelSupplierTable();
                        resizablePanel1.Location = new Point(400, 100);
                        break;
                    case "pictureBox3":
                        dataGridViewFujia.Columns.Clear();
                        BankAccountManager bam = new BankAccountManager();
                        dataGridViewFujia.AutoGenerateColumns = false;
                        gc = new DataGridViewTextBoxColumn();
                        gc.DataPropertyName = "开户行";
                        gc.Name = "ColumnsValue";
                        gc.HeaderText = "账户名称";
                        dataGridViewFujia.Columns.Add(gc);
                        dataGridViewFujia.DataSource = bam.SelBankAccount(false);
                        resizablePanel1.Location = new Point(400, 130);
                        break;
                    case "pictureBox4":
                        resizablePanel1.Location = new Point(120, 160);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3204-审核申请单选择框异常，异常信息：" + ex.Message);
            }
            if (!BtnAdd)
            {
                resizablePanel1.Visible = true;
                BtnAdd = true;
            }
            else
            {
                resizablePanel1.Size = new System.Drawing.Size(248, 144);
                resizablePanel1.Visible = true;
                resizablePanel1.Focus();
            }
        }

        private void buttonExamine_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (auditState == 0)
            {
                try
                {
                    result = bm.UpdateBuyByCode(1, 1, code);
                    if (result > 0)
                    {
                        labtextboxTop1.Enabled = false;
                        labtextboxTop1.BackColor = Color.White;
                        pictureBox1.Enabled = false;

                        labtextboxTop2.Enabled = false;
                        labtextboxTop2.BackColor = Color.White;
                        pictureBox2.Enabled = false;

                        labtextboxTop3.Enabled = false;
                        labtextboxTop3.BackColor = Color.White;
                        pictureBox3.Enabled = false;

                        labtextboxTop4.Enabled = false;
                        labtextboxTop4.BackColor = Color.White;
                        pictureBox4.Enabled = false;

                        labtextboxTop5.Enabled = false;
                        labtextboxTop5.BackColor = Color.White;

                        labtextboxBotton1.Enabled = false;
                        labtextboxBotton1.BackColor = Color.White;

                        labtextboxBotton2.Enabled = false;
                        labtextboxBotton2.BackColor = Color.White;

                        labtextboxBotton3.Enabled = false;
                        labtextboxBotton3.BackColor = Color.White;

                        labtextboxBotton4.Enabled = false;
                        labtextboxBotton4.BackColor = Color.White;

                        buttonExamine.Text = "反审核";
                        auditState = 1;
                    }
                    else
                    {
                        result = bm.UpdateBuyByCode(0, 0, code);
                        if (result > 0)
                        {
                            labtextboxTop1.Enabled = false;
                            labtextboxTop1.BackColor = Color.White;
                            pictureBox1.Enabled = false;

                            labtextboxTop2.Enabled = true;
                            labtextboxTop2.BackColor = Color.White;
                            pictureBox2.Enabled = true;

                            labtextboxTop3.Enabled = true;
                            labtextboxTop3.BackColor = Color.White;
                            pictureBox3.Enabled = true;

                            labtextboxTop4.Enabled = true;
                            labtextboxTop4.BackColor = Color.White;
                            pictureBox4.Enabled = true;

                            labtextboxTop5.Enabled = true;
                            labtextboxTop5.BackColor = Color.White;

                            labtextboxBotton1.Enabled = true;
                            labtextboxBotton1.BackColor = Color.White;

                            labtextboxBotton2.Enabled = true;
                            labtextboxBotton2.BackColor = Color.White;

                            labtextboxBotton3.Enabled = true;
                            labtextboxBotton3.BackColor = Color.White;

                            labtextboxBotton4.Enabled = true;
                            labtextboxBotton4.BackColor = Color.White;

                            buttonExamine.Text = "审核过账";
                            auditState = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误代码:3202-审核采购单异常，异常信息：" + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}

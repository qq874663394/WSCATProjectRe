using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using HelperUtility.Encrypt;
using HelperUtility;
using Model;
using System.Data.SqlClient;
using DAL;
using System.Text.RegularExpressions;
using DevComponents.DotNetBar.SuperGrid;

namespace WSCATProject
{
    public partial class BuyPaymentApplication : Form
    {
        BuyPaymentManager bpm = new BuyPaymentManager();
        SupplierManager sm = new SupplierManager();
        BankAccountManager bam = new BankAccountManager();
        EmpolyeeManager em = new EmpolyeeManager();
        BuyManager bm = new BuyManager();
        CodingHelper ch = new CodingHelper();
        
        public string pbName;//根据图片Name对应相应的datagridview
        public int zhuangtai;//审核状态

        public BuyPaymentApplication()
        {
            InitializeComponent();
        }

        private void BuyPaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                //绑定采购明细
                DataTable dt = ch.DataTableReCoding(bpm.SelEmp(" buy.Buy_Code='" + XYEEncoding.strCodeHex(_buycode) + "'").Tables[0]);
                superGridControl1.PrimaryGrid.DataSource = dt;
                superGridControl1.PrimaryGrid.AllowEdit = false;

                LoginInfomation l = LoginInfomation.getInstance();
                l.UserName = "sss";
                ltxt_operation.Text = l.UserName;

                txt_yifu.Visible = false;
                ltxt_weipay.ReadOnly = true;
                dataGridViewFujia.ReadOnly = true;
                dataGridViewFujia.AllowUserToResizeColumns = false;//是否可以调整列的大小
                dataGridViewFujia.AllowUserToResizeRows = false;//是否可以调整行的大小     

                txt_caigoucode.Text = _buycode;
                ltxt_suname.Text = _suname;
                ltxt_AccountName.Text = _acountname;
                txt_shif.Text = _fukuan;
                ltxt_saleman.Text = _saleman;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3205-创建采购付款单异常，异常信息：" + ex.Message);
            }
            
            textBoxOddNumbers.Text = BuildCode.ModuleCode("AP");
        }

        #region  保存
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (InsTextIsNull() == false)
            {
                return;
            }
            try
            {
                int result = InsBuypaymentFun();
                if (result > 0)
                {
                    bool r = bm.PaymentUpdateByCode(XYEEncoding.strCodeHex( _buycode), 2);
                    if (r)
                    {
                        MessageBox.Show("保存成功");
                        Close();
                        Dispose();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("保存失败");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3206-保存采购付款单异常，异常信息：" + ex.Message);
            }
        }

        private int InsBuypaymentFun()
        {
            BuyPayment bp = new BuyPayment();
            bp.Buy_Date = Convert.ToDateTime(dateTimePicker1.Text);
            bp.Buy_Code = textBoxOddNumbers.Text.Trim();
            bp.Buy_BCode = txt_caigoucode.Text.Trim();
            bp.Buy_SuName = ltxt_suname.Text.Trim();
            bp.Buy_AccountName = ltxt_AccountName.Text.Trim();
            bp.Buy_AmountPay = txt_shif.Text.Trim();
            bp.Buy_moneyOwed = ltxt_weipay.Text.Trim();
            bp.Buy_AccountPaid = txt_yifu.Text.Trim().ToString();
            bp.Buy_SalesMan = ltxt_saleman.Text.Trim();
            bp.Buy_Remark = ltxt_remark.Text.Trim();
            bp.Buy_States = zhuangtai;
            bp.Buy_Class = "37425C525B0A5141";
            return bpm.InsBuyPayment(bp);
        }

        #endregion

        #region 把供应商、账户、业务员分别绑定到dataGridView
        protected virtual void ClickPicBox(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pbName = pb.Name;
            switch (pb.Name)
            {
                case "pictureBox1":
                    resizablePanel1.Location = new Point(190, 115);
                    DataTable dt = sm.SelSupplierTable2();
                    dataGridViewFujia.DataSource = dt;
                    dataGridViewFujia.Columns[2].Visible = false;
                    dataGridViewFujia.Columns[3].Visible = false;
                    dataGridViewFujia.Columns[4].Visible = false;
                    break;
                case "pictureBox2":
                    resizablePanel1.Location = new Point(190, 150);
                    DataTable dt1 = bam.SelBankAccount2();
                    dataGridViewFujia.DataSource = dt1;
                    break;
                case "pictureBox3":
                    resizablePanel1.Location = new Point(190, 320);
                    DataTable dt2 = ch.DataTableReCoding(em.SelEmp2("").Tables[0]);
                    dataGridViewFujia.DataSource = dt2;
                    break;
            }
            if (!_btnAdd)
            {
                resizablePanel1.Visible = true;
                _btnAdd = true;
            }
            else
            {
                resizablePanel1.Visible = true;
                resizablePanel1.Focus();
            }
        }
        #endregion

        /// <summary>
        /// 点击panel隐藏扩展panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void panel6_Click(object sender, EventArgs e)
        {
            if (resizablePanel1.Visible)
                resizablePanel1.Visible = false;
        }
        //控制面板是否显示
        private bool _btnAdd = false;
        protected bool BtnAdd
        {
            get { return _btnAdd; }
            set { _btnAdd = value; }
        }

        private string _buycode;
        public string BuyCode
        {
            get { return _buycode; }
            set { _buycode = value; }
        }

        private string _suname;
        public string Suname
        {
            get { return _suname; }
            set { _suname = value; }
        }

        private string _acountname;
        public string Acountname
        {
            get { return _acountname; }
            set { _acountname = value; }
        }
        private string _fukuan;
        public string Fukuan
        {
            get { return _fukuan; }
            set { _fukuan = value; }
        }

        private string _saleman;
        public string Saleman
        {
            get { return _saleman; }
            set { _saleman = value; }
        }

        #region  把选中行的值绑定到文本框
        private void dataGridViewFujia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (pbName)
            {
                case "pictureBox1":
                    try
                    {
                        ltxt_suname.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txt_shif.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txt_caigoucode.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[3].Value.ToString();
                        ltxt_AccountName.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[4].Value.ToString();
                        DataTable dt = ch.DataTableReCoding(bpm.SelEmp(" buy.Buy_Code='" + XYEEncoding.strCodeHex(txt_caigoucode.Text) + "'").Tables[0]);
                        superGridControl1.PrimaryGrid.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误代码:3207-审核申请单选择框异常，异常信息：" + ex.Message);
                    }
                    break;
                case "pictureBox2":
                    ltxt_AccountName.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "pictureBox3":
                    ltxt_saleman.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }
            resizablePanel1.Visible = false;
        }
        #endregion

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool InsTextIsNull()
        {
            if (string.IsNullOrWhiteSpace(ltxt_fukuan.Text))
            {
                MessageBox.Show("付款金额不能为空！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(ltxt_suname.Text))
            {
                MessageBox.Show("供应商不能为空！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(ltxt_AccountName.Text))
            {
                MessageBox.Show("付款账户不能为空！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(ltxt_saleman.Text))
            {
                MessageBox.Show("业务员不能为空！");
                return false;
            }
            return true;
        }
        #endregion

        #region  验证金额只允许输入数字和Del
        private void ltxt_fukuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字、小数和Del
            if (!(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                        e.Handled = true;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
                else if (((TextBox)sender).Text.Trim().IndexOf('.') > -1)
                {
                    //小数位最多只能输入一位
                    if (((TextBox)sender).Text.Trim().Substring(((TextBox)sender).Text.Trim().IndexOf('.') + 1).Length >= 1)
                        e.Handled = true;
                }
            }
        }
        #endregion

        #region  验证输入付款金额之前必须先选择供应商，并且不能大于100
        private void ltxt_fukuan_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txt_shif.Text == "")
                {
                    MessageBox.Show("请选择供应商！");
                    return;
                }
                double shifu = Convert.ToDouble(txt_shif.Text);
                double fu = Convert.ToDouble(ltxt_fukuan.Text);
                if (fu > 100)
                {
                    MessageBox.Show("你输入的付款金额比例超出范围，应在【0-101之间】!");
                    ltxt_fukuan.Clear();
                    return;
                }
                double fukuan = shifu * (fu / 100);
                txt_yifu.Text = fukuan.ToString();
                ltxt_weipay.Text = (Convert.ToInt32(txt_shif.Text) - Convert.ToInt32(fukuan)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("只能输入数字和小数!");
                return;
                throw;
            }
        }
        #endregion

        #region 退出
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        #endregion

    }
}

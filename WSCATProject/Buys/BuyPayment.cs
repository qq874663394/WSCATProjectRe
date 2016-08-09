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
using BLL;
using HelperUtility.Encrypt;
using HelperUtility;
using DevComponents.DotNetBar.SuperGrid;

namespace WSCATProject.Buys
{
    public partial class BuyPayment : TemplateForm
    {

        SupplierManager sm = new SupplierManager();
        BankAccountManager bam = new BankAccountManager();
        EmpolyeeManager em = new EmpolyeeManager();
        CodingHelper ch = new CodingHelper();
        BuyPaymentManager bm = new BuyPaymentManager();
        BuyManager buymanager = new BuyManager();
        public bool isflag;
        public int StateType;
        public string id;
        public string pbName;
        private string _yuanyu;//付款金额少的原因

        private double weifujine;
        PayBuySelect pay = new PayBuySelect();
        public BuyPayment(PayBuySelect pay1)
        {
            pay = pay1;
            InitializeComponent();
        }
        public BuyPayment()
        {
        }

        //窗体加载
        private void BuyPayment_Load(object sender, EventArgs e)
        {

            dataGridViewFujia.CellContentDoubleClick -= dataGridViewFujia_CellContentDoubleClick;
            dataGridViewFujia.CellContentDoubleClick += dataGridViewFujia_CellContentDoubleClick;
            superGridControl1.PrimaryGrid.AutoGenerateColumns = true;
            superGridControl1.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            superGridControl1.PrimaryGrid.InitialSelection = RelativeSelection.None;
            superGridControl1.PrimaryGrid.FocusCuesEnabled = false;
            superGridControl1.PrimaryGrid.ActiveRowIndicatorStyle = ActiveRowIndicatorStyle.None;
            superGridControl1.PrimaryGrid.AllowEdit = false;
            //绑定付款单
            string q = AppDomain.CurrentDomain.GetData("q").ToString();
            if (q != "")
            {
                try
                {
                    switch (q)
                    {
                        case "已付款":
                            bankj();
                            IsOnlyread();
                            break;
                        case "未付款":
                            bankj();
                            ClearReadOnly();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误代码:3208-采购付款单初始化异常，异常信息：" + ex.Message);
                }
            }

        }
        #region 点击图片显示DataGirdView数据
        /// <summary>
        /// 点击图片显示DataGirdView数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ClickPicBox(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pbName = pb.Name;
            try
            {
                switch (pb.Name)
                {
                    case "pictureBox1":
                        resizablePanel1.Location = new Point(180, 110);
                        dataGridViewFujia.DataSource = sm.SelSupplierTable2();
                        dataGridViewFujia.Columns[2].Visible = false;
                        break;
                    case "pictureBox4":
                        resizablePanel1.Location = new Point(180, 140);
                        dataGridViewFujia.DataSource = bam.SelBankAccount2();
                        break;
                    case "pictureBox5":
                        resizablePanel1.Location = new Point(190, 260);
                        DataTable dt = ch.DataTableReCoding(em.SelEmp2("").Tables[0]);
                        dataGridViewFujia.DataSource = dt;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3209-采购付款单选择框异常，异常信息：" + ex.Message);
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
        #endregion
        #region  控制面板是否显示
        //控制面板是否显示
        private bool _btnAdd = false;

        protected bool BtnAdd
        {
            get { return _btnAdd; }
            set { _btnAdd = value; }
        }
        //付款金额少的原因
        public string Yuanyu
        {
            get { return _yuanyu; }

            set { _yuanyu = value; }
        }
        //未付金额
        public double Weifujine
        {
            get
            {
                return weifujine;
            }

            set
            {
                weifujine = value;
            }
        }


        #endregion
        #region 双击DataGirdView获取值，绑定控件
        /// <summary>
        /// 双击DataGirdView获取值，绑定控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewFujia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (pbName)
            {
                case "pictureBox1":
                    labtextboxTop1.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    labtextboxTop2.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[2].Value.ToString();
                    break;
                case "pictureBox4":
                    labtextboxTop6.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "pictureBox5":
                    labtextboxBotton1.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }
            resizablePanel1.Visible = false;
        }
        #endregion
        #region 按钮操作
        /// <summary>
        /// 确认金额的打勾按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double shifujine = Convert.ToDouble(this.labtextboxTop8.Text.Trim());//实付金额
                double yinfujine = Convert.ToDouble(this.labtextboxTop2.Text.Trim());//应付金额
                double fukuanjine = Convert.ToDouble(this.labtextboxTop7.Text.Trim());//付款金额
                if (fukuanjine > yinfujine)//付款金额大于应付金额
                {
                    MessageBox.Show("付款金额大于应付金额！");
                    this.labtextboxTop7.Text = this.labtextboxTop2.Text.Trim();
                }
                else if (shifujine > yinfujine)//实付金额大于应付金额
                {
                    MessageBox.Show("金额输入比实际金额大！");
                    this.labtextboxTop8.Text = this.labtextboxTop2.Text.Trim();
                    this.labtextboxTop7.Text = this.labtextboxTop2.Text.Trim();
                }
                else if (shifujine > fukuanjine)
                {
                    MessageBox.Show("金额输入比实际金额大！");
                    this.labtextboxTop8.Text = this.labtextboxTop2.Text.Trim();
                    this.labtextboxTop7.Text = this.labtextboxTop2.Text.Trim();
                }
                else if (shifujine < fukuanjine)//实际付款金额小于应付金额
                {
                    Buys.PayMessBox mess = new PayMessBox();
                    mess.Show(this);
                    this.button1.Text = "×";
                    return;
                }
                else if (shifujine == fukuanjine || shifujine == yinfujine)
                {
                    this.button1.Text = "×";
                    this.button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3210-采购付款单输入异常，异常信息：" + ex.Message);
            }
        }

        /// <summary>
        /// 审核付款按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExamine_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.labtextboxTop8.Text != "")
                {
                    if (IsNotNull())
                    {
                        Model.BuyPayment buy = new Model.BuyPayment();
                        buy.Buy_Code = XYEEncoding.strCodeHex(this.textBoxOddNumbers.Text.Trim());//单号
                        buy.Buy_Date = this.dateTimePicker1.Value;//日期
                        buy.Buy_SuName = XYEEncoding.strCodeHex(this.labtextboxTop1.Text.Trim());//供应商
                        buy.Buy_AmountPay = XYEEncoding.strCodeHex(this.labtextboxTop2.Text.Trim());//应付金额
                        buy.Buy_AccountName = XYEEncoding.strCodeHex(this.labtextboxTop6.Text.Trim());//付款账户
                        buy.Buy_AccountPaid = XYEEncoding.strCodeHex(this.labtextboxTop7.Text.Trim());//已付金额
                        buy.Buy_Actmoney = XYEEncoding.strCodeHex(this.labtextboxTop8.Text.Trim());//实付金额
                        buy.Buy_SalesMan = XYEEncoding.strCodeHex(this.labtextboxBotton1.Text.Trim());//业务员
                        if (_yuanyu == null)
                        {
                            buy.Buy_Remark = _yuanyu;
                        }
                        else
                        {
                            buy.Buy_Remark = XYEEncoding.strCodeHex(_yuanyu);//原因
                        }
                        buy.Buy_AuditMan = XYEEncoding.strCodeHex(this.labtextboxBotton4.Text.Trim());//审核人

                        if (weifujine == 0)
                        {
                            bool result = bm.PaymentUpdate(buy);
                            if (result)
                            {
                                bool r = buymanager.PaymentUpdate(buy.Buy_Code,3);
                                if (r)
                                {
                                    MessageBox.Show("【审核并付款】成功！");
                                    this.labSH.Visible = true;
                                    this.labFK.Visible = true;
                                    pay.Band();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("【审核并付款】失败！");
                                    return;
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            bool res = bm.ReveiweUpdate(XYEEncoding.strCodeHex(this.textBoxOddNumbers.Text.Trim()));
                            if (res==true)
                            {
                                bool r = buymanager.PaymentUpdate(buy.Buy_Code, 5);
                                if (r)
                                {
                                    MessageBox.Show("【审核并付款】成功！");
                                    this.labSH.Visible = true;
                                    this.labFK.Visible = true;
                                    pay.Band();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("【审核并付款】失败！");
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("【付款金额】不能为空！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3211-采购付款单保存异常，异常信息：" + ex.Message);
            }


        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 审核按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsNotNull())
            {
                string code = XYEEncoding.strCodeHex(this.textBoxOddNumbers.Text.Trim());
                bool result = bm.ReveiweUpdate(code);
                if (result)
                {
                    MessageBox.Show("【审核】成功！");
                    this.labSH.Visible = true;
                    pay.Band();
                    return;
                }
                else
                {
                    MessageBox.Show("【审核】失败！");
                    return;
                }
            }
        }
        #endregion
        #region 优化窗体处理
        /// <summary>
        /// 设置窗体控件只读
        /// </summary>
        public void IsOnlyread()
        {

            this.labtextboxTop1.ReadOnly = true;//供应商
            this.labtextboxTop2.ReadOnly = true;//应付金额
            this.labtextboxTop6.ReadOnly = true;//付款账号
            this.labtextboxTop7.ReadOnly = true;//付款金额
            this.labtextboxTop8.ReadOnly = true;//实付金额
            this.labtextboxBotton1.ReadOnly = true;//业务员
            this.labtextboxBotton3.ReadOnly = true;//制单人
            this.labtextboxBotton4.ReadOnly = true;//审核人
            this.dateTimePicker1.Enabled = false;//日期
            this.button1.Enabled = false;//打钩按钮
            this.pictureBox1.Enabled = false;
            this.pictureBox4.Enabled = false;
            this.pictureBox5.Enabled = false;
        }

        public void ClearReadOnly()
        {
            this.labtextboxTop1.ReadOnly = false;//供应商
            this.labtextboxTop2.ReadOnly = false;//应付金额
            this.labtextboxTop6.ReadOnly = false;//付款账号
            this.labtextboxTop7.ReadOnly = false;//付款金额
            this.labtextboxTop8.ReadOnly = false;//实付金额
            this.labtextboxBotton1.ReadOnly = false;//业务员
            this.labtextboxBotton3.ReadOnly = false;//制单人
            this.labtextboxBotton4.ReadOnly = false;//审核人
            this.dateTimePicker1.Enabled = true;//日期
            this.button1.Enabled = true;//打钩按钮
            this.pictureBox1.Enabled = true;
            this.pictureBox4.Enabled = true;
            this.pictureBox5.Enabled = true;
        }
        /// <summary>
        /// 绑定控件
        /// </summary>
        public void bankj()
        {
            string ID = AppDomain.CurrentDomain.GetData("s").ToString();
            BuyPaymentManager buy = new BuyPaymentManager();
            Model.BuyPayment bu = buy.GetModel(XYEEncoding.strCodeHex(ID));
            this.textBoxOddNumbers.Text = XYEEncoding.strHexDecode(bu.Buy_Code);
            this.dateTimePicker1.Value = Convert.ToDateTime(bu.Buy_Date);
            this.labtextboxTop1.Text = XYEEncoding.strHexDecode(bu.Buy_SuName);
            this.labtextboxTop2.Text = XYEEncoding.strHexDecode(bu.Buy_AmountPay);
            this.labtextboxTop6.Text = XYEEncoding.strHexDecode(bu.Buy_AccountName);
            this.labtextboxTop7.Text = XYEEncoding.strHexDecode(bu.Buy_AccountPaid);
            this.labtextboxTop8.Text = XYEEncoding.strHexDecode(bu.Buy_Actmoney);
            this.labtextboxBotton1.Text = XYEEncoding.strHexDecode(bu.Buy_SalesMan);
            this.labtextboxBotton4.Text = XYEEncoding.strHexDecode(bu.Buy_AuditMan);
        }

        #endregion
        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        private bool IsNotNull()
        {
            if (this.labtextboxTop1.Text == "")
            {
                MessageBox.Show("【供应商】不能为空！");
                return false;
            }
            if (this.labtextboxTop6.Text == "")
            {
                MessageBox.Show("【付款账户】不能为空！");
                return false;
            }
            if (this.labtextboxBotton4.Text == "")
            {
                MessageBox.Show("【审核人】不能为空！");
                return false;
            }
            return true;
        }
        #endregion
        #region 验证金额
        /// <summary>
        /// 验证付款金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labtextboxTop7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (labtextboxTop7.MaxLength < 12)
            {
                e.Handled = true;
            }
        }
        private string skipComma(string str)
        {
            string[] ss = null;
            string strnew = "";
            if (str == "")
            {
                strnew = "0";
            }
            else
            {
                ss = str.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    strnew += ss[i];
                }
            }
            return strnew;
        }

        private void labtextboxTop7_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(labtextboxTop7.Text))
                return;

            // 按千分位逗号格式显示！
            double d = Convert.ToDouble(skipComma(labtextboxTop7.Text));
            labtextboxTop7.Text = string.Format("{0:#,#}", d);

            // 确保输入光标在最右侧
            labtextboxTop7.Select(labtextboxTop7.Text.Length, 0);
        }

        /// <summary>
        /// 验证应付金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labtextboxTop2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (labtextboxTop2.MaxLength < 12)
            {
                e.Handled = true;
            }
        }

        private void labtextboxTop2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labtextboxTop2.Text))
                return;

            // 按千分位逗号格式显示！
            double d = Convert.ToDouble(skipComma(labtextboxTop2.Text));
            labtextboxTop2.Text = string.Format("{0:#,#}", d);

            // 确保输入光标在最右侧
            labtextboxTop2.Select(labtextboxTop2.Text.Length, 0);
        }

        /// <summary>
        /// 验证实收金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labtextboxTop8_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labtextboxTop8.Text))
                return;

            // 按千分位逗号格式显示！
            double d = Convert.ToDouble(skipComma(labtextboxTop8.Text));
            labtextboxTop8.Text = string.Format("{0:#,#}", d);

            // 确保输入光标在最右侧
            labtextboxTop8.Select(labtextboxTop8.Text.Length, 0);
        }

        private void labtextboxTop8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (labtextboxTop8.MaxLength < 12)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

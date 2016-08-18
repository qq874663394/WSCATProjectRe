using BLL;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;
using HelperUtility;
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

namespace WSCATProject.Sell
{
    public partial class InsSellGathering : Form
    {
        ClientManager cm = new ClientManager();
        BankAccountManager bam = new BankAccountManager();
        EmpolyeeManager em = new EmpolyeeManager();
        SellDetailManager sdm = new SellDetailManager();
        CodingHelper ch = new CodingHelper();
        Conllection conll = new Conllection();
        SellManager sm = new SellManager();
        ConllectionManager conllm = new ConllectionManager();
        public string pbName;//根据图片Name对应相应的datagridview

        public InsSellGathering()
        {
            InitializeComponent();
        }
        #region 接受从另一窗体传过来的值
        //销售单号
        private string _sellcode;
        public string Sell_Code
        {
            get { return _sellcode; }
            set { _sellcode = value; }
        }
        //客户
        private string _Sell_ClientName;
        public string Sell_ClientName
        {
            get { return _Sell_ClientName; }
            set { _Sell_ClientName = value; }
        }
        //结算账户
        private string _AccountName;
        public string A_AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }
        
        //应收金额
        private string _OddMoney;
        public string Sell_OddMoney
        {
            get { return _OddMoney; }
            set { _OddMoney = value; }
        }
        //收款金额
        private string _InMoney;
        public string Sell_InMoney
        {
            get { return _InMoney; }
            set { _InMoney = value; }
        }
        //剩余尾款
        private string _LastMoney;
        public string Sell_LastMoney
        {
            get { return _LastMoney; }
            set { _LastMoney = value; }
        }
        //收款方式
        private string _fukuanfangshi;
        public string Sell_fukuanfangshi
        {
            get { return _fukuanfangshi; }
            set { _fukuanfangshi = value; }
        }
        //业务员
        private string _Salesman;
        public string Sell_Salesman
        {
            get { return _Salesman; }
            set { _Salesman = value; }
        }
        //制单人
        private string Operation;
        public string Sell_Operation
        {
            get { return Operation; }
            set { Operation = value; }
        }
        //摘要
        private string _Remark;
        public string Sell_Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        #endregion

        private void InsSellGathering_Load(object sender, EventArgs e)
        {
            #region 初始化列
            GridColumn gc = null;

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_Code";
            gc.Name = "Code";
            gc.HeaderText = "销售单号";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_StockName";
            gc.Name = "StockName";
            gc.HeaderText = "仓库名称";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_MaID";
            gc.Name = "MaID";
            gc.HeaderText = "编码";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_MaName";
            gc.Name = "MaName";
            gc.HeaderText = "商品名称";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_Model";
            gc.Name = "Model";
            gc.HeaderText = "规格型号";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_Unit";
            gc.Name = "Unit";
            gc.HeaderText = "单位";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_DiscountBPrice";
            gc.Name = "DiscountBPrice";
            gc.HeaderText = "单价";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_CurNumber";
            gc.Name = "CurNumber";
            gc.HeaderText = "需求数量";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_ReNumber";
            gc.Name = "ReNumber";
            gc.HeaderText = "实发数量";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_LostNumber";
            gc.Name = "LostNumber";
            gc.HeaderText = "缺少数量";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_Discount";
            gc.Name = "Discount";
            gc.HeaderText = "折扣率";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_DiscountBPrice";
            gc.Name = "DiscountBPrice";
            gc.HeaderText = "折后金额";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_Money";
            gc.Name = "Money";
            gc.HeaderText = "总金额";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_Remark";
            gc.Name = "Remark";
            gc.HeaderText = "备注";
            superGridControl1.PrimaryGrid.Columns.Add(gc);

            superGridControl1.PrimaryGrid.DataSource = sdm.GetList(string.Format("Sell_Code='{0}'", XYEEncoding.strCodeHex(Sell_Code)));

            #endregion

            //ltxt_salecode.Text = Sell_Code; ;
            //ltxt_kehu.Text = C_ClientName;
            //ltxt_AccountName.Text = C_AccountName;
            //ltxt_yingshou.Text = C_AmountPay;

            ltxt_shishou.Text = "0";
            ltxt_weishou.Text = "0";
            ltxt_shoukuan.Text = "0";
            ltxt_yingshou.Text = "0";

           
           // ltxt_salecode.Text = _sellcode;
            Model.Sell sell = sm.SelSellGatheringBySellCode(ltxt_salecode.Text.Trim());
            ltxt_salecode.Text = _sellcode;
            ltxt_kehu.Text = _Sell_ClientName;
            ltxt_yingshou.Text = Convert.ToDecimal( _OddMoney).ToString("0.00");
            ltxt_shoukuan.Text = Convert.ToDecimal(_InMoney).ToString("0.00");
            ltxt_weishou.Text = Convert.ToDecimal(_LastMoney).ToString("0.00");
            ltxt_method.Text = _fukuanfangshi;
            ltxt_saleman.Text = _Salesman;
            ltxt_remark.Text = _Remark;
            //if (sell != null)
            //{
            //    ltxt_salecode.Text = _sellcode;
            //    ltxt_kehu.Text = sell.Sell_ClientName;
            //    ltxt_AccountName.Text = sell.Sell_AccountCode;
            //    ltxt_yingshou.ReadOnly = true;
            //    ltxt_yingshou.Text = Convert.ToDecimal(sell.Sell_OddMoney).ToString("0.00");
            //    ltxt_shoukuan.Text = Convert.ToDecimal(sell.Sell_InMoney).ToString("0.00");
            //    ltxt_weishou.Text = Convert.ToDecimal(sell.Sell_LastMoney).ToString("0.00");
            //    ltxt_method.Text = sell.Sell_fukuanfangshi;
            //    ltxt_saleman.Text = sell.Sell_Salesman;
            //    ltxt_operation.Text = sell.Sell_Operation;
            //    ltxt_remark.Text = sell.Sell_Remark;
            //    ltxt_weishou.Text = sell.Sell_OddMoney;
            //}

            if (string.IsNullOrWhiteSpace(textBoxOddNumbers.Text))
            {
                textBoxOddNumbers.Text = BuildCode.ModuleCode("AC");
                conll.C_No = textBoxOddNumbers.Text;//资金收款编号
            }
            //ltxt_salecode.Text
            //textBoxX1.Text = "0";
            //制单人
            LoginInfomation l = LoginInfomation.getInstance();
            l.UserName = "sss";
            ltxt_operation.Text = l.UserName;
            dataGridViewFujia.ReadOnly = true;
            dataGridViewFujia.AllowUserToResizeColumns = false;//是否可以调整列的大小
            dataGridViewFujia.AllowUserToResizeRows = false;//是否可以调整行的大小            
        }

        #region 点击图片把客户、账户、业务员分别绑定到dataGridView
        private void ClickPicBox(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn gc;
            PictureBox pb = sender as PictureBox;
            pbName = pb.Name;
            switch (pb.Name)
            {
                case "pictureBox1":
                    dataGridViewFujia.Columns.Clear();
                    dataGridViewFujia.AutoGenerateColumns = false;
                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "Cli_Code";
                    gc.Name = "ColumnsValue";
                    gc.HeaderText = "客户编码";
                    dataGridViewFujia.Columns.Add(gc);

                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "Cli_Name";
                    gc.Name = "ColumnsName";
                    gc.HeaderText = "客户名称";
                    dataGridViewFujia.Columns.Add(gc);
                    dataGridViewFujia.DataSource = cm.GetListInSimple().Tables[0];
                    dataGridViewFujia.Columns[0].Visible = false;
                    resizablePanel1.Location = new Point(190, 115);
                    break;
                case "pictureBox2":
                    dataGridViewFujia.Columns.Clear();
                    dataGridViewFujia.AutoGenerateColumns = false;
                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "编码";
                    gc.Name = "ColumnsValue";
                    gc.HeaderText = "Ba_Code";
                    gc.Visible = false;
                    dataGridViewFujia.Columns.Add(gc);

                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "开户行";
                    gc.Name = "ColumnsName";
                    gc.HeaderText = "账户名称";
                    dataGridViewFujia.Columns.Add(gc);
                    dataGridViewFujia.DataSource = bam.SelBankAccount(false);
                    dataGridViewFujia.Columns[0].Visible = false;
                    resizablePanel1.Location = new Point(190, 150);
                    break;
                case "pictureBox3":
                    dataGridViewFujia.Columns.Clear();
                    dataGridViewFujia.AutoGenerateColumns = false;
                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "员工工号";
                    gc.Name = "ColumnsValue";
                    gc.HeaderText = "编码";
                    //gc.Visible = false;
                    dataGridViewFujia.Columns.Add(gc);

                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "姓名";
                    gc.Name = "ColumnsName";
                    gc.HeaderText = "名称";
                    dataGridViewFujia.Columns.Add(gc);
                    dataGridViewFujia.DataSource = em.SelEmpolyee(false);
                    dataGridViewFujia.Columns[0].Visible = false;
                    resizablePanel1.Location = new Point(190, 260);
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

        #region  把选中行的值绑定到文本框
        private void dataGridViewFujia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFujia.CurrentRow.Index == -1)
            {
                return;
            }
            switch (pbName)
            {
                case "pictureBox1":
                    ltxt_kehu.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    conll.C_ClientCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();//客户编号
                    conll.C_ClientName = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();//客户名称
                    break;
                case "pictureBox2":
                    ltxt_AccountName.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    conll.C_AccountCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();//收款账户
                    conll.C_AccountName = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();//收款账户
                    break;
                case "pictureBox3":
                    ltxt_saleman.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    conll.C_SalesCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();//业务员
                    conll.C_SalesMan = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();//业务员
                    break;
            }
            resizablePanel1.Visible = false;
        }
        #endregion

        #region 验证金额

        #endregion

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        private bool IsNotNull()
        {
            if (this.ltxt_kehu.Text == "")
            {
                MessageBox.Show("【客户】不能为空！");
                return false;
            }
            if (this.ltxt_AccountName.Text == "")
            {
                MessageBox.Show("【收款账户】不能为空！");
                return false;
            }
            if (this.ltxt_saleman.Text == "")
            {
                MessageBox.Show("【业务员】不能为空！");
                return false;
            }
            return true;
        }
        #endregion

        #region 打钩按钮操作
        /// <summary>
        /// 确认金额的打钩按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string yingshou = ltxt_yingshou.Text.Trim();
                string shishou = ltxt_shishou.Text.Trim();
                string weishou = ltxt_weishou.Text.Trim();
                //yingshou.Text = yingshou.ToString();
                ltxt_shishou.Text = Convert.ToDecimal(yingshou).ToString("0.00");
                if (this.button1.Text == "√")
                {
                    string weishouTemp = Convert.ToString((Convert.ToDecimal(ltxt_yingshou.Text.Trim()) - Convert.ToDecimal(ltxt_shishou.Text.Trim())));
                    if (weishouTemp == "")
                    {
                        ltxt_weishou.WatermarkText = "0";
                    }
                    else
                    {
                        ltxt_weishou.Text = weishouTemp;
                    }
                    ltxt_shoukuan.Text = yingshou;
                    this.button1.Text = "×";
                    return;
                }
                if (this.button1.Text == "×")
                {
                    ltxt_shoukuan.Text = "0";
                    ltxt_shishou.Text = "0";
                    ltxt_weishou.Text = ltxt_yingshou.Text;
                    this.button1.Text = "√";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void ltxt_kehu_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Cli_Name ='" + ltxt_kehu.Text.Trim().ToString() + "'";
            dt = dv.ToTable();
        }

        //保存
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (conllm.Exists(textBoxOddNumbers.Text.Trim()))
            {
                MessageBox.Show("记录已存在！");
                return;
            }
            if (conll.C_ClientName == null)
            {
                conll.C_ClientName = ltxt_kehu.Text.Trim();
            }
            if (conll.C_AccountName == null)
            {
                conll.C_AccountName = ltxt_AccountName.Text.Trim();
            }
            if (conll.C_SalesMan == null)
            {
                conll.C_SalesMan = ltxt_saleman.Text.Trim();
            }
            conll.C_Operation = ltxt_operation.Text.Trim();
            conll.C_Remark = ltxt_remark.Text.Trim();
            conll.C_AmountPay = ltxt_yingshou.Text.Trim();
            conll.C_AccountPaid = ltxt_shishou.Text.Trim();
            conll.C_MoneyOwed = ltxt_weishou.Text.Trim();
            conll.C_SellCode = ltxt_salecode.Text.Trim();
            conll.C_AuditMan = "";
            conll.C_Date = dateTimePicker1.Value;
            conll.C_AuditStatus = 0;
            conll.C_Clear = 1;
            conll.C_Status = 0;
            int result = conllm.InsConllection(conll);
            if (result > 0)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        #region 退出
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (conllm.Exists(textBoxOddNumbers.Text.Trim()))
            {
                MessageBox.Show("记录已存在！");
                return;
            }
            if (conll.C_ClientName == null)
            {
                conll.C_ClientName = ltxt_kehu.Text.Trim();
            }
            if (conll.C_AccountName == null)
            {
                conll.C_AccountName = ltxt_AccountName.Text.Trim();
            }
            if (conll.C_SalesMan == null)
            {
                conll.C_SalesMan = ltxt_saleman.Text.Trim();
            }
            conll.C_Operation = ltxt_operation.Text.Trim();
            conll.C_Remark = ltxt_remark.Text.Trim();
            conll.C_AmountPay = ltxt_yingshou.Text.Trim();
            conll.C_AccountPaid = ltxt_shishou.Text.Trim();
            conll.C_MoneyOwed = ltxt_weishou.Text.Trim();
            conll.C_SellCode = ltxt_salecode.Text.Trim();
            conll.C_AuditMan = "";
            conll.C_Date = dateTimePicker1.Value;
            conll.C_AuditStatus = 1;
            conll.C_Clear = 1;
            conll.C_Status = 0;
            int result = conllm.InsConllection(conll);
            if (result > 0)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void ltxt_shoukuan_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                    if (((TextBox)sender).Text.Trim().Substring(((TextBox)sender).Text.Trim().IndexOf('.') + 1).Length >= 2)
                        e.Handled = true;
                }
            }
            if (e.KeyChar=='\b')
            {
                if (string.IsNullOrWhiteSpace(ltxt_shoukuan.Text) == true)
                {
                    ltxt_shishou.Text = "0.00";
                }
            }
        }

        private void ltxt_shoukuan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text) == true || string.IsNullOrWhiteSpace(ltxt_yingshou.Text))
            {
                return;
            }

            if (Convert.ToDecimal(((TextBox)sender).Text) > Convert.ToDecimal(ltxt_yingshou.Text))
            {
                MessageBox.Show("【收款金额】不能大于应付金额");
                ((TextBox)sender).Text = Convert.ToDecimal(ltxt_yingshou.Text).ToString("0.00");
            }
            ltxt_shishou.Text = Convert.ToDecimal(ltxt_shoukuan.Text).ToString("0.00");
            ltxt_weishou.Text = (Convert.ToDecimal(ltxt_yingshou.Text) - Convert.ToDecimal(ltxt_shoukuan.Text)).ToString("0.00");
        }

        private void ltxt_shoukuan_Leave(object sender, EventArgs e)
        {
            ltxt_shoukuan.Text = Convert.ToDecimal(ltxt_shoukuan.Text).ToString("0.00");
        }
    }
}
﻿using BLL;
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
        ConllectionWait cw = new ConllectionWait();
        public string pbName;//根据图片Name对应相应的datagridview
        //销售单号
        private string _sellcode;
        public string Sell_Code
        {
            get { return _sellcode; }
            set { _sellcode = value; }
        }

        public InsSellGathering()
        {
            InitializeComponent();
        }

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

            //superGridControl1.PrimaryGrid.Columns[0].Visible = false;
            //superGridControl1.PrimaryGrid.DataSource = sdm.GetList(" Sell_Code='" + _sellcode + "'");
            superGridControl1.PrimaryGrid.DataSource = sdm.GetList("");

            #endregion

            if (string.IsNullOrWhiteSpace(textBoxOddNumbers.Text))
            {
                textBoxOddNumbers.Text = BuildCode.ModuleCode("AC");
            }
            //textBoxOddNumbers.Text = BuildCode.ModuleCode("AC");//收款单单号
            ltxt_shoukuan.Text = "0";
            ltxt_shishou.Text = "0";
            ltxt_weishou.Text = "0";
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
                    //ltxt_yingshou.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_ClientName = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_ClientCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();
                    break;
                case "pictureBox2":
                    ltxt_AccountName.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_AccountCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();
                    break;
                case "pictureBox3":
                    ltxt_saleman.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_SalesMan = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    break;
            }
            resizablePanel1.Visible = false;
        }
        #endregion

        //保存
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ConllectionWaitManager cwm = new ConllectionWaitManager();
            cw.CW_Code = textBoxOddNumbers.Text;
            cw.CW_Operation = ltxt_operation.Text.Trim();
            cw.CW_Remark = ltxt_remark.Text.Trim();
            int result = cwm.InsConllectionWait(cw);
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

        #region 验证金额
        /// <summary>
        /// 验证应收金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltxt_yingshou_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (ltxt_yingshou.MaxLength < 11)
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

        private void ltxt_yingshou_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ltxt_yingshou.Text))
                return;

            // 按千分位逗号格式显示！
            decimal d = Convert.ToDecimal(skipComma(ltxt_yingshou.Text));
            ltxt_yingshou.Text = string.Format("{0:#,#}", d);

            // 确保输入光标在最右侧
            ltxt_yingshou.Select(ltxt_yingshou.Text.Length, 0);
        }

        /// <summary>
        /// 验证收款金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltxt_shoukuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (ltxt_shoukuan.MaxLength < 11)
            {
                e.Handled = true;
            }
          
        }

        private void ltxt_shoukuan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ltxt_shoukuan.Text))
                return;

            // 按千分位逗号格式显示！
            decimal d = Convert.ToDecimal(skipComma(ltxt_shoukuan.Text));
            ltxt_shoukuan.Text = string.Format("{0:N0}", d);

            // 确保输入光标在最右侧
            ltxt_shoukuan.Select(ltxt_shoukuan.Text.Length, 0);
        }

        /// <summary>
        /// 验证实收金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltxt_shishou_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (ltxt_shishou.MaxLength < 11)
            {
                e.Handled = true;
            }
        }

        private void ltxt_shishou_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ltxt_shishou.Text))
                return;

            // 按千分位逗号格式显示！
            decimal d = Convert.ToDecimal(skipComma(ltxt_shishou.Text));
            ltxt_shishou.Text = string.Format("{0:N0}", d);

            // 确保输入光标在最右侧
            ltxt_shishou.Select(ltxt_shishou.Text.Length, 0);
        }

        /// <summary>
        /// 验证未收金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltxt_weishou_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字和Del
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (ltxt_weishou.MaxLength < 11)
            {
                e.Handled = true;
            }
        }

        private void ltxt_weishou_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ltxt_weishou.Text))
                return;

            // 按千分位逗号格式显示！
            decimal d = Convert.ToDecimal(skipComma(ltxt_weishou.Text));
            ltxt_weishou.Text = string.Format("{0:N0}", d);

            // 确保输入光标在最右侧
            ltxt_weishou.Select(ltxt_weishou.Text.Length, 0);
        }


        private void ltxt_shoukuan_Validated(object sender, EventArgs e)
        {
            if (ltxt_shoukuan.Text == "" || ltxt_shishou.Text == "" || ltxt_weishou.Text == "")
            {
                return;
            }
            decimal shoukuan = Convert.ToDecimal(ltxt_shoukuan.Text.Trim());
            decimal ying = Convert.ToDecimal(ltxt_yingshou.Text);
            if (shoukuan > ying)
            {
                MessageBox.Show("收款金额不能大于应收金额！");
                ltxt_shoukuan.Clear();
                return;
            }
            ltxt_shishou.Text = shoukuan.ToString();
            ltxt_weishou.Text = (Convert.ToDecimal(ltxt_yingshou.Text.Trim()) - Convert.ToDecimal(ltxt_shishou.Text.Trim())).ToString();//未收金额
        }
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
                string shoukuan = ltxt_shoukuan.Text.Trim();
                string shishou = ltxt_shishou.Text.Trim();
                string weishou = ltxt_weishou.Text.Trim();
                ltxt_shoukuan.Text = yingshou.ToString();
                ltxt_shishou.Text = yingshou.ToString();
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


    }
}

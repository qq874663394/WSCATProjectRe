using BLL;
using DevComponents.DotNetBar.Controls;
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
    public partial class SellHistoricaldiscount : Form
    {
        public SellHistoricaldiscount()
        {
            InitializeComponent();
        }

        private void SellHistoricaldiscount_Load(object sender, EventArgs e)
        {
            InSellForm isf = (InSellForm)this.Owner;
            lblkehu.Text = isf.Sell_Clientname;
            lblname.Text = isf.Sell_MaName;
            lblunity.Text = isf.Sell_Unit;
            lblcount.Text = isf.Sell_CurNumber;
            textBoxX1.Text = isf.Sell_Price;
            textBoxX3.Text = isf.Sell_Discount;
            textBoxX4.Text = isf.Sell_zongmoney;
            textBoxX5.Text = isf.Sell_PriceAfter;

            textBoxX2.ReadOnly = true;//折扣金额
            textBoxX4.ReadOnly = true;//总金额
            textBoxX5.ReadOnly = true;//折后单价   
            //设置为整行被选中
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //绑定数据
            dataGridView1.DataSource = new SellDetailManager().SelDiscountByAccount("本次", "说服力是地方");
        }

        #region  折扣率只允许输入数字，小数和Del
        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
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
                    //小数位最多只能输入2位
                    if (((TextBox)sender).Text.Trim().Substring(((TextBox)sender).Text.Trim().IndexOf('.') + 1).Length >= 2)
                        e.Handled = true;
                }
            }
        }
        #endregion

        private void textBoxX3_Validated(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(textBoxX1.Text.Trim());//原始单价
                double discount = Convert.ToDouble(textBoxX3.Text.Trim());//折扣率
                double shuliang = Convert.ToDouble(lblcount.Text.Trim());//数量
                if (discount > 100 || discount <= 0)
                {
                    MessageBox.Show("折扣率不能大于100并且不能小于0！");
                    textBoxX3.Text = "100.00";
                    return;
                }
                double jine = price * shuliang;
                double zongmoney = jine * (discount / 100);//总金额
                textBoxX4.Text = zongmoney.ToString("0.00");
                double zhehou = price * (discount / 100);//折后单价
                textBoxX5.Text = zhehou.ToString("0.00");
                double zhekou = price - zhehou;//折扣金额
                textBoxX2.Text = zhekou.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //选中行绑定到文本框
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string priceType = "";
            string price = "";
            string discount = "100.00";
            priceType = dataGridView1.CurrentRow.Cells[0].Value.ToString();//价格类型
            price = dataGridView1.CurrentRow.Cells[1].Value.ToString();//价格
            discount = dataGridView1.CurrentRow.Cells[2].Value.ToString();//折扣率
            textBoxX1.Text = price;
            textBoxX3.Text = discount;
            textBoxX5.Text = (Convert.ToDecimal(price) * Convert.ToDecimal(discount) / 100).ToString("0.00");//折扣单价
            textBoxX2.Text = (Convert.ToDecimal(price) - (Convert.ToDecimal(price) * Convert.ToDecimal(discount) / 100)).ToString("0.00");//折扣金额
            textBoxX4.Text = ((Convert.ToDecimal(price) * Convert.ToDecimal(discount) / 100) * (Convert.ToDecimal(lblcount.Text))).ToString("0.00");//总金额
        }

        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            //控件失去焦点后将它的值的格式精确到两位小数
            TextBoxX name = (sender as TextBoxX);
            
            if (name.Text=="")
            {
                name.Text = "0.00";
            }
            name.Text = Convert.ToDecimal(name.Text).ToString("0.00");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            InSellForm isf = (InSellForm)this.Owner;
            isf.Sell_Price = textBoxX1.Text;
            isf.Sell_Discount = textBoxX3.Text;
            isf.Sell_zongmoney = textBoxX4.Text;
            isf.Sell_PriceAfter = textBoxX5.Text;
            Close();
            Dispose();
        }
    }
}

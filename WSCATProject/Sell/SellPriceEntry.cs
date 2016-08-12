using BLL;
using DevComponents.DotNetBar.Controls;
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
    public partial class SellPriceEntry : Form
    {
        public SellPriceEntry()
        {
            InitializeComponent();
            dataGridView2.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void SellPriceEntry_Load(object sender, EventArgs e)
        {
            DataTable dt = new SellDetailManager().SelPriceByMaName("说服力是地方");
            Material material = new MaterialManager().SelPriceByMaName("说服力是地方");
            DataRow row;
            row = dt.NewRow();
            row[0] = "建议售价";
            row[1] = material.Ma_Price;
            row[2] = DBNull.Value;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "建议售价";
            row[1] = material.Ma_PriceA;
            row[2] = DBNull.Value;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "建议售价";
            row[1] = material.Ma_PriceB;
            row[2] = DBNull.Value;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "建议售价";
            row[1] = material.Ma_PriceC;
            row[2] = DBNull.Value;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "建议售价";
            row[1] = material.Ma_PriceD;
            row[2] = DBNull.Value;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[0] = "建议售价";
            row[1] = material.Ma_PriceE;
            row[2] = DBNull.Value;
            dt.Rows.Add(row);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = new SellDetailManager().SelAccountPriceByAccount("本次", "说服力是地方");
            textBoxX2.ReadOnly = true;//折扣金额
            textBoxX4.ReadOnly = true;//总金额
            textBoxX5.ReadOnly = true;//折后单价   
            //设置为整行被选中
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #region 原始单价和折扣率只允许输入数字，小数和Del
        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
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
                decimal price = Convert.ToDecimal(textBoxX1.Text.Trim());//原始单价
                decimal discount = Convert.ToDecimal(textBoxX3.Text.Trim());//折扣率
                if (discount > 100 || discount <= 0)
                {
                    MessageBox.Show("折扣率不能大于100并且不能小于0！");
                    textBoxX3.Text = "100.00";
                    return;
                }
                decimal zongmoney = price * (discount / 100)* Convert.ToDecimal(lblcount.Text);//总金额
                textBoxX4.Text = zongmoney.ToString("0.00");
                decimal zhehou = price * (discount / 100);//折后单价
                textBoxX5.Text = zhehou.ToString("0.00");
                decimal zhekou = price - zhehou;//折扣金额
                textBoxX2.Text = zhekou.ToString("0.00");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string priceType = "";
            string price = "";
            string discount = "100.00";
            DataGridView controlName = (sender as DataGridView);
            priceType = controlName.CurrentRow.Cells[0].Value.ToString();
            price = controlName.CurrentRow.Cells[1].Value.ToString();
            if (priceType != "建议售价")
            {
                discount = controlName.CurrentRow.Cells[2].Value.ToString();
            }
            textBoxX1.Text = price;
            textBoxX3.Text = discount;
            textBoxX5.Text = (Convert.ToDecimal(price) * Convert.ToDecimal(discount) / 100).ToString("0.00");
            textBoxX2.Text = (Convert.ToDecimal(price) - (Convert.ToDecimal(price) * Convert.ToDecimal(discount) / 100)).ToString("0.00");
            textBoxX4.Text = ((Convert.ToDecimal(price) * Convert.ToDecimal(discount) / 100) * Convert.ToDecimal(lblcount.Text)).ToString("0.00");
            //dataGridViewTextBoxColumn2  lblcount
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            TextBoxX name = (sender as TextBoxX);
            name.Text = Convert.ToDecimal(name.Text).ToString("0.00");
        }
    }
}

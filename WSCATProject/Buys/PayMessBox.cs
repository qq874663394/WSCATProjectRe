using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCATProject.Buys
{
    public partial class PayMessBox : Form
    {


        public PayMessBox( )
        {
            InitializeComponent();
        }

        /// <summary>
        /// 确认输入原因
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text!="")
            {
                BuyPayment bp = (BuyPayment)this.Owner;
                bp.Yuanyu = comboBox1.Text;
                this.Close();
                return;
            }
            else if(this.textBox1.Text.Trim()!="")
            {
                BuyPayment bp = (BuyPayment)this.Owner;
                bp.Yuanyu = textBox1.Text;
                this.Close();
                return;
            }
        }

        /// <summary>
        /// 下拉列表的改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text=="其他")
            {
                this.textBox1.ReadOnly = false;
                BuyPayment bp = (BuyPayment)this.Owner;
                bp.Yuanyu = textBox1.Text;
                return;
            }
            this.textBox1.ReadOnly = true;
        }
        //关闭窗体
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

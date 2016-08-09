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

namespace WSCATProject.Buys
{
    public partial class InLogisticalForm : Form
    {
        public InLogisticalForm()
        {
            InitializeComponent();
        }
        BuyManager bm = new BuyManager();
        private string danhao;
        /// <summary>
        /// 单号
        /// </summary>
        public string Danhao
        {
            get { return danhao; }
            set { danhao = value; }
        }
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                string wuliudanhao = this.textBoxXdanhao.Text.Trim();//单号
                string wuliumingc = this.textBoxXname.Text.Trim();//名称
                string wuliuTel = this.textBoxXTel.Text.Trim();//电话
                DateTime daohrq = this.dateTimeInput1.Value;//预计到货日期
                Buy b = new Buy();
                b.Buy_LogCode = XYEEncoding.strCodeHex(wuliudanhao);
                b.Buy_Logistics = XYEEncoding.strCodeHex(wuliumingc);
                b.Buy_LogPhone = XYEEncoding.strCodeHex(wuliuTel);
                b.Buy_GetDate = daohrq;
                b.Buy_Code = XYEEncoding.strCodeHex(danhao);
                bool result = bm.LogisticalUpdate(b);
                if (result)
                {
                    MessageBox.Show("物流信息添加成功！");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("物流信息添加失败!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3214-新增物流信息时保存异常，异常信息：" + ex.Message);
            }
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

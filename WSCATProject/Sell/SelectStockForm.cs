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
    public partial class SelectStockForm : Form
    {
        public SelectStockForm()
        {
            InitializeComponent();
        }
        //关闭按钮
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        //立即补货按钮
        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}

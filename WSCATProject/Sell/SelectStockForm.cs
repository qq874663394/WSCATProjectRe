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

        private DataTable _dt;//绑定数据

        public DataTable Dt
        {
            get
            {
                return _dt;
            }

            set
            {
                _dt = value;
            }
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
            BuyInForm buy = new WSCATProject.BuyInForm();
            buy.Show();
        }

        private void SelectStockForm_Load(object sender, EventArgs e)
        {
            this.superGridControl1.PrimaryGrid.DataSource = _dt;
        }
    }
}

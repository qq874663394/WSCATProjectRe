using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSCATProject.FinanceForm
{
    public partial class BankOperateForm : TemplateForm
    {
        public BankOperateForm()
        {
            InitializeComponent();
            this.Size = new Size(900, 350);
        }

        protected override void InitTopLab()
        {
            
        }

        protected override void InitDataGridViewHeaderColumn()
        {
            superGridControl1.Visible = false;
            panel7.Visible = false;
        }
    }
}

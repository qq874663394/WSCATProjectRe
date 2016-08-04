using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WSCATProject.SellForm
{
    public partial class PaySellForm : TemplateForm
    {
        public PaySellForm()
        {
            InitializeComponent();
            pictureBox1.Click += new System.EventHandler(ClickPicBox);
            pictureBox2.Click += new System.EventHandler(ClickPicBox);
        }
        
        protected override void InitDataGridViewHeaderColumn()
        {
            this.dataGridViewFujia.Visible = false;
            panel7.BorderStyle = BorderStyle.None;
        }

        protected override void InitTopLabText()
        {
            base.InitTopLabText();
            labTop1.Text = "客    户：";
            labTop2.Text = "应付余额：";
            labTop3.Text = "付款账户：";
            labTop4.Text = "付款金额：";
            labTop5.Text = "实付金额：";

            pictureBox2.Location = new Point(191, 51);
            checkBox1.Location = new Point(472, 50);

            labTop2.Enabled = false;
            labTop6.Visible = false;
            labTop7.Visible = false;
            labTop8.Visible = false;
            labTop9.Visible = false;
            labtextboxTop6.Visible = false;
            labtextboxTop7.Visible = false;
            labtextboxTop8.Visible = false;
            labtextboxTop9.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        //覆盖基类方法,改变下拉窗体出现的位置
        private bool _btnAdd = false;
        protected new void ClickPicBox(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            switch (pb.Name)
            {
                case "pictureBox1":
                    resizablePanel1.Location = new Point(120, 102);
                    break;
                case "pictureBox2":
                    resizablePanel1.Location = new Point(120, 132);
                    break;
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
    }
}

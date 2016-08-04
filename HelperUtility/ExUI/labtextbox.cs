using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelperUtility.ExUI
{
    public partial class labtextbox : UserControl
    {
        public labtextbox()
        {
            InitializeComponent();
        }

        [Description("文本框的文字"), Browsable(true), Category("内容")]
        public string UserInputText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Description("输入下划线"), Browsable(true), Category("内容")]
        public string LabInputText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [Description("字体大小"), Browsable(true), Category("内容")]
        public float TextboxFontSize
        {
            get { return textBox1.Font.Size; }
            set { textBox1.Font = new Font("宋体", value); }
        }

    }
}

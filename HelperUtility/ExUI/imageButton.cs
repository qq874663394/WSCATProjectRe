using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperUtility.ExUI
{
    public partial class imageButton : Button
    {
        public imageButton()
        {
            InitializeComponent();
            BackgroundImage = _DefaultImage;
            MouseEnter += new EventHandler(imageButton_MouseEnter);
            MouseLeave += new EventHandler(imageButton_MouseLeave);
            MouseDown += new MouseEventHandler(imageButton_MouseDown);
            EnabledChanged += new EventHandler(imageButton_EnabledChanged);
            this.Size = new Size(135, 40);
        }

        private Image _clickImage;
        private Image _DefaultImage;
        private Image _EnterImage;
        public buttonStyle _buttonStyle = buttonStyle.none;
        public enum buttonStyle
        {
            none, hover
        };
        /// <summary>
        /// 选中按钮的背景图
        /// </summary>
        public Image clickImage
        {
            get { return _clickImage; }
            set { _clickImage = value; }
        }
        /// <summary>
        /// 默认状态下的背景图
        /// </summary>
        public Image defaultImage
        {
            get { return _DefaultImage; }
            set { _DefaultImage = value; }
        }
        /// <summary>
        /// 鼠标停放按钮上的背景图
        /// </summary>
        public Image enterImage
        {
            get { return _EnterImage; }
            set { _EnterImage = value; }
        }

        void imageButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                BackgroundImage = clickImage;
                _buttonStyle = buttonStyle.hover;
            }
        }

        void imageButton_MouseLeave(object sender, EventArgs e)
        {
            if (Enabled && _buttonStyle == buttonStyle.none)
            {
                BackgroundImage = defaultImage;
            }
        }

        void imageButton_MouseEnter(object sender, EventArgs e)
        {
            if (Enabled && _buttonStyle == buttonStyle.none)
            {
                BackgroundImage = enterImage;
            }
        }

        void imageButton_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled && _buttonStyle == buttonStyle.none)
            {
                BackgroundImage = defaultImage;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}

namespace WSCATProject.Base.Buys
{
    partial class BuyFollowInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.cbo_caozuo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.txt_beizhu = new System.Windows.Forms.TextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_caozuoman = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.txt_buycode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.btn_baocun = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancel = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "基础资料";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.tabControlPanel1.Controls.Add(this.cbo_caozuo);
            this.tabControlPanel1.Controls.Add(this.txt_beizhu);
            this.tabControlPanel1.Controls.Add(this.labelX3);
            this.tabControlPanel1.Controls.Add(this.dateTimeInput1);
            this.tabControlPanel1.Controls.Add(this.labelX1);
            this.tabControlPanel1.Controls.Add(this.txt_caozuoman);
            this.tabControlPanel1.Controls.Add(this.labelX25);
            this.tabControlPanel1.Controls.Add(this.labelX2);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(579, 266);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.PowderBlue;
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.Azure;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 0;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // cbo_caozuo
            // 
            this.cbo_caozuo.DisplayMember = "Text";
            this.cbo_caozuo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_caozuo.FormattingEnabled = true;
            this.cbo_caozuo.ItemHeight = 15;
            this.cbo_caozuo.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cbo_caozuo.Location = new System.Drawing.Point(375, 16);
            this.cbo_caozuo.Name = "cbo_caozuo";
            this.cbo_caozuo.Size = new System.Drawing.Size(121, 21);
            this.cbo_caozuo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_caozuo.TabIndex = 37;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "确认交货期";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "到货通知";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "申请付款";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "确认到货";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "货品入库";
            // 
            // txt_beizhu
            // 
            this.txt_beizhu.Location = new System.Drawing.Point(120, 104);
            this.txt_beizhu.Multiline = true;
            this.txt_beizhu.Name = "txt_beizhu";
            this.txt_beizhu.Size = new System.Drawing.Size(437, 129);
            this.txt_beizhu.TabIndex = 36;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(54, 102);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 35;
            this.labelX3.Text = "备    注:";
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.IsPopupCalendarOpen = false;
            this.dateTimeInput1.Location = new System.Drawing.Point(120, 17);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2016, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(165, 21);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 33;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(54, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 32;
            this.labelX1.Text = "操作日期:";
            // 
            // txt_caozuoman
            // 
            this.txt_caozuoman.BackColor = System.Drawing.Color.PowderBlue;
            // 
            // 
            // 
            this.txt_caozuoman.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_caozuoman.Border.BorderBottomColor = System.Drawing.SystemColors.ControlText;
            this.txt_caozuoman.Border.BorderBottomWidth = 1;
            this.txt_caozuoman.Border.Class = "SideNavStrip";
            this.txt_caozuoman.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_caozuoman.Location = new System.Drawing.Point(120, 58);
            this.txt_caozuoman.Name = "txt_caozuoman";
            this.txt_caozuoman.PreventEnterBeep = true;
            this.txt_caozuoman.Size = new System.Drawing.Size(165, 16);
            this.txt_caozuoman.TabIndex = 21;
            this.txt_caozuoman.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // labelX25
            // 
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Location = new System.Drawing.Point(54, 58);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(75, 23);
            this.labelX25.TabIndex = 20;
            this.labelX25.Text = "操 作 人:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(304, 18);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "所做操作:";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(120, 105);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(437, 132);
            this.txt_remark.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 292);
            this.panel3.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.Azure;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.ColorScheme.TabBackground = System.Drawing.Color.Azure;
            this.tabControl1.ColorScheme.TabBackground2 = System.Drawing.Color.Azure;
            this.tabControl1.ColorScheme.TabItemBackground = System.Drawing.Color.PowderBlue;
            this.tabControl1.ColorScheme.TabItemBackground2 = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabItemBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(244))))), 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(254))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(191)))), ((int)(((byte)(243))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(204)))), ((int)(((byte)(233))))), 1F)});
            this.tabControl1.ColorScheme.TabItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(226)))));
            this.tabControl1.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(237)))), ((int)(((byte)(255))))), 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(232)))), ((int)(((byte)(255))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(210)))), ((int)(((byte)(255))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(255))))), 1F)});
            this.tabControl1.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.PowderBlue;
            this.tabControl1.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(217))))), 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(116))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(89))))), 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), 1F)});
            this.tabControl1.ColorScheme.TabPanelBackground = System.Drawing.Color.PowderBlue;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 292);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Text = "tabControl1";
            // 
            // txt_buycode
            // 
            this.txt_buycode.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txt_buycode.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_buycode.Border.BorderBottomColor = System.Drawing.SystemColors.ControlText;
            this.txt_buycode.Border.BorderBottomWidth = 1;
            this.txt_buycode.Border.Class = "SideNavStrip";
            this.txt_buycode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_buycode.Location = new System.Drawing.Point(110, 25);
            this.txt_buycode.Name = "txt_buycode";
            this.txt_buycode.PreventEnterBeep = true;
            this.txt_buycode.ReadOnly = true;
            this.txt_buycode.Size = new System.Drawing.Size(172, 16);
            this.txt_buycode.TabIndex = 0;
            this.txt_buycode.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // labelX19
            // 
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Location = new System.Drawing.Point(48, 23);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(75, 23);
            this.labelX19.TabIndex = 4;
            this.labelX19.Text = "采购单号:";
            // 
            // btn_baocun
            // 
            this.btn_baocun.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_baocun.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_baocun.Location = new System.Drawing.Point(486, 16);
            this.btn_baocun.Name = "btn_baocun";
            this.btn_baocun.Size = new System.Drawing.Size(75, 23);
            this.btn_baocun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_baocun.TabIndex = 12;
            this.btn_baocun.TabStop = false;
            this.btn_baocun.Text = "保存";
            this.btn_baocun.Click += new System.EventHandler(this.btn_baocun_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancel.Location = new System.Drawing.Point(378, 16);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.btn_baocun);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 54);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.txt_buycode);
            this.panel1.Controls.Add(this.labelX19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 62);
            this.panel1.TabIndex = 9;
            // 
            // BuyFollowInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 408);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BuyFollowInformation";
            this.Text = "新增跟进流程";
            this.Load += new System.EventHandler(this.BuyFollowInformation_Load);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_caozuoman;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_buycode;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.ButtonX btn_baocun;
        private DevComponents.DotNetBar.ButtonX btn_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.TextBox txt_beizhu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_caozuo;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
    }
}
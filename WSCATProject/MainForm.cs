﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using WSCATProject.FinanceForm;
using WSCATProject.SellForm;
using WSCATProject.StockForm;
using WSCATProject.StockSystemForm;
using DevComponents.DotNetBar;
using WSCATProject.Base;
using HelperUtility;
using WSCATProject.Buys;
using DevComponents.DotNetBar.SuperGrid;
using Model;
using BLL;

namespace WSCATProject
{
    public partial class MainForm : Office2007RibbonForm
    {
        //当前选中的按钮,用于标记前一个按钮,以替换背景
        //private imageButton clickbtn;
        private InDataForm inDataForm;
        private OutDataForm outDataForm;
        private ReturnedDataForm returnedDataForm;
        private WarehouseForm inwarehouseForm;
        private WarehouseForm outwarehouseForm;
        private WarehouseForm reWarehouseForm;
        private bool ClientNameFormOpen = false;
        private bool OptNameFormOpen = false;

        SellManager sellm = new SellManager();
        BuyManager buym = new BuyManager();

        private int _Jindushu;//进度条数
        private int _Daichuli;//待处理的条数
        //维护天数的枚举列表 
        enum maintainDateTime
        {
            today,
            week,
            month,
            year,
            all
        }
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //getIPAddress();
            superTabItemRe.Click += SuperTabItemRe_Click;
            superTabItemIn.Click += SuperTabItemRe_Click;
            superTabItemOut.Click += SuperTabItemRe_Click;
            superTabItemStock.Click += SuperTabItemRe_Click;
            superTabItemFin.Click += SuperTabItemRe_Click;
            superTabItemSta.Click += SuperTabItemRe_Click;
            superTabItemSys.Click += SuperTabItemRe_Click;
            BLL.StockManager s = new BLL.StockManager();
          
        }

        private void SuperTabItemRe_Click(object sender, EventArgs e)
        {
            //    string selectName = superTabControl1.SelectedTab.Name;
            //    switch (selectName)
            //    {
            //        case "superTabItemRe":
            //            break;
            //        case "superTabItemIn":
            //            break;
            //        case "superTabItemOut":

            //            break;
            //        case "superTabItemStock":

            //            break;
            //        case "superTabItemFin":

            //            break;
            //        case "superTabItemSta":

            //            break;
            //        case "superTabItemSys":

            //            break;
            //        default:
            //            break;
            //    }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            LoginInfomation loginInf = LoginInfomation.getInstance();
            List<string> Writ = new List<string>();
            //写入权限
            foreach (var writ in loginInf.WritePermission)
            {
                Writ.Add(writ);
            }
            this.comboBoxEx1.DataSource = Writ;

            if (string.IsNullOrWhiteSpace(loginInf.UserName))
            {
                Close();
            }
            superTabControl1.SelectedTab = superTabItem1;
            this.sideBarPanelItem1.Image = Properties.Resources.日志大;
            this.labelX1.Text = "跟进进度总数:" + _Jindushu + "";
            this.labelX2.Text = "待处理事项总数:" + _Daichuli + "";



            //LoginForm lf = new LoginForm();
            //lf.ShowDialog();
            //var off = new officeTool();
            //off.initConnString();
            //clickbtn = imgbtn_maintain;
            //imgbtn_maintain.BackgroundImage = Properties.Resources.btn_enter;

        }

        #region button触发切换tabpages的方法
        private void imgbtn_maintain_Click(object sender, EventArgs e)
        {
            //如果前一个按钮不是自身,则替换掉前一个按钮的样式
            //if (clickbtn != imgbtn_maintain)
            //{
            //    lab_location.Text = "售后管理";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage1;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imgbtn_maintain;
            //}
        }

        private void imgbtn_In_Click(object sender, EventArgs e)
        {
            //if (clickbtn != imgbtn_In)
            //{
            //    lab_location.Text = "入库管理";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage2;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imgbtn_In;
            //}
        }

        private void imgbtn_Out_Click(object sender, EventArgs e)
        {
            //if (clickbtn != imgbtn_Out)
            //{
            //    lab_location.Text = "出库管理";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage3;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imgbtn_Out;
            //}
        }

        private void imgbtn_Returned_Click(object sender, EventArgs e)
        {
            //if (clickbtn != imgbtn_Returned)
            //{
            //    lab_location.Text = "退货管理";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage4;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imgbtn_Returned;
            //}
        }

        private void imgbtn_Count_Click(object sender, EventArgs e)
        {
            //if (clickbtn != imgbtn_Count)
            //{
            //    lab_location.Text = "统计报表";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage5;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imgbtn_Count;
            //}
        }

        private void imagebtnrenshi_Click(object sender, EventArgs e)
        {
            //if (clickbtn != imagebtn_renshi)
            //{
            //    lab_location.Text = "人事管理";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage6;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imagebtn_renshi;
            //}
        }

        private void imgbtn_Link_Click(object sender, EventArgs e)
        {
            //if (clickbtn != imgbtn_Link)
            //{
            //    lab_location.Text = "配置与传输";
            //    clickbtn.BackgroundImage = Properties.Resources.btn_None;
            //    tabcontrol_main.SelectedTab = tabPage7;
            //    clickbtn._buttonStyle = imageButton.buttonStyle.none;
            //    clickbtn = imgbtn_Link;
            //}
        }

        #endregion

        #region picbox在鼠标移入移出的变化

        private void picbox_MouseLeave(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
            pb.Refresh();
        }
        //当鼠标进入picbox区域时,绘制线条和移动位置,实现突出效果
        private void picbox_MouseEnter(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            var g = pb.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var p = new Pen(Color.FromArgb(192, 192, 192));
            g.DrawLine(p, 0, pb.Size.Height - 1, pb.Size.Width - 1, pb.Size.Height - 1);
            g.DrawLine(p, pb.Size.Width - 1, pb.Size.Height - 1, pb.Size.Width - 1, 0);
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }
        //下方按钮移入加上backgroup图片
        private void buttonAddBackgroupIsBottom_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bottomBtnBackgroup;
        }
        //下方按钮移出图片 
        private void buttonRemoveBackgroupIsBottom_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackgroundImage = null;
        }
        //右方按钮加入背景 
        private void buttonAddBackgroupIsRight_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.btnRightBackgroup;
        }
        //右方按钮移除背景
        private void buttonRemoveBackgroupIsRight_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackgroundImage = null;
        }
        #endregion

        #region 连接手持机与收发

        private bool blPressLink = true;
        private bool blLinkOK = false;
        Thread threadWatch = null;
        private Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        private void button_linkPDA_Click(object sender, EventArgs e)
        {
            this.button_linkPDA.Enabled = false;
            if (this.button_linkPDA.Text == "连接手持机")
            {
                if (blPressLink == true)
                {
                    blPressLink = false;
                    linkClient();
                }
            }
            else if (this.button_linkPDA.Text == "取消同步手持机")
            {
                this.button_linkPDA.Enabled = true;
                this.button_linkPDA.ForeColor = Color.Black;
                this.button_linkPDA.Text = "连接手持机";
                if (blLinkOK == true)
                    threadWatch.Abort();
                blPressLink = true;
                //button_linkPDA.Enabled = false;
                socketWatch.Close();
            }
            this.button_linkPDA.Enabled = true;

        }

        Socket socketWatch = null;
        private void linkClient()
        {
            if (this.textBox_ipAddr.Text != "")
            {
                socketWatch = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                var ip = IPAddress.Parse(this.textBox_ipAddr.Text);
                var ipe = new IPEndPoint(ip, 2080);
                try
                {
                    socketWatch.Bind(ipe);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
                socketWatch.Listen(30);
                threadWatch = new Thread(WatchConnecting);
                threadWatch.IsBackground = true;
                threadWatch.Start();
                blLinkOK = true;
                this.textBox_status.Text = "服务器启动成功";
                this.button_linkPDA.Enabled = false;
            }
        }

        private void WatchConnecting()
        {

            while (true)
            {
                var sokConnection = socketWatch.Accept();
                client_comboBox.Items.Add(sokConnection.RemoteEndPoint.ToString());
                dict.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);
                this.textBox_status.Text = "连接成功";
                this.button_linkPDA.ForeColor = Color.Red;
                this.button_linkPDA.Text = "取消同步手持机";
                //Thread thr = new Thread(receMsg);
                //thr.IsBackground = true;
                //thr.Start(sokConnection);
                lock (this)
                {
                    receMsg(sokConnection);
                }
            }
        }

        private void receMsg(object sokConnectionparn)
        {
            var sokClient = sokConnectionparn as Socket;
            while (true)
            {
                var arrMsgRec = new byte[1024 * 1024 * 2];
                var length = -1;
                try
                {
                    if (sokClient != null)
                    {
                        length = sokClient.Receive(arrMsgRec);
                        var strTmp = System.Text.Encoding.
                            UTF8.GetString(arrMsgRec, 0, length);
                        if (strTmp.Length >= 5)
                            ChangeTextThread(strTmp, sokClient);
                    }
                }
                catch
                { }
                if (length == 0)
                {
                    if (sokClient.Poll(1000, SelectMode.SelectWrite))
                    {
                        try
                        {
                            sokClient.Shutdown(SocketShutdown.Both);
                            sokClient.Close();
                            break;
                        }
                        catch
                        {
                            break;
                        }
                    }
                }
            }
        }

        private bool blInOk = false;
        private bool blInStart = false;
        private StringBuilder strAll = new StringBuilder();
        private StringBuilder strReturn = new StringBuilder();
        private bool p = false;
        private bool pReturned = false;
        private bool pMaintain = false;
        //ReceiveDataDispose RDD = new ReceiveDataDispose();
        private void ChangeTextThread(string strText, Socket sokClient)
        {
            //this.test_textBox.Text = strText;
            var intIn = strText.IndexOf("input:");
            if (intIn == 0)
            {
                button_linkPDA.Enabled = false;
                blInStart = true;
                this.textBox_status.Text = "正在接收入出库文件。。。";
            }
            if (blInStart == true)
            {
                try
                {
                    if (strText.Equals("") || strText.Length <= 0)
                        MessageBox.Show("空");
                    else
                    {
                        strAll.Append(strText);
                    }
                    if (strAll.ToString().IndexOf("#outEnd") > 24)//数据大于标志
                    {
                        p = true;
                    }
                    if (strAll.ToString().IndexOf("#reEnd") > 41)
                    {
                        pReturned = true;
                    }
                    if (strAll.ToString().IndexOf("#maintainEnd") > 56)
                    {
                        pMaintain = true;
                    }
                    if (strAll.ToString().IndexOf("#outEnd") > 1)
                    {
                        if (!p)
                        {
                            p = false;
                            blInOk = true;
                            blInStart = false;
                            button_linkPDA.Enabled = true;
                            var sendStr = "receDataInOutOK";
                            var bs = Encoding.ASCII.GetBytes(sendStr);
                            sokClient.Send(bs, bs.Length, 0);//发送测试信息
                            Thread.Sleep(5);
                            if (pReturned)
                            {
                                pReturned = false;
                                //RDD.saveReturnedFile(strAll.ToString());
                                this.textBox_status.Text = "完成接收退货文件";
                                var sendStrRe = "receDataReOK";
                                var bsr = Encoding.ASCII.GetBytes(sendStrRe);
                                sokClient.Send(bsr, bsr.Length, 0);
                                Thread.Sleep(5);
                            }
                            else//退货为空
                            {
                                var sendStrRe = "receDataReOK";
                                var bsr = Encoding.ASCII.GetBytes(sendStrRe);
                                sokClient.Send(bsr, bsr.Length, 0);
                                Thread.Sleep(5);
                            }
                            if (pMaintain)
                            {
                                pMaintain = false;
                                //RDD.saveMaintainFile(strAll.ToString());
                            }
                            else
                            {
                                //string sendStrRe = "receDataMaOK";
                                //byte[] bsr = Encoding.ASCII.GetBytes(sendStrRe);
                                //sokClient.Send(bsr, bsr.Length, 0);
                                //Thread.Sleep(5);
                                MessageBox.Show("null");
                            }
                            strAll = new StringBuilder();
                        }
                    }
                }
                catch
                {
                    strAll = new StringBuilder();
                    p = false;
                    blInOk = true;
                    blInStart = false;
                    button_linkPDA.Enabled = true;
                    var sendStr = "receDataInOutOK";
                    var bs = Encoding.ASCII.GetBytes(sendStr);
                    sokClient.Send(bs, bs.Length, 0);
                    Thread.Sleep(5);
                    MessageBox.Show("传输出现错误，请检查网络连接。", "温馨提示");
                }
            }
            var intPair = strText.IndexOf("recePairOk");
            if (intPair >= 0)
                MessageBox.Show("下载配对表成功", "温馨提示");
            var intOpt = strText.IndexOf("receOptOk");
            if (intOpt >= 0)
                MessageBox.Show("下载操作员表成功", "温馨提示");
            var intSdr = strText.IndexOf("receSdrOk");
            if (intSdr >= 0)
                MessageBox.Show("下载送货员表成功", "温馨提示");
            var intStr = strText.IndexOf("receStrOk");
            if (intStr >= 0)
                MessageBox.Show("下载安装员表成功", "温馨提示");
            var intCli = strText.IndexOf("rececliOk");
            if (intCli >= 0)
                MessageBox.Show("下载客户信息成功", "温馨提示");
            if (p)
            {
                //RDD.saveInOutFile(strAll.ToString());
                blInOk = true;
                blInStart = false;
                p = false;
                this.textBox_status.Text = "完成接收入出库文件";
                button_linkPDA.Enabled = true;
                var sendStr = "receDataInOutOK";
                //string sendStr = "receThrOK";
                var bs = Encoding.ASCII.GetBytes(sendStr);
                //Console.WriteLine("Send Message");
                sokClient.Send(bs, bs.Length, 0);
                Thread.Sleep(5);
                if (pReturned)
                {
                    pReturned = false;
                    //RDD.saveReturnedFile(strAll.ToString());
                    this.textBox_status.Text = "完成接收退货文件";
                    var sendStrRe = "receDataReOK";
                    var bsr = Encoding.ASCII.GetBytes(sendStrRe);
                    sokClient.Send(bsr, bsr.Length, 0);
                    Thread.Sleep(5);
                }
                else//退货为空
                {
                    var sendStrRe = "receDataReOK";
                    var bsr = Encoding.ASCII.GetBytes(sendStrRe);
                    sokClient.Send(bsr, bsr.Length, 0);
                    Thread.Sleep(5);
                }
                if (pMaintain)
                {
                    pMaintain = false;
                    //RDD.saveMaintainFile(strAll.ToString());
                }
                strAll = new StringBuilder();
            }
        }

        private void MsgShow(string msg)
        {
            Invoke(new Action(() =>
                {
                    MessageBox.Show(msg);
                }));
        }

        private void picbox_inInsert_Click(object sender, EventArgs e)
        {

        }

        private void getIPAddress()
        {
            var hostName = Dns.GetHostName();
            var myIp =
                Dns.GetHostEntry(hostName);
            var ipList = myIp.AddressList;

            foreach (var ip in ipList)
            {
                if (ip.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    if (!ip.Equals("127.0.0.1") &&
                        !ip.Equals("0.0.0.0"))
                    {
                        textBox_ipAddr.Text = ip.ToString();
                    }
                    else
                    {
                        MessageBox.Show("获取网络地址失败,请检查网络配置");
                    }
                }
            }
        }

        #endregion

        #region 重绘控件
        //重绘pannel,添增蓝色边框 
        private void bottomPanelBorder_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics,
                p.ClientRectangle,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.None,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.Solid,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.None,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.Solid);
        }

        private void rightPanelBorder_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics,
                p.ClientRectangle,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.Solid,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.None,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.Solid,
                Color.FromArgb(51, 153, 255),
                1,
                ButtonBorderStyle.None);
        }
        #endregion

        #region 显示与调用窗体
        private void picbox_inSelect_Click_1(object sender, EventArgs e)
        {
            InStorageForm f = new InStorageForm();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InReturnedForm f = new InReturnedForm();
            f.Show();
        }

        private void picbox_inInsert_Click_1(object sender, EventArgs e)
        {
            PayOrderForm f = new PayOrderForm();
            f.Show();
        }

        private void pbMarketReceipts_Click(object sender, EventArgs e)
        {
            InSellForm f = new InSellForm();
            f.Show();
        }

        private void pbMarketReturned_Click(object sender, EventArgs e)
        {
            ReturnedSellForm f = new ReturnedSellForm();
            f.Show();
        }

        private void pbMarketGet_Click(object sender, EventArgs e)
        {
            PaySellForm f = new PaySellForm();
            f.Show();
        }

        private void pbWarehomeIn_Click(object sender, EventArgs e)
        {
            StockOtherReceivingForm f = new StockOtherReceivingForm();
            f.Show();
        }

        private void pbWarehomeOut_Click(object sender, EventArgs e)
        {
            StockOtherInvoiceForm f = new StockOtherInvoiceForm();
            f.Show();
        }

        private void pbWarehomeClearing_Click(object sender, EventArgs e)
        {
            StockpandianForm f = new StockpandianForm();
            f.Show();
        }

        private void pbWarehomeDamage_Click(object sender, EventArgs e)
        {
            StockbaosunForm f = new StockbaosunForm();
            f.Show();
        }

        private void pbWarehomeAdjust_Click(object sender, EventArgs e)
        {
            StockAdjustPriceForm f = new StockAdjustPriceForm();
            f.Show();
        }

        private void pbWarehomeChange_Click(object sender, EventArgs e)
        {
            StockdiaoboForm f = new StockdiaoboForm();
            f.Show();
        }

        private void pbWarehomeGetMaterial_Click(object sender, EventArgs e)
        {
            StockRequisitionForm f = new StockRequisitionForm();
            f.Show();
        }
        #endregion

        #region 选项卡的操作
        //基础按钮-客户按钮
        private void buttonItemClient_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.ShowDialog();
        }
        //~-货品按钮
        private void buttonItemMate_Click(object sender, EventArgs e)
        {
            MaterialForm mf = new MaterialForm();
            mf.ShowDialog();
        }
        //~-供应商按钮
        private void buttonItemSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm su = new SupplierForm();
            su.ShowDialog();
        }
        //~-货品分类按钮
        private void buttonItemType_Click(object sender, EventArgs e)
        {
            MaterialTypeForm mtf = new MaterialTypeForm();
            mtf.ShowDialog();
        }
        //~-员工按钮
        private void buttonItemEmpolyee_Click(object sender, EventArgs e)
        {
            EmpolyeeForm em = new EmpolyeeForm();
            em.ShowDialog();
        }
        //~-地区按钮
        private void buttonItemCity_Click_1(object sender, EventArgs e)
        {
            CityType ct = new CityType();
            ct.ShowDialog();
        }
        //~-仓库资料按钮
        private void buttonItemStock_Click(object sender, EventArgs e)
        {
            StorageForm sf = new StorageForm();
            sf.ShowDialog();
        }
        //~-物流信息
        private void buttonItemCarry_Click(object sender, EventArgs e)
        {

        }
        //~-资金账户
        private void buttonItemBank_Click(object sender, EventArgs e)
        {
            BankAccountForm baf = new BankAccountForm();
            baf.ShowDialog();
        }

        private void superTabItemOut_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemRe;
        }

        //采购系统
        private void sideBarPanelItemIn_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemIn;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购大;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }

        //销售系统
        private void sideBarPanelItemOut_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemOut;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售大;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }
        //仓库系统
        private void sideBarPanelItemSto_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemStock;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库大;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }

        //财务系统
        private void sideBarPanelItemFin_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemFin;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务大;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }

        //人事系统
        private void sideBarPanelItemSta_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemSta;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事大;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }

        //系统维护
        private void sideBarPanelItemSys_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItemSys;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统大;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
        }

        //工作日志
        private void sideBarPanelItem1_Click(object sender, EventArgs e)
        {
            superTabControl1.SelectedTab = superTabItem1;
            this.sideBarPanelItem1.Image = Properties.Resources.日志大;
            this.sideBarPanelItemRe.Image = Properties.Resources.售后小;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }

        //售后服务
        private void sideBarPanelItemRe_Click(object sender, EventArgs e)
        {
            this.sideBarPanelItemRe.Image = Properties.Resources.售后大;
            this.sideBarPanelItem1.Image = Properties.Resources.日志小;
            this.sideBarPanelItemIn.Image = Properties.Resources.采购小;
            this.sideBarPanelItemOut.Image = Properties.Resources.销售小;
            this.sideBarPanelItemSto.Image = Properties.Resources.仓库小;
            this.sideBarPanelItemFin.Image = Properties.Resources.财务小;
            this.sideBarPanelItemSta.Image = Properties.Resources.人事小;
            this.sideBarPanelItemSys.Image = Properties.Resources.系统小;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            buttonItemEmpolyee_Click(sender, e);
        }

        private void pbFinanceOtherIn_Click(object sender, EventArgs e)
        {
            ProjectInCostType pict = new ProjectInCostType();
            pict.ShowDialog();
        }

        private void pbFinanceOtherOut_Click(object sender, EventArgs e)
        {
            ProjectCostType pct = new ProjectCostType();
            pct.ShowDialog();
        }

        private void btnFinanceOtherIn_Click(object sender, EventArgs e)
        {
            pbFinanceOtherIn_Click(sender, e);
        }

        private void btnFinanceAccount_Click(object sender, EventArgs e)
        {
            buttonItemBank_Click(sender, e);
        }

        private void buttonItem36_Click(object sender, EventArgs e)
        {
            pbFinanceOtherIn_Click(sender, e);
        }

        private void buttonItem37_Click(object sender, EventArgs e)
        {
            pbFinanceOtherOut_Click(sender, e);
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbox_inSelect_Click(object sender, EventArgs e)
        {
            BuyInForm bif = new BuyInForm();
            bif.AuditStatus = 1;
            bif.ShowDialog();
        }

        private void picbox_inInsert_Click_2(object sender, EventArgs e)
        {
            Buys.BuyPayment bp = new Buys.BuyPayment();
            bp.ShowDialog();
        }

        private void buttonInBusiness_Click(object sender, EventArgs e)
        {
            PayBuySelect mbas = new PayBuySelect();
            mbas.ShowDialog();
        }
        //工作日志
        #endregion
        //销售两个表格的绑定
        private void BDSupGridView()
        {
            #region 跟进进度列
            GridColumn gc = null;
            gc = new GridColumn();
            gc.DataPropertyName = "单据类型";
            gc.Name = "Sell_Type";
            gc.HeaderText = "单据类型";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "销售编号";
            gc.Name = "Sell_Code";
            gc.HeaderText = "销售编号";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "客户姓名";
            gc.Name = "Sell_ClientName";
            gc.HeaderText = "客户姓名";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "订单日期";
            gc.Name = "Sell_Date";
            gc.HeaderText = "订单日期";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "本单总金额";
            gc.Name = "Sell_OddMoney";
            gc.HeaderText = "本单总金额";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "审核状态";
            gc.Name = "Sell_Review";
            gc.HeaderText = "审核状态";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "是否付款";
            gc.Name = "Sell_IsPay";
            gc.HeaderText = "是否付款";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "加急状态";
            gc.Name = "Sell_jiajiState";
            gc.HeaderText = "加急状态";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "付款方式";
            gc.Name = "Sell_fukuanfangshi";
            gc.HeaderText = "付款方式";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "运送方式";
            gc.Name = "Sell_TransportType";
            gc.HeaderText = "运送方式";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "到货日期";
            gc.Name = "Sell_GetDate";
            gc.HeaderText = "到货日期";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "Sell_PayMathod";
            gc.Name = "Sell_PayMathod";
            gc.HeaderText = "预收百分百";
            gc.Visible = false;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "送货地址";
            gc.Name = "Sell_Address";
            gc.HeaderText = "送货地址";
            gc.Visible = false;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "操作人";
            gc.Name = "Sell_Operation";
            gc.HeaderText = "操作人";
            gc.Visible = false;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "审核人";
            gc.Name = "Sell_Auditman";
            gc.HeaderText = "审核人";
            gc.Visible = false;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            superGridControlSetback.PrimaryGrid.DataSource = sellm.GetJindu();
            superGridControlSetback.PrimaryGrid.EnsureVisible();
            GridItemsCollection cols = superGridControlSetback.PrimaryGrid.Rows;
            foreach (GridRow item in cols)
            {
                if (item.Cells["Sell_Code"].Value != null || item.Cells["Sell_Code"].Value.ToString() != "")
                {
                    if (item.Cells["Sell_jiajiState"].Value.ToString() == "加急")
                    {
                        Font f = new Font("微软雅黑", 9, FontStyle.Bold);
                        item.Cells["Sell_jiajiState"].CellStyles.Default.Font = f;
                        item.Cells["Sell_jiajiState"].CellStyles.Default.TextColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("无数据！");
                }
                //获取进度的行数
                _Jindushu++;
            }

            #endregion

            #region 待处理事的列
            GridColumn gc1 = null;
            gc1 = new GridColumn();
            gc1.DataPropertyName = "单据类型";
            gc1.Name = "Sell_Type";
            gc1.HeaderText = "单据类型";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "销售编号";
            gc1.Name = "Sell_Code";
            gc1.HeaderText = "销售编号";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "客户姓名";
            gc1.Name = "Sell_ClientName";
            gc1.HeaderText = "客户姓名";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "订单日期";
            gc1.Name = "Sell_Date";
            gc1.HeaderText = "订单日期";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "本单总金额";
            gc1.Name = "Sell_OddMoney";
            gc1.HeaderText = "本单总金额";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "审核状态";
            gc1.Name = "Sell_Review";
            gc1.HeaderText = "审核状态";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "是否付款";
            gc1.Name = "Sell_IsPay";
            gc1.HeaderText = "是否付款";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "加急状态";
            gc1.Name = "Sell_jiajiState";
            gc1.HeaderText = "加急状态";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "付款方式";
            gc1.Name = "Sell_fukuanfangshi";
            gc1.HeaderText = "付款方式";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "运送方式";
            gc1.Name = "Sell_TransportType";
            gc1.HeaderText = "运送方式";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "到货日期";
            gc1.Name = "Sell_GetDate";
            gc1.HeaderText = "到货日期";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "Sell_PayMathod";
            gc1.Name = "Sell_PayMathod";
            gc1.HeaderText = "预收百分百";
            gc1.Visible = false;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "送货地址";
            gc1.Name = "Sell_Address";
            gc1.HeaderText = "送货地址";
            gc1.Visible = false;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "操作人";
            gc1.Name = "Sell_Operation";
            gc1.HeaderText = "操作人";
            gc1.Visible = false;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "审核人";
            gc1.Name = "Sell_Auditman";
            gc1.HeaderText = "审核人";
            gc1.Visible = false;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            superGridControlhandl.PrimaryGrid.DataSource = sellm.SelDaiChuli();
            superGridControlhandl.PrimaryGrid.EnsureVisible();
            GridItemsCollection col = superGridControlhandl.PrimaryGrid.Rows;
            foreach (GridRow item in col)
            {
                if (item.Cells["Sell_Code"].Value != null || item.Cells["Sell_Code"].Value.ToString() != "")
                {
                    if (item.Cells["Sell_jiajiState"].Value.ToString() == "加急")
                    {
                        Font f = new Font("微软雅黑", 9, FontStyle.Bold);
                        item.Cells["Sell_jiajiState"].CellStyles.Default.Font = f;
                        item.Cells["Sell_jiajiState"].CellStyles.Default.TextColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("无数据！");
                }
                //获取进度的行数
                _Daichuli++;
            }

            #endregion

        }

        //采购两个表格的绑定
        private void BDBuySupGridView()
        {
            #region 跟进进度列
            GridColumn gc = null;
            gc = new GridColumn();
            gc.DataPropertyName = "单据类型";
            gc.Name = "Buy_Class";
            gc.HeaderText = "单据类型";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "采购编号";
            gc.Name = "Buy_Code";
            gc.HeaderText = "采购编号";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "供应商";
            gc.Name = "Buy_SupplierName";
            gc.HeaderText = "供应商";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "是否付款";
            gc.Name = "Buy_IsPay";
            gc.HeaderText = "是否付款";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "审核状态";
            gc.Name = "Buy_AuditStatus";
            gc.HeaderText = "审核状态";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "加急状态";
            gc.Name = "Buy_jiajiState";
            gc.HeaderText = "加急状态";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "物流";
            gc.Name = "Buy_Logistics";
            gc.HeaderText = "物流";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "快递电话";
            gc.Name = "Buy_LogPhone";
            gc.HeaderText = "快递电话";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "到货日期";
            gc.Name = "Buy_GetDate";
            gc.HeaderText = "到货日期";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "操作人";
            gc.Name = "Buy_Operation";
            gc.HeaderText = "操作人";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            gc = new GridColumn();
            gc.DataPropertyName = "审核人";
            gc.Name = "Buy_Auditman";
            gc.HeaderText = "审核人";
            gc.Visible = true;
            superGridControlSetback.PrimaryGrid.Columns.Add(gc);

            superGridControlSetback.PrimaryGrid.DataSource = buym.SelBuyJindu();
            superGridControlSetback.PrimaryGrid.EnsureVisible();
            GridItemsCollection cols = superGridControlSetback.PrimaryGrid.Rows;
            foreach (GridRow item in cols)
            {
                if (item.Cells["Buy_Code"].Value != null || item.Cells["Buy_Code"].Value.ToString() != "")
                {
                    if (item.Cells["Buy_jiajiState"].Value.ToString() == "加急")
                    {
                        Font f = new Font("微软雅黑", 9, FontStyle.Bold);
                        item.Cells["Buy_jiajiState"].CellStyles.Default.Font = f;
                        item.Cells["Buy_jiajiState"].CellStyles.Default.TextColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("无数据！");
                }
                //获取进度的行数
                _Jindushu++;
            }

            #endregion

            #region 待处理事的列
            GridColumn gc1 = null;
            gc1 = new GridColumn();
            gc1.DataPropertyName = "单据类型";
            gc1.Name = "Buy_Class";
            gc1.HeaderText = "单据类型";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "采购编号";
            gc1.Name = "Buy_Code";
            gc1.HeaderText = "采购编号";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "供应商";
            gc1.Name = "Buy_SupplierName";
            gc1.HeaderText = "供应商";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "是否付款";
            gc1.Name = "Buy_IsPay";
            gc1.HeaderText = "是否付款";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "审核状态";
            gc1.Name = "Buy_AuditStatus";
            gc1.HeaderText = "审核状态";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "加急状态";
            gc1.Name = "Buy_jiajiState";
            gc1.HeaderText = "加急状态";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "物流";
            gc1.Name = "Buy_Logistics";
            gc1.HeaderText = "物流";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "快递电话";
            gc1.Name = "Buy_LogPhone";
            gc1.HeaderText = "快递电话";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "到货日期";
            gc1.Name = "Buy_GetDate";
            gc1.HeaderText = "到货日期";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "操作人";
            gc1.Name = "Buy_Operation";
            gc1.HeaderText = "操作人";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            gc1 = new GridColumn();
            gc1.DataPropertyName = "审核人";
            gc1.Name = "Buy_Auditman";
            gc1.HeaderText = "审核人";
            gc1.Visible = true;
            superGridControlhandl.PrimaryGrid.Columns.Add(gc1);

            superGridControlhandl.PrimaryGrid.DataSource =buym.SelBuyDaiChuli();
            superGridControlhandl.PrimaryGrid.EnsureVisible();
            GridItemsCollection col = superGridControlhandl.PrimaryGrid.Rows;
            foreach (GridRow item in col)
            {
                if (item.Cells["Buy_Code"].Value != null || item.Cells["Buy_Code"].Value.ToString() != "")
                {
                    if (item.Cells["Buy_jiajiState"].Value.ToString() == "加急")
                    {
                        Font f = new Font("微软雅黑", 9, FontStyle.Bold);
                        item.Cells["Buy_jiajiState"].CellStyles.Default.Font = f;
                        item.Cells["Buy_jiajiState"].CellStyles.Default.TextColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("无数据！");
                }
                //获取进度的行数
                _Daichuli++;
            }

            #endregion
        }
        /// <summary>
        /// 下拉框选中改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Writddl = this.comboBoxEx1.Text;
                switch (Writddl)
                {
                    case "用户资料":
                        break;
                    case "权限分配":
                        break;
                    case "仓库资料":
                        break;
                    case "货品资料":
                        break;
                    case "供应商资料":
                        break;
                    case "物料信息":
                        break;
                    case "仓库系统":
                        break;
                    case "销售系统":
                        Clear();
                        BDSupGridView();
                        break;
                    case "售后系统":
                        break;
                    case "采购系统":
                        Clear(); 
                        BDBuySupGridView();
                        break;
                    case "财务系统":
                        break;
                    case "考勤系统":
                        break;
                    default:
                        break;
                }
                this.labelX1.Text = "跟进进度总数:" + _Jindushu + "";
                this.labelX2.Text = "待处理事项总数:" + _Daichuli + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }

        /// <summary>
        /// 清空数据和表格的方法
        /// </summary>
        private void Clear()
        {
            _Daichuli = 0;
            _Jindushu = 0;
            superGridControlSetback.PrimaryGrid.DataSource = null;
            superGridControlSetback.PrimaryGrid.Columns.Clear();
            superGridControlhandl.PrimaryGrid.DataSource = null;
            superGridControlhandl.PrimaryGrid.Columns.Clear();
        }

        private void buttonItem39_Click(object sender, EventArgs e)
        {

        }
    }
}
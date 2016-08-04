using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using HelperUtility.Encrypt;
using DevComponents.DotNetBar.SuperGrid;
using WSCATProject.Base.Buys;

namespace WSCATProject.Buys
{
    public partial class FollowLoisticalForm : Form
    {
        public FollowLoisticalForm()
        {
            InitializeComponent();
        }
        //单号
        private string danHaoCode;
        public string DanHaoCode
        {
            get
            {
                return danHaoCode;
            }

            set
            {
                danHaoCode = value;
            }
        }
        BuyProcessManager buypr = new BuyProcessManager();
        CodingHelper ch = new CodingHelper();
        //加载事件
        private void FollowLoisticalForm_Load(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.AutoGenerateColumns = false;
            superGridControl1.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            superGridControl1.PrimaryGrid.InitialSelection = RelativeSelection.None;
            superGridControl1.PrimaryGrid.FocusCuesEnabled = false;
            superGridControl1.PrimaryGrid.ActiveRowIndicatorStyle = ActiveRowIndicatorStyle.None;
            this.textBoxXdanhao.Text = danHaoCode;
          
            Band(danHaoCode);
        }
        /// <summary>
        /// 回车事件搜索时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeInput2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                DateTime start = this.dateTimeInput1.Value;//开始时间
                DateTime end = this.dateTimeInput2.Value;//结束时间
                DataTable dt = buypr.SelTimeDataTable(start, end);//查询
                this.superGridControl1.PrimaryGrid.DataSource = dt;
            }
        }
        /// <summary>
        /// 新增按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXAdd_Click(object sender, EventArgs e)
        {
            BuyFollowInformation buyfollow = new Base.Buys.BuyFollowInformation(this);
            buyfollow.BuyCode = this.textBoxXdanhao.Text.Trim();//单号
            buyfollow.ShowDialog();//用show  不会往下执行  
            Band(danHaoCode);
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Band(string code)
        {
            this.superGridControl1.PrimaryGrid.DataSource = buypr.SelBuyDataTable(XYEEncoding.strCodeHex(code));
        }
    }
}

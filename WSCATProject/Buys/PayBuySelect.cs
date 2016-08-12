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
using DevComponents.DotNetBar.SuperGrid;
using HelperUtility.Encrypt;

namespace WSCATProject.Buys
{
    public partial class PayBuySelect : Form
    {
        BuyManager bm = new BuyManager();
        SellManager sm = new SellManager();
        DataTable dt = null;
 
        public string whereField;
        public string orderField;
        public PayBuySelect()
        {
            InitializeComponent();

            this.toolStrip1.Items.Insert(6, new ToolStripControlHost(dateTimePicker1));
            this.toolStrip1.Items.Insert(8, new ToolStripControlHost(dateTimePicker2));
            今天ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            本周ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            上周ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            本月ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            上月ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            本年ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            上年ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;
            全部ToolStripMenuItem.Click += ToolStripMenuDateTimeItem_Click;

            今天ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            本周ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            上周ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            本月ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            上月ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            本年ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            上年ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;
            全部ToolStripMenuItem1.Click += ToolStripMenuDateTimeItem_Click;

            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += DateTimePicker1_ValueChanged;
        }


        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string startDate = dateTimePicker1.Value.ToString();
                string stopDate = dateTimePicker2.Value.ToString();
                superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, startDate, stopDate, orderField);
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3215-业务查找：采购单数据加载时异常，异常信息：" + ex.Message);
            }
        }
        #region 日期范围查询公用函数
        /// <summary>
        /// 日期范围查询公用函数   
        /// </summary>
        /// <param name="dt">筛选数据源</param>
        /// <param name="stratWeek">开始日期</param>
        /// <param name="stopWeek">结束日期</param>
        /// <returns></returns>
        private static DataTable WhereDateBetween(DataTable dt, string whereField, string stratWeek, string stopWeek, string orderField)
        {
            if (dt == null)
            {
                MessageBox.Show("列表为空!");
            }
            else
            {
                DataRow[] dr = dt.Select(string.Format("{0}>'{1}' and {0}<'{2}'", whereField, stratWeek, stopWeek), orderField);
                DataTable dtNew = dt.Clone();
                foreach (DataRow item in dr)
                {
                    dtNew.ImportRow(item);
                }
                dt = dtNew;
            }
            return dt;
        }
        #endregion
        /// <summary>
        /// 日期范围筛选公用事件  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuDateTimeItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            int dayofweek = Convert.ToInt32(DateTime.Now.DayOfWeek);
            string stratWeek;
            string stopWeek;
            try
            {
                switch (tsmi.Text)
                {
                    case "今天":
                        stratWeek = DateTime.Now.AddDays(dayofweek - 2).ToShortDateString();
                        stopWeek = DateTime.Now.AddDays(dayofweek).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "本周":
                        //本周开始日期
                        stratWeek = DateTime.Now.AddDays(1 - dayofweek).ToShortDateString();
                        //结束日期
                        stopWeek = DateTime.Now.AddDays(6 - dayofweek + 1).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "上周":
                        stratWeek = DateTime.Now.AddDays(1 - dayofweek - 7).ToShortDateString();
                        stopWeek = DateTime.Now.AddDays(1 - dayofweek - 7).AddDays(6).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "本月":
                        stratWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(0).ToShortDateString();
                        stopWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "上月":
                        stratWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(-1).ToShortDateString();
                        stopWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddDays(-1).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "本年":
                        stratWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).ToShortDateString();
                        stopWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(1).AddDays(-1).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "上年":
                        stratWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(-1).ToShortDateString();
                        stopWeek = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddDays(-1).ToShortDateString();
                        superGridControl1.PrimaryGrid.DataSource = WhereDateBetween(dt, whereField, stratWeek, stopWeek, orderField);
                        break;
                    case "全部":
                        superGridControl1.PrimaryGrid.DataSource = dt;
                        break;
                    default:
                        MessageBox.Show("选择错误！");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3216-业务查找：采购单日期筛选异常，异常信息：" + ex.Message);
            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayBuySelect_Load(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.AutoGenerateColumns = false;
            superGridControl1.PrimaryGrid.SelectionGranularity = SelectionGranularity.Row;
            superGridControl1.PrimaryGrid.InitialSelection = RelativeSelection.None;
            superGridControl1.PrimaryGrid.FocusCuesEnabled = false;
            superGridControl1.PrimaryGrid.ActiveRowIndicatorStyle = ActiveRowIndicatorStyle.None;
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox2.SelectedIndex = 0;
        }
        /// <summary>
        /// 快捷搜索下拉框功能实现
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
                {
                    return;
                }
                string typeName = toolStripComboBox1.Text;
                string searchTxt = toolStripTextBox1.Text.Trim();
                string sql = "";
                switch (typeName)
                {
                    case "货品编号":
                        sql = "Buy_Code='{0}'";
                        break;
                    case "货品名称":
                        sql = "Sell_MaName='{0}'";
                        break;
                    case "规格型号":
                        sql = "Sell_Model='{0}'";
                        break;
                    default:
                        MessageBox.Show("类型错误！请重新选择。");
                        break;
                }
                DataRow[] dr = dt.Select(string.Format(sql, searchTxt), "Buy_ID");
                DataTable dtNew = dt.Clone();
                foreach (DataRow item in dr)
                {
                    dtNew.ImportRow(item);
                }
                dt = dtNew;
                superGridControl1.PrimaryGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3217-业务查找：采购单快捷搜索异常，异常信息：" + ex.Message);
            }
        }

        /// <summary>
        /// 单据类型下拉框内容实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cb2 = toolStripComboBox2.Text;

            #region 固定列名，考虑用table查询的as
            GridColumn gc = null;
            string[] BuysColumns = { "单据类型", "单据编号", "单据日期", "单据状态", "供应商", "结算账户", "本次付款", "总金额", "业务员", "摘要" };
            string[] Sellcolumns = { "单据类型", "单据编号", "单据日期", "单据状态", "客户", "结算账户", "本次收款", "总金额", "业务员", "摘要" };
            string[] OtherReceiptColumns = { "仓库", "单据编号", "单据日期", "单据状态", "单据自定义一", "单据自定义二", "单据自定义三", "业务员", "摘要" };
            string[] OtherSendColumns = OtherReceiptColumns;
            string[] RequisitionColumns = { "单据类型", "仓库", "单据编号", "单据日期", "单据状态", "单据自定义一", "单据自定义二", "单据自定义三", "领料人", "摘要" };
            string[] MoveColumns = { "单据类型", "调出仓库", "调入仓库", "单据编号", "单据日期", "单据状态", "业务员", "制单人", "摘要" };
            string[] BreakageColumns = { "仓库", "单据编号", "单据日期", "单据状态", "业务员", "摘要" };
            string[] CheckColumns = OtherReceiptColumns;
            string[] AdjustPriceColumns = { "仓库", "单据编号", "单据日期", "单据状态", "调价比率%", "业务员", "摘要" };
            string[] OtherCostColumns = { "单据类型", "单据编号", "单据日期", "单据状态", "往来单位", "结算账户", "总金额", "业务员", "摘要" };
            string[] OtherInCostColumns = OtherCostColumns;
            string[] PaymentWaitColumns = { "单据类型", "单据编号", "单据日期", "单据状态", "往来单位", "结算账户", "付款金额", "实付金额", "业务员", "摘要" };
            string[] ReceiptColumns = { "单据类型", "单据编号", "单据日期", "单据状态", "往来单位", "结算账户", "收款金额", "实付金额", "业务员", "摘要" };
            string[] AccessMoneyColumns = { "单据编号", "单据日期", "单据状态", "付款账户", "收款金额", "收款账户", "收款金额", "业务员", "摘要" };
            string[] EmbezzleColumns = AccessMoneyColumns;
            //二维数组  用法：实例名[0][0]  便于更改表头时不用去改实现代码
            string[][] ColumnsHeaderText =
            {
                BuysColumns,
                Sellcolumns,
                OtherReceiptColumns,
                OtherSendColumns,
                RequisitionColumns,
                MoveColumns,
                BreakageColumns,
                CheckColumns,
                AdjustPriceColumns,
                OtherCostColumns,
                OtherInCostColumns,
                PaymentWaitColumns,
                ReceiptColumns,
                AccessMoneyColumns,
                EmbezzleColumns
            };
            #endregion

            switch (cb2)
            {
                case "采购开单":
                    superGridControl1.PrimaryGrid.DataSource = null;
                    superGridControl1.PrimaryGrid.Columns.Clear();
                    try
                    {
                        #region 初始化采购开单列
                        gc = new GridColumn();
                        gc.DataPropertyName = "ID";
                        gc.Name = "ColumnsID";
                        gc.HeaderText = "ID";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "编号";
                        gc.Name = "ColumnsCode";
                        gc.HeaderText = "编号";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "单据日期";
                        gc.Name = "ColumnsDate";
                        gc.HeaderText = "单据日期";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "审核状态";
                        gc.Name = "ColumnsAuditStatus";
                        gc.HeaderText = "审核状态";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "单据状态";
                        gc.Name = "ColumnsPurchaseStatus";
                        gc.HeaderText = "单据状态";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "供应商";
                        gc.Name = "ColumnsSuName";
                        gc.HeaderText = "供应商";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "结算账户";
                        gc.Name = "ColumnsBank";
                        gc.HeaderText = "结算账户";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "总金额";
                        gc.Name = "ColumnsAmountMone";
                        gc.HeaderText = "总金额";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "业务员";
                        gc.Name = "ColumnsSalesMan";
                        gc.HeaderText = "业务员";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "备注";
                        gc.Name = "ColumnsRemark";
                        gc.HeaderText = "备注";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        dt = bm.SelBuyDataTableToCheck();
                        superGridControl1.PrimaryGrid.DataSource = dt;
                        whereField = "单据日期";
                        orderField = "ID";
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误代码:3218-采购业务查找：采购单加载全部数据异常，异常信息：" + ex.Message);
                    }
                    break;
                case "销售开单":
                    superGridControl1.PrimaryGrid.DataSource = null;
                    superGridControl1.PrimaryGrid.Columns.Clear();

                    try
                    {
                        #region 初始化销售开单列
                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_ID";
                        gc.Name = "ColumnsID";
                        gc.HeaderText = "ID";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_Code";
                        gc.Name = "ColumnsCode";
                        gc.HeaderText = "编号";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_Date";
                        gc.Name = "ColumnsDate";
                        gc.HeaderText = "单据日期";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_Review";
                        gc.Name = "ColumnsAuditStatus";
                        gc.HeaderText = "审核状态";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_Type";
                        gc.Name = "ColumnsPurchaseStatus";
                        gc.HeaderText = "单据状态";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_ClientName";
                        gc.Name = "ColumnsSuName";
                        gc.HeaderText = "客户";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_AccountCode";
                        gc.Name = "ColumnsBank";
                        gc.HeaderText = "结算账户";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_OddMoney";
                        gc.Name = "ColumnsAmountMone";
                        gc.HeaderText = "总金额";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_Salesman";
                        gc.Name = "ColumnsSalesMan";
                        gc.HeaderText = "业务员";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "Sell_Remark";
                        gc.Name = "ColumnsRemark";
                        gc.HeaderText = "备注";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        dt = sm.GetList("");
                        superGridControl1.PrimaryGrid.DataSource = dt;
                        whereField = "单据日期";
                        orderField = "ID";
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误代码:3219-销售业务查找：销售单加载全部数据异常，异常信息：" + ex.Message);
                    }
                    break;
                case "其他收货单":
                    break;
                case "其他发货单":
                    break;
                case "领料单":
                    break;
                case "调拨单":
                    break;
                case "报损单":
                    break;
                case "盘点单":
                    break;
                case "调价单":
                    break;
                case "费用开支":
                    break;
                case "其他收入":
                    break;
                case "应付款单":
                    superGridControl1.PrimaryGrid.Columns.Clear();
                    Band();
                    break;
                case "银行存取款":
                    break;
                case "资金拆借":
                    break;
                case "欠货发货单":
                    break;
                default:
                    break;
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridColumn gc = null;
            string cb2 = toolStripComboBox2.Text;
            switch (cb2)
            {
                case "采购开单":
                    superGridControl1.PrimaryGrid.Columns.Clear();
                    try
                    {
                        gc = new GridColumn();
                        gc.DataPropertyName = "ID";
                        gc.Name = "ColumnsID";
                        gc.HeaderText = "ID";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "编号";
                        gc.Name = "ColumnsCode";
                        gc.HeaderText = "编号";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "单据日期";
                        gc.Name = "ColumnsDate";
                        gc.HeaderText = "单据日期";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "审核状态";
                        gc.Name = "ColumnsAuditStatus";
                        gc.HeaderText = "审核状态";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "单据状态";
                        gc.Name = "ColumnsPurchaseStatus";
                        gc.HeaderText = "单据状态";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "供应商";
                        gc.Name = "ColumnsSuName";
                        gc.HeaderText = "供应商";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "结算账户";
                        gc.Name = "ColumnsBank";
                        gc.HeaderText = "结算账户";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "总金额";
                        gc.Name = "ColumnsAmountMone";
                        gc.HeaderText = "总金额";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "业务员";
                        gc.Name = "ColumnsSalesMan";
                        gc.HeaderText = "业务员";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        gc = new GridColumn();
                        gc.DataPropertyName = "备注";
                        gc.Name = "ColumnsRemark";
                        gc.HeaderText = "备注";
                        superGridControl1.PrimaryGrid.Columns.Add(gc);

                        dt = bm.SelBuyDataTableToCheck();
                        superGridControl1.PrimaryGrid.DataSource = dt;
                        whereField = "单据日期";
                        orderField = "ID";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误代码:3218-业务查找：采购单加载全部数据异常，异常信息：" + ex.Message);
                    }
                    break;
                case "销售开单":
                    break;
                case "其他收货单":
                    break;
                case "其他发货单":
                    break;
                case "领料单":
                    break;
                case "调拨单":
                    break;
                case "报损单":
                    break;
                case "盘点单":
                    break;
                case "调价单":
                    break;
                case "费用开支":
                    break;
                case "其他收入":
                    break;
                case "应付款单":
                    superGridControl1.PrimaryGrid.Columns.Clear();
                    Band();
                    break;
                case "银行存取款":
                    break;
                case "资金拆借":
                    break;
                case "欠货发货单":
                    break;
                default:
                    break;
            }
        }

        private void 去付款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (superGridControl1.PrimaryGrid.GetSelectedRows() != null)
            {
                SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
                if (col.Count > 0)
                {
                    GridRow row = col[0] as GridRow;
                    string zhuangtai = row.Cells[2].Value.ToString();
                    switch (zhuangtai)
                    {
                        case "未付款":
                            AppDomain.CurrentDomain.SetData("s", row.Cells[1].Value);
                            AppDomain.CurrentDomain.SetData("q", row.Cells[2].Value);
                            BuyPayment buy = new BuyPayment(this);
                            buy.Weifujine = Convert.ToDouble(row.Cells[8].Value);
                            buy.Show();
                            break;
                        case "已付款":
                            AppDomain.CurrentDomain.SetData("s", row.Cells[1].Value);
                            AppDomain.CurrentDomain.SetData("q", row.Cells[2].Value);
                            BuyPayment bu = new BuyPayment(this);
                            bu.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("请先选中要修改的数据所在行");
                }
            }
            else
            {
                MessageBox.Show("请先选中要修改的数据所在行");
            }
        }

        /// <summary>
        /// 绑定应付款单
        /// </summary>
        public void Band()
        {
			dt = bm.GetYinFuList();
            superGridControl1.PrimaryGrid.DataSource = dt;        }

        private void superGridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (superGridControl1.PrimaryGrid.GetSelectedRows() != null)
            {
                SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
                if (col.Count > 0)
                {
                    GridRow row = col[0] as GridRow;
                    string zhuangtai = row.Cells[2].Value.ToString();
                    AppDomain.CurrentDomain.SetData("s", row.Cells[1].Value);
                    AppDomain.CurrentDomain.SetData("q", row.Cells[2].Value);
                    BuyPayment bu = new BuyPayment(this);
                    bu.Show();
                }
                else
                {
                    MessageBox.Show("请先选中要查看的数据所在行");
                }
            }
            else
            {
                MessageBox.Show("请先选中要查看的数据所在行");
            }
        }

        /// <summary>
        /// 查看物流
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看物流ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (superGridControl1.PrimaryGrid.GetSelectedRows() != null)
            {
                SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
                if (col.Count > 0)
                {
                    GridRow row = col[0] as GridRow;
                    FollowLoisticalForm folloe = new FollowLoisticalForm();
                    folloe.DanHaoCode = row.Cells[1].Value.ToString();
                    folloe.Show();
                }
                else
                {
                    MessageBox.Show("请先选中要查看的数据所在行");
                }
            }
            else
            {
                MessageBox.Show("请先选中要查看的数据所在行");
            }
        }

        private void 新增物料信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (superGridControl1.PrimaryGrid.GetSelectedRows() != null)
                {
                    SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
                    if (col.Count > 0)
                    {
                        GridRow row = col[0] as GridRow;
                        if (bm.Exists(XYEEncoding.strCodeHex(row.Cells[1].Value.ToString())))
                        {
                            InLogisticalForm inLog = new InLogisticalForm();
                            inLog.Danhao = row.Cells[1].Value.ToString();
                            inLog.Show();
                        }
                        else
                        {
                            MessageBox.Show("未审核或者未付款，不能进行添加物流信息。");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("请先选中要查看的数据所在行");
                    }
                }
                else
                {
                    MessageBox.Show("请先选中要查看的数据所在行");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 申请付款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (superGridControl1.PrimaryGrid.GetSelectedRows() != null)
            {
                SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
                if (col.Count > 0)
                {
                    GridRow row = col[0] as GridRow;
                    string shenghestate = row.Cells["ColumnsAuditStatus"].Value.ToString();
                    string danjustate = row.Cells["ColumnsPurchaseStatus"].Value.ToString();
                    if (shenghestate == "已审核" && danjustate == "进行中")
                    {
                        BuyPaymentApplication bpf = new BuyPaymentApplication();
                        bpf.BuyCode = row.Cells["ColumnsCode"].Value.ToString();
                        bpf.Suname = row.Cells["ColumnsSuName"].Value.ToString();
                        bpf.Acountname = row.Cells["ColumnsBank"].Value.ToString();
                        bpf.Fukuan = row.Cells["ColumnsAmountMone"].Value.ToString();
                        bpf.Saleman = row.Cells["ColumnsSalesMan"].Value.ToString();
                        bpf.ShowDialog();
                        superGridControl1.PrimaryGrid.DataSource = dt;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请先选择要操作的行！");
                }
            }
            else
            {
                MessageBox.Show("请先选择要操作的行！");
            }

        }

        private void 审核过账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
            if (col == null)
            {
                MessageBox.Show("请先选中要查看的数据所在行");
                return;
            }
            if (col.Count == 1)
            {
                GridRow row = col[0] as GridRow;
                string code = row.Cells["ColumnsCode"].Value.ToString();
                BuyInForm bif = new BuyInForm();
                bif.BuyOdd = code;
                bif.AuditStatus = 0;
                bif.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("请先选中要查看的数据所在行");
            }
        }

        private void 全部ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.DataSource = dt;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            审核过账ToolStripMenuItem.Visible = false;
            申请付款ToolStripMenuItem.Visible = false;
            去付款ToolStripMenuItem.Visible = false;
            查看物流ToolStripMenuItem.Visible = false;
            新增物料信息ToolStripMenuItem.Visible = false;
            string cb2 = toolStripComboBox2.Text;
            switch (cb2)
            {
                case "采购开单":
                    SelectedElementCollection col = superGridControl1.PrimaryGrid.GetSelectedRows();
                    GridRow row = col[0] as GridRow;
                    string shenghestate = row.Cells["ColumnsAuditStatus"].Value.ToString();
                    string danjustate = row.Cells["ColumnsPurchaseStatus"].Value.ToString();
                    if (shenghestate == "未审核" && danjustate == "已提交")
                    {
                        审核过账ToolStripMenuItem.Visible = true;
                    }
                    if (shenghestate == "已审核" && danjustate == "进行中")
                    {
                        申请付款ToolStripMenuItem.Visible = true;
                    }
                    if (shenghestate == "已审核" && danjustate == "待付款")
                    {
                        去付款ToolStripMenuItem.Visible = true;
                    }
                    if (shenghestate == "已审核" && danjustate == "已付款" || danjustate == "部分付款")
                    {
                        查看物流ToolStripMenuItem.Visible = true;
                    }
                    break;
                case "销售开单":
                    SelectedElementCollection cols = superGridControl1.PrimaryGrid.GetSelectedRows();
                    GridRow rows = cols[0] as GridRow;
                    string shenghestate = rows.Cells["ColumnsAuditStatus"].Value.ToString();
                    break;
                case "其他收货单":
                    break;
                case "其他发货单":
                    break;
                case "领料单":
                    break;
                case "调拨单":
                    break;
                case "报损单":
                    break;
                case "盘点单":
                    break;
                case "调价单":
                    break;
                case "费用开支":
                    break;
                case "其他收入":
                    break;
                case "应付款单":
                    break;
                case "银行存取款":
                    break;
                case "资金拆借":
                    break;
                case "欠货发货单":
                    break;
                default:
                    break;
            }
        }
    }
}

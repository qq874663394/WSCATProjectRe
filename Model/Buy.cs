using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class Buy
	{
		public Buy()
		{}
        #region Model
        private int _buy_id;
        private string _buy_code;
        private DateTime? _buy_date = DateTime.Now;
        private string _buy_stockcode;
        private string _buy_stockname;
        private int? _buy_purchasestatus = 0;
        private int? _buy_auditstatus;
        private string _buy_purchaserid;
        private string _buy_salesman;
        private string _buy_operation;
        private string _buy_auditman;
        private string _buy_remark;
        private string _buy_satetyone;
        private string _buy_satetytwo;
        private int? _buy_clear = 1;
        private string _buy_suppliercode;
        private string _buy_suppliername;
        private string _buy_class;
        private int? _buy_ispay = 0;
        private int? _buy_paymethod = 0;
        private int? _buy_isputsto = 0;
        private DateTime? _buy_getdate;
        private string _buy_logistics;
        private string _buy_logphone;
        private string _buy_logcode;
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Buy_ID
        {
            set { _buy_id = value; }
            get { return _buy_id; }
        }
        /// <summary>
        /// 采购单号
        /// </summary>
        public string Buy_Code
        {
            set { _buy_code = value; }
            get { return _buy_code; }
        }
        /// <summary>
        /// 采购日期
        /// </summary>
        public DateTime? Buy_Date
        {
            set { _buy_date = value; }
            get { return _buy_date; }
        }
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string Buy_StockCode
        {
            set { _buy_stockcode = value; }
            get { return _buy_stockcode; }
        }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string Buy_StockName
        {
            set { _buy_stockname = value; }
            get { return _buy_stockname; }
        }
        /// <summary>
        /// 是否已完成,1已完成,0未完成
        /// </summary>
        public int? Buy_PurchaseStatus
        {
            set { _buy_purchasestatus = value; }
            get { return _buy_purchasestatus; }
        }
        /// <summary>
        /// 审核情况,1已审核,0未审核
        /// </summary>
        public int? Buy_AuditStatus
        {
            set { _buy_auditstatus = value; }
            get { return _buy_auditstatus; }
        }
        /// <summary>
        /// 采购人员ID
        /// </summary>
        public string Buy_PurchaserID
        {
            set { _buy_purchaserid = value; }
            get { return _buy_purchaserid; }
        }
        /// <summary>
        /// 业务员
        /// </summary>
        public string Buy_SalesMan
        {
            set { _buy_salesman = value; }
            get { return _buy_salesman; }
        }
        /// <summary>
        /// 操作人
        /// </summary>
        public string Buy_Operation
        {
            set { _buy_operation = value; }
            get { return _buy_operation; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string Buy_AuditMan
        {
            set { _buy_auditman = value; }
            get { return _buy_auditman; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Buy_Remark
        {
            set { _buy_remark = value; }
            get { return _buy_remark; }
        }
        /// <summary>
        /// 保留字段1
        /// </summary>
        public string Buy_Satetyone
        {
            set { _buy_satetyone = value; }
            get { return _buy_satetyone; }
        }
        /// <summary>
        /// 保留字段2
        /// </summary>
        public string Buy_Satetytwo
        {
            set { _buy_satetytwo = value; }
            get { return _buy_satetytwo; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int? Buy_Clear
        {
            set { _buy_clear = value; }
            get { return _buy_clear; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Buy_SupplierCode
        {
            set { _buy_suppliercode = value; }
            get { return _buy_suppliercode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Buy_SupplierName
        {
            set { _buy_suppliername = value; }
            get { return _buy_suppliername; }
        }
        /// <summary>
        /// 单据类型
        /// </summary>
        public string Buy_Class
        {
            set { _buy_class = value; }
            get { return _buy_class; }
        }
        /// <summary>
        /// 是否已付款(0为未完成,1为已完成)
        /// </summary>
        public int? Buy_IsPay
        {
            set { _buy_ispay = value; }
            get { return _buy_ispay; }
        }
        /// <summary>
        /// 付款方式(0~100，对应实际的数值为百分数。如：50等于付了50%)
        /// </summary>
        public int? Buy_PayMethod
        {
            set { _buy_paymethod = value; }
            get { return _buy_paymethod; }
        }
        /// <summary>
        /// 入库状态(0未入库,1已入库)
        /// </summary>
        public int? Buy_IsPutSto
        {
            set { _buy_isputsto = value; }
            get { return _buy_isputsto; }
        }
        /// <summary>
        /// 到货日期
        /// </summary>
        public DateTime? Buy_GetDate
        {
            set { _buy_getdate = value; }
            get { return _buy_getdate; }
        }
        /// <summary>
        /// 物流
        /// </summary>
        public string Buy_Logistics
        {
            set { _buy_logistics = value; }
            get { return _buy_logistics; }
        }
        /// <summary>
        /// 快递电话
        /// </summary>
        public string Buy_LogPhone
        {
            set { _buy_logphone = value; }
            get { return _buy_logphone; }
        }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string Buy_LogCode
        {
            set { _buy_logcode = value; }
            get { return _buy_logcode; }
        }
        #endregion Model

    }
}


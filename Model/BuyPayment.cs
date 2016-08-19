using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class BuyPayment
	{
		public BuyPayment()
		{}
		#region Model
		private int _buy_id;
		private string _buy_code;
		private string _buy_sucode;
		private string _buy_suname;
		private string _buy_bcode;
		private string _buy_name;
		private string _buy_accountcode;
		private string _buy_accountname;
		private DateTime? _buy_date= DateTime.Now;
		private string _buy_amountpay;
		private string _buy_accountpaid;
		private string _buy_moneyowed;
		private string _buy_salesman;
		private string _buy_salescode;
		private string _buy_auditman;
		private string _buy_remark;
		private string _buy_satetyone;
		private string _buy_satetytwo;
		private int? _buy_clear=1;
		private int? _buy_states=0;
        private string _buy_premoney;
        private string _buy_actmoney;
        private int? _buy_zhuangtai;
        private string _buy_Class;
        private DateTime _buyp_updatedate;
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Buy_ID
		{
			set{ _buy_id=value;}
			get{return _buy_id;}
		}
		/// <summary>
		/// 采购付款编号
		/// </summary>
		public string Buy_Code
		{
			set{ _buy_code=value;}
			get{return _buy_code;}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string Buy_SuCode
		{
			set{ _buy_sucode=value;}
			get{return _buy_sucode;}
		}
		/// <summary>
		/// 供应商名称
		/// </summary>
		public string Buy_SuName
		{
			set{ _buy_suname=value;}
			get{return _buy_suname;}
		}
		/// <summary>
		/// 采购单单号
		/// </summary>
		public string Buy_BCode
		{
			set{ _buy_bcode=value;}
			get{return _buy_bcode;}
		}
		/// <summary>
		/// 采购单名称
		/// </summary>
		public string Buy_Name
		{
			set{ _buy_name=value;}
			get{return _buy_name;}
		}
		/// <summary>
		/// 账户编号
		/// </summary>
		public string Buy_AccountCode
		{
			set{ _buy_accountcode=value;}
			get{return _buy_accountcode;}
		}
		/// <summary>
		/// 账户名称
		/// </summary>
		public string Buy_AccountName
		{
			set{ _buy_accountname=value;}
			get{return _buy_accountname;}
		}
		/// <summary>
		/// 开单日期
		/// </summary>
		public DateTime? Buy_Date
		{
			set{ _buy_date=value;}
			get{return _buy_date;}
		}
		/// <summary>
		/// 应付金额
		/// </summary>
		public string Buy_AmountPay
		{
			set{ _buy_amountpay=value;}
			get{return _buy_amountpay;}
		}
		/// <summary>
		/// 已付金额
		/// </summary>
		public string Buy_AccountPaid
		{
			set{ _buy_accountpaid=value;}
			get{return _buy_accountpaid;}
		}
		/// <summary>
		/// 尚欠
		/// </summary>
		public string Buy_moneyOwed
		{
			set{ _buy_moneyowed=value;}
			get{return _buy_moneyowed;}
		}
		/// <summary>
		/// 业务员
		/// </summary>
		public string Buy_SalesMan
		{
			set{ _buy_salesman=value;}
			get{return _buy_salesman;}
		}
		/// <summary>
		/// 业务员编号
		/// </summary>
		public string Buy_SalesCode
		{
			set{ _buy_salescode=value;}
			get{return _buy_salescode;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Buy_AuditMan
		{
			set{ _buy_auditman=value;}
			get{return _buy_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Buy_Remark
		{
			set{ _buy_remark=value;}
			get{return _buy_remark;}
		}
		/// <summary>
		/// 保留字段
		/// </summary>
		public string Buy_Satetyone
		{
			set{ _buy_satetyone=value;}
			get{return _buy_satetyone;}
		}
		/// <summary>
		/// 保留字段
		/// </summary>
		public string Buy_Satetytwo
		{
			set{ _buy_satetytwo=value;}
			get{return _buy_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Buy_Clear
		{
			set{ _buy_clear=value;}
			get{return _buy_clear;}
		}
		/// <summary>
		/// 单据状态
		/// </summary>
		public int? Buy_States
		{
			set{ _buy_states=value;}
			get{return _buy_states;}
		}
        //预付金额
        public string Buy_Premoney
        {
            get
            {
                return _buy_premoney;
            }

            set
            {
                _buy_premoney = value;
            }
        }
        //实付金额
        public string Buy_Actmoney
        {
            get
            {
                return _buy_actmoney;
            }

            set
            {
                _buy_actmoney = value;
            }
        }
        //付款状态
        public int? Buy_Zhuangtai
        {
            get
            {
                return _buy_zhuangtai;
            }

            set
            {
                _buy_zhuangtai = value;
            }
        }
        //单据类型
        public string Buy_Class
        {
            get
            {
                return _buy_Class;
            }

            set
            {
                _buy_Class = value;
            }
        }
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime BuyP_UpdateDate
        {
            set { _buyp_updatedate = value; }
            get { return _buyp_updatedate; }
        }
        #endregion Model

    }
}


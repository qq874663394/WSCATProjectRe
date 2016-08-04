using System;
namespace Model
{
	/// <summary>
	/// 客户类别表
	/// </summary>
	[Serializable]
	public partial class Conllection
	{
		public Conllection()
		{}
		#region Model
		private int _c_id;
		private string _c_no;
		private string _c_clientcode;
		private string _c_clientname;
		private string _c_accountcode;
		private string _c_accountname;
		private string _c_sellcode;
		private DateTime? _c_date= DateTime.Now;
		private string _c_amountpay;
		private string _c_accountpaid;
		private string _c_moneyowed;
		private string _c_operation;
		private string _c_auditman;
		private string _c_salesman;
		private string _c_salescode;
		private int? _c_auditstatus=0;
		private string _c_remark;
		private string _c_satetyone;
		private string _c_satetytwo;
		private int? _c_clear=1;
		private int? _c_status=0;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
		}
		/// <summary>
		/// 资金收款账号
		/// </summary>
		public string C_No
		{
			set{ _c_no=value;}
			get{return _c_no;}
		}
		/// <summary>
		/// 客户编号
		/// </summary>
		public string C_ClientCode
		{
			set{ _c_clientcode=value;}
			get{return _c_clientcode;}
		}
		/// <summary>
		/// 客户名称
		/// </summary>
		public string C_ClientName
		{
			set{ _c_clientname=value;}
			get{return _c_clientname;}
		}
		/// <summary>
		/// 账户编号
		/// </summary>
		public string C_AccountCode
		{
			set{ _c_accountcode=value;}
			get{return _c_accountcode;}
		}
		/// <summary>
		/// 账户名称
		/// </summary>
		public string C_AccountName
		{
			set{ _c_accountname=value;}
			get{return _c_accountname;}
		}
		/// <summary>
		/// 销售单单号
		/// </summary>
		public string C_SellCode
		{
			set{ _c_sellcode=value;}
			get{return _c_sellcode;}
		}
		/// <summary>
		/// 开单日期
		/// </summary>
		public DateTime? C_Date
		{
			set{ _c_date=value;}
			get{return _c_date;}
		}
		/// <summary>
		/// 应付金额
		/// </summary>
		public string C_AmountPay
		{
			set{ _c_amountpay=value;}
			get{return _c_amountpay;}
		}
		/// <summary>
		/// 已付金额
		/// </summary>
		public string C_AccountPaid
		{
			set{ _c_accountpaid=value;}
			get{return _c_accountpaid;}
		}
		/// <summary>
		/// 尚欠
		/// </summary>
		public string C_MoneyOwed
		{
			set{ _c_moneyowed=value;}
			get{return _c_moneyowed;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string C_Operation
		{
			set{ _c_operation=value;}
			get{return _c_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string C_AuditMan
		{
			set{ _c_auditman=value;}
			get{return _c_auditman;}
		}
		/// <summary>
		/// 业务员
		/// </summary>
		public string C_SalesMan
		{
			set{ _c_salesman=value;}
			get{return _c_salesman;}
		}
		/// <summary>
		/// 业务员编号
		/// </summary>
		public string C_SalesCode
		{
			set{ _c_salescode=value;}
			get{return _c_salescode;}
		}
		/// <summary>
		/// 审核状态
		/// </summary>
		public int? C_AuditStatus
		{
			set{ _c_auditstatus=value;}
			get{return _c_auditstatus;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string C_Remark
		{
			set{ _c_remark=value;}
			get{return _c_remark;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string C_Satetyone
		{
			set{ _c_satetyone=value;}
			get{return _c_satetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string C_Satetytwo
		{
			set{ _c_satetytwo=value;}
			get{return _c_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? C_Clear
		{
			set{ _c_clear=value;}
			get{return _c_clear;}
		}
		/// <summary>
		/// 单据状态
		/// </summary>
		public int? C_Status
		{
			set{ _c_status=value;}
			get{return _c_status;}
		}
		#endregion Model

	}
}


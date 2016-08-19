using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class PaymentWait
	{
		public PaymentWait()
		{}
		#region Model
		private int _pw_id;
		private string _pw_code;
		private string _pw_sucode;
		private string _pw_suname;
		private string _pw_accountcode;
		private string _pw_bcode;
		private string _pw_salesman;
		private string _pw_operation;
		private string _pw_auditman;
		private DateTime? _pw_date= DateTime.Now;
		private string _pw_remark;
		private int? _pw_auditstatus=0;
		private string _pw_satetyone;
		private string _pw_satetytwo;
		private int? _pw_clear=1;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int PW_ID
		{
			set{ _pw_id=value;}
			get{return _pw_id;}
		}
		/// <summary>
		/// 待付款单号
		/// </summary>
		public string PW_Code
		{
			set{ _pw_code=value;}
			get{return _pw_code;}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string PW_SuCode
		{
			set{ _pw_sucode=value;}
			get{return _pw_sucode;}
		}
		/// <summary>
		/// 供应商名称
		/// </summary>
		public string PW_SuName
		{
			set{ _pw_suname=value;}
			get{return _pw_suname;}
		}
		/// <summary>
		/// 账户编号
		/// </summary>
		public string PW_AccountCode
		{
			set{ _pw_accountcode=value;}
			get{return _pw_accountcode;}
		}
		/// <summary>
		/// 所属采购单编号
		/// </summary>
		public string PW_BCode
		{
			set{ _pw_bcode=value;}
			get{return _pw_bcode;}
		}
		/// <summary>
		/// 开单业务员
		/// </summary>
		public string PW_SalesMan
		{
			set{ _pw_salesman=value;}
			get{return _pw_salesman;}
		}
		/// <summary>
		/// 操作员
		/// </summary>
		public string PW_Operation
		{
			set{ _pw_operation=value;}
			get{return _pw_operation;}
		}
		/// <summary>
		/// 审核员
		/// </summary>
		public string PW_AuditMan
		{
			set{ _pw_auditman=value;}
			get{return _pw_auditman;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? PW_Date
		{
			set{ _pw_date=value;}
			get{return _pw_date;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string PW_Remark
		{
			set{ _pw_remark=value;}
			get{return _pw_remark;}
		}
		/// <summary>
		/// 审核状态
		/// </summary>
		public int? PW_AuditStatus
		{
			set{ _pw_auditstatus=value;}
			get{return _pw_auditstatus;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string PW_Satetyone
		{
			set{ _pw_satetyone=value;}
			get{return _pw_satetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string PW_Satetytwo
		{
			set{ _pw_satetytwo=value;}
			get{return _pw_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? PW_Clear
		{
			set{ _pw_clear=value;}
			get{return _pw_clear;}
		}
		#endregion Model

	}
}


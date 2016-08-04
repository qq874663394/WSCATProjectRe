using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OtherCost
	{
		public OtherCost()
		{}
		#region Model
		private int _oc_id;
		private string _oc_code;
		private int? _oc_type;
		private string _oc_sucode;
		private string _oc_clientcode;
		private string _oc_accountcode;
		private DateTime? _oc_date;
		private string _oc_salescode;
		private string _oc_salesman;
		private string _oc_operation;
		private string _oc_auditman;
		private string _oc_abstracts;
		private int? _oc_clear;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int OC_ID
		{
			set{ _oc_id=value;}
			get{return _oc_id;}
		}
		/// <summary>
		/// 费用单单号
		/// </summary>
		public string OC_Code
		{
			set{ _oc_code=value;}
			get{return _oc_code;}
		}
		/// <summary>
		/// 单据类型
		/// </summary>
		public int? OC_Type
		{
			set{ _oc_type=value;}
			get{return _oc_type;}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string OC_SuCode
		{
			set{ _oc_sucode=value;}
			get{return _oc_sucode;}
		}
		/// <summary>
		/// 客户编号
		/// </summary>
		public string OC_ClientCode
		{
			set{ _oc_clientcode=value;}
			get{return _oc_clientcode;}
		}
		/// <summary>
		/// 账户编号
		/// </summary>
		public string OC_AccountCode
		{
			set{ _oc_accountcode=value;}
			get{return _oc_accountcode;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? OC_Date
		{
			set{ _oc_date=value;}
			get{return _oc_date;}
		}
		/// <summary>
		/// 业务员编号
		/// </summary>
		public string OC_SalesCode
		{
			set{ _oc_salescode=value;}
			get{return _oc_salescode;}
		}
		/// <summary>
		/// 业务员名称
		/// </summary>
		public string OC_SalesMan
		{
			set{ _oc_salesman=value;}
			get{return _oc_salesman;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string OC_Operation
		{
			set{ _oc_operation=value;}
			get{return _oc_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string OC_AuditMan
		{
			set{ _oc_auditman=value;}
			get{return _oc_auditman;}
		}
		/// <summary>
		/// 摘要
		/// </summary>
		public string OC_Abstracts
		{
			set{ _oc_abstracts=value;}
			get{return _oc_abstracts;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? OC_Clear
		{
			set{ _oc_clear=value;}
			get{return _oc_clear;}
		}
		#endregion Model

	}
}


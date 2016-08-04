using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OtherInCost
	{
		public OtherInCost()
		{}
		#region Model
		private int _oic_id;
		private string _oic_code;
		private int? _oic_type;
		private string _oic_sucode;
		private string _oic_clientcode;
		private string _oic_accountcode;
		private DateTime? _oic_date= DateTime.Now;
		private string _oic_salescode;
		private string _oic_salesman;
		private string _oic_operation;
		private string _oic_auditman;
		private string _oic_abstracts;
		private int? _oic_clear=1;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int OIC_ID
		{
			set{ _oic_id=value;}
			get{return _oic_id;}
		}
		/// <summary>
		/// 费用单单号
		/// </summary>
		public string OIC_Code
		{
			set{ _oic_code=value;}
			get{return _oic_code;}
		}
		/// <summary>
		/// 单据类型
		/// </summary>
		public int? OIC_Type
		{
			set{ _oic_type=value;}
			get{return _oic_type;}
		}
		/// <summary>
		/// 供应商编码
		/// </summary>
		public string OIC_SuCode
		{
			set{ _oic_sucode=value;}
			get{return _oic_sucode;}
		}
		/// <summary>
		/// 客户编码
		/// </summary>
		public string OIC_ClientCode
		{
			set{ _oic_clientcode=value;}
			get{return _oic_clientcode;}
		}
		/// <summary>
		/// 账户编码
		/// </summary>
		public string OIC_AccountCode
		{
			set{ _oic_accountcode=value;}
			get{return _oic_accountcode;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? OIC_Date
		{
			set{ _oic_date=value;}
			get{return _oic_date;}
		}
		/// <summary>
		/// 业务员编号
		/// </summary>
		public string OIC_SalesCode
		{
			set{ _oic_salescode=value;}
			get{return _oic_salescode;}
		}
		/// <summary>
		/// 业务员名称
		/// </summary>
		public string OIC_SalesMan
		{
			set{ _oic_salesman=value;}
			get{return _oic_salesman;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string OIC_Operation
		{
			set{ _oic_operation=value;}
			get{return _oic_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string OIC_AuditMan
		{
			set{ _oic_auditman=value;}
			get{return _oic_auditman;}
		}
		/// <summary>
		/// 摘要
		/// </summary>
		public string OIC_Abstracts
		{
			set{ _oic_abstracts=value;}
			get{return _oic_abstracts;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? OIC_Clear
		{
			set{ _oic_clear=value;}
			get{return _oic_clear;}
		}
		#endregion Model

	}
}


using System;
namespace Model
{
	/// <summary>
	/// 客户类别表
	/// </summary>
	[Serializable]
	public partial class ConllectionWait
	{
		public ConllectionWait()
		{}
		#region Model
		private int _cw_id;
		private string _cw_code;
		private string _cw_clientcode;
		private string _cw_clientname;
		private string _cw_accountcode;
		private string _cw_sellcode;
		private string _cw_salesman;
		private string _cw_operation;
		private string _cw_auditman;
		private DateTime? _cw_date;
		private string _cw_remark;
		private int? _cw_auditstatus;
		private string _cw_satetyone;
		private string _cw_satetytwo;
		private int? _cw_clear;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int CW_ID
		{
			set{ _cw_id=value;}
			get{return _cw_id;}
		}
		/// <summary>
		/// 待收款单单号
		/// </summary>
		public string CW_Code
		{
			set{ _cw_code=value;}
			get{return _cw_code;}
		}
		/// <summary>
		/// 客户编号
		/// </summary>
		public string CW_ClientCode
		{
			set{ _cw_clientcode=value;}
			get{return _cw_clientcode;}
		}
		/// <summary>
		/// 客户名称
		/// </summary>
		public string CW_ClientName
		{
			set{ _cw_clientname=value;}
			get{return _cw_clientname;}
		}
		/// <summary>
		/// 账户编号
		/// </summary>
		public string CW_AccountCode
		{
			set{ _cw_accountcode=value;}
			get{return _cw_accountcode;}
		}
		/// <summary>
		/// 所属销售单编号
		/// </summary>
		public string CW_SellCode
		{
			set{ _cw_sellcode=value;}
			get{return _cw_sellcode;}
		}
		/// <summary>
		/// 开单业务员
		/// </summary>
		public string CW_SalesMan
		{
			set{ _cw_salesman=value;}
			get{return _cw_salesman;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string CW_Operation
		{
			set{ _cw_operation=value;}
			get{return _cw_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string CW_AuditMan
		{
			set{ _cw_auditman=value;}
			get{return _cw_auditman;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? CW_Date
		{
			set{ _cw_date=value;}
			get{return _cw_date;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string CW_Remark
		{
			set{ _cw_remark=value;}
			get{return _cw_remark;}
		}
		/// <summary>
		/// 审核状态
		/// </summary>
		public int? CW_AuditStatus
		{
			set{ _cw_auditstatus=value;}
			get{return _cw_auditstatus;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string CW_Satetyone
		{
			set{ _cw_satetyone=value;}
			get{return _cw_satetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string CW_Satetytwo
		{
			set{ _cw_satetytwo=value;}
			get{return _cw_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? CW_Clear
		{
			set{ _cw_clear=value;}
			get{return _cw_clear;}
		}
		#endregion Model

	}
}


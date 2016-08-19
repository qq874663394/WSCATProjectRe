using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class BuyCancel
	{
		public BuyCancel()
		{}
		#region Model
		private int _ca_id;
		private string _ca_code;
		private string _ca_stockcode;
		private string _ca_stockname;
		private DateTime? _ca_date= DateTime.Now;
		private int? _ca_returnstatus=0;
		private int? _ca_auditstatus=0;
		private string _ca_salesman;
		private string _ca_operation;
		private string _ca_auditman;
		private string _ca_remark;
		private string _ca_satetyone;
		private string _ca_satetytwo;
		private int? _ca_clear=1;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Ca_ID
		{
			set{ _ca_id=value;}
			get{return _ca_id;}
		}
		/// <summary>
		/// 退货单号（生成）
		/// </summary>
		public string Ca_Code
		{
			set{ _ca_code=value;}
			get{return _ca_code;}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string Ca_StockCode
		{
			set{ _ca_stockcode=value;}
			get{return _ca_stockcode;}
		}
		/// <summary>
		/// 供应商名称
		/// </summary>
		public string Ca_StockName
		{
			set{ _ca_stockname=value;}
			get{return _ca_stockname;}
		}
		/// <summary>
		/// 退货日期
		/// </summary>
		public DateTime? Ca_Date
		{
			set{ _ca_date=value;}
			get{return _ca_date;}
		}
		/// <summary>
		/// 是否已完成,1已完成,0未完成
		/// </summary>
		public int? Ca_ReturnStatus
		{
			set{ _ca_returnstatus=value;}
			get{return _ca_returnstatus;}
		}
		/// <summary>
		/// 是否已完成,1已完成,0未完成
		/// </summary>
		public int? Ca_AuditStatus
		{
			set{ _ca_auditstatus=value;}
			get{return _ca_auditstatus;}
		}
		/// <summary>
		/// 业务员
		/// </summary>
		public string Ca_SalesMan
		{
			set{ _ca_salesman=value;}
			get{return _ca_salesman;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string Ca_Operation
		{
			set{ _ca_operation=value;}
			get{return _ca_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Ca_Auditman
		{
			set{ _ca_auditman=value;}
			get{return _ca_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Ca_Remark
		{
			set{ _ca_remark=value;}
			get{return _ca_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Ca_Satetyone
		{
			set{ _ca_satetyone=value;}
			get{return _ca_satetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Ca_Satetytwo
		{
			set{ _ca_satetytwo=value;}
			get{return _ca_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Ca_Clear
		{
			set{ _ca_clear=value;}
			get{return _ca_clear;}
		}
		#endregion Model

	}
}


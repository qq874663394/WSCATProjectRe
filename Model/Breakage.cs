using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class Breakage
	{
		public Breakage()
		{}
		#region Model
		private int _bre_id;
		private string _bre_code;
		private string _bre_stockcode;
		private string _bre_stockname;
		private string _bre_date;
		private string _bre_operation;
		private string _bre_auditman;
		private string _bre_remark;
		private string _bre_satetyone;
		private string _bre_satetytwo;
		private int? _bre_clear=1;
		/// <summary>
		/// 
		/// </summary>
		public int Bre_ID
		{
			set{ _bre_id=value;}
			get{return _bre_id;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Bre_Code
		{
			set{ _bre_code=value;}
			get{return _bre_code;}
		}
		/// <summary>
		/// 仓库编号
		/// </summary>
		public string Bre_StockCode
		{
			set{ _bre_stockcode=value;}
			get{return _bre_stockcode;}
		}
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string Bre_StockName
		{
			set{ _bre_stockname=value;}
			get{return _bre_stockname;}
		}
		/// <summary>
		/// 报损日期
		/// </summary>
		public string Bre_Date
		{
			set{ _bre_date=value;}
			get{return _bre_date;}
		}
		/// <summary>
		/// 报损人
		/// </summary>
		public string Bre_Operation
		{
			set{ _bre_operation=value;}
			get{return _bre_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Bre_Auditman
		{
			set{ _bre_auditman=value;}
			get{return _bre_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Bre_Remark
		{
			set{ _bre_remark=value;}
			get{return _bre_remark;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Bre_Satetyone
		{
			set{ _bre_satetyone=value;}
			get{return _bre_satetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Bre_Satetytwo
		{
			set{ _bre_satetytwo=value;}
			get{return _bre_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Bre_Clear
		{
			set{ _bre_clear=value;}
			get{return _bre_clear;}
		}
		#endregion Model

	}
}


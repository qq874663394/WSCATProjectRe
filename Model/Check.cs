using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class Check
	{
		public Check()
		{}
		#region Model
		private int _che_id;
		private string _che_code;
		private string _che_stockid;
		private string _che_stockname;
		private DateTime? _che_date;
		private string _che_operation;
		private string _che_auditman;
		private string _che_remark;
		private string _che_satetyone;
		private string _che_satetytwo;
		private int? _che_clear;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Che_ID
		{
			set{ _che_id=value;}
			get{return _che_id;}
		}
		/// <summary>
		/// 盘点单号（生成）
		/// </summary>
		public string Che_Code
		{
			set{ _che_code=value;}
			get{return _che_code;}
		}
		/// <summary>
		/// 仓库编号
		/// </summary>
		public string Che_StockID
		{
			set{ _che_stockid=value;}
			get{return _che_stockid;}
		}
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string Che_StockName
		{
			set{ _che_stockname=value;}
			get{return _che_stockname;}
		}
		/// <summary>
		/// 盘点日期
		/// </summary>
		public DateTime? Che_Date
		{
			set{ _che_date=value;}
			get{return _che_date;}
		}
		/// <summary>
		/// 盘点人
		/// </summary>
		public string Che_Operation
		{
			set{ _che_operation=value;}
			get{return _che_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Che_Auditman
		{
			set{ _che_auditman=value;}
			get{return _che_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Che_Remark
		{
			set{ _che_remark=value;}
			get{return _che_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Che_Satetyone
		{
			set{ _che_satetyone=value;}
			get{return _che_satetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Che_Satetytwo
		{
			set{ _che_satetytwo=value;}
			get{return _che_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Che_Clear
		{
			set{ _che_clear=value;}
			get{return _che_clear;}
		}
		#endregion Model

	}
}


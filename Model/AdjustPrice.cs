using System;
namespace Model
{
	/// <summary>
	/// AdjustPrice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdjustPrice
	{
		public AdjustPrice()
		{}
		#region Model
		private int _adj_id;
		private string _adj_code;
		private string _adj_stockid;
		private string _adj_stockname;
		private DateTime? _adj_date;
		private string _adj_operation;
		private string _adj_auditman;
		private string _adj_remark;
		private string _adj_satetyone;
		private string _adj_satetytwo;
		private int? _adj_clear=1;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Adj_ID
		{
			set{ _adj_id=value;}
			get{return _adj_id;}
		}
		/// <summary>
		/// 调价单号（生成）
		/// </summary>
		public string Adj_Code
		{
			set{ _adj_code=value;}
			get{return _adj_code;}
		}
		/// <summary>
		/// 仓库编号
		/// </summary>
		public string Adj_StockID
		{
			set{ _adj_stockid=value;}
			get{return _adj_stockid;}
		}
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string Adj_StockName
		{
			set{ _adj_stockname=value;}
			get{return _adj_stockname;}
		}
		/// <summary>
		/// 调价日期
		/// </summary>
		public DateTime? Adj_Date
		{
			set{ _adj_date=value;}
			get{return _adj_date;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string Adj_Operation
		{
			set{ _adj_operation=value;}
			get{return _adj_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Adj_Auditman
		{
			set{ _adj_auditman=value;}
			get{return _adj_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Adj_Remark
		{
			set{ _adj_remark=value;}
			get{return _adj_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Adj_Satetyone
		{
			set{ _adj_satetyone=value;}
			get{return _adj_satetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Adj_Satetytwo
		{
			set{ _adj_satetytwo=value;}
			get{return _adj_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Adj_Clear
		{
			set{ _adj_clear=value;}
			get{return _adj_clear;}
		}
		#endregion Model

	}
}


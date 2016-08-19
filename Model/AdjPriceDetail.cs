using System;
namespace Model
{
	/// <summary>
	/// AdjPriceDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdjPriceDetail
	{
		public AdjPriceDetail()
		{}
		#region Model
		private string _adj_id;
		private int _adj_lineno;
		private string _adj_maid;
		private string _adj_maname;
		private string _adj_model;
		private string _adj_unit;
		private string _adj_curprice;
		private string _adj_scale;
		private string _adj_price;
		private string _adj_lostmoney;
		private string _adj_cause;
		private int? _adj_clear;
		private string _adj_safetyone;
		private string _adj_safetytwo;
		private string _adj_remark;
		/// <summary>
		/// 调价编号
		/// </summary>
		public string Adj_ID
		{
			set{ _adj_id=value;}
			get{return _adj_id;}
		}
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Adj_Lineno
		{
			set{ _adj_lineno=value;}
			get{return _adj_lineno;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Adj_MaID
		{
			set{ _adj_maid=value;}
			get{return _adj_maid;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Adj_MaName
		{
			set{ _adj_maname=value;}
			get{return _adj_maname;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Adj_Model
		{
			set{ _adj_model=value;}
			get{return _adj_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Adj_Unit
		{
			set{ _adj_unit=value;}
			get{return _adj_unit;}
		}
		/// <summary>
		/// 调前单价
		/// </summary>
		public string Adj_CurPrice
		{
			set{ _adj_curprice=value;}
			get{return _adj_curprice;}
		}
		/// <summary>
		/// 调价比例
		/// </summary>
		public string Adj_Scale
		{
			set{ _adj_scale=value;}
			get{return _adj_scale;}
		}
		/// <summary>
		/// 调后单价
		/// </summary>
		public string Adj_Price
		{
			set{ _adj_price=value;}
			get{return _adj_price;}
		}
		/// <summary>
		/// 差额
		/// </summary>
		public string Adj_LostMoney
		{
			set{ _adj_lostmoney=value;}
			get{return _adj_lostmoney;}
		}
		/// <summary>
		/// 原因
		/// </summary>
		public string Adj_Cause
		{
			set{ _adj_cause=value;}
			get{return _adj_cause;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Adj_Clear
		{
			set{ _adj_clear=value;}
			get{return _adj_clear;}
		}
		/// <summary>
		/// 预留字段
		/// </summary>
		public string Adj_Safetyone
		{
			set{ _adj_safetyone=value;}
			get{return _adj_safetyone;}
		}
		/// <summary>
		/// 预留字段
		/// </summary>
		public string Adj_Safetytwo
		{
			set{ _adj_safetytwo=value;}
			get{return _adj_safetytwo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Adj_Remark
		{
			set{ _adj_remark=value;}
			get{return _adj_remark;}
		}
		#endregion Model

	}
}


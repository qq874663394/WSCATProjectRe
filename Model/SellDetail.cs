using System;
namespace Model
{
	/// <summary>
	/// 销售订单明细表
	/// </summary>
	[Serializable]
	public partial class SellDetail
	{
		public SellDetail()
		{}
		#region Model
		private string _sell_code;
		private int _sell_lineno;
		private string _sell_maid;
		private string _sell_maname;
		private string _sell_model;
		private string _sell_unit;
		private string _sell_curnumber;
		private int? _sell_clear=1;
		private string _sell_safetyone;
		private string _sell_safetytwo;
		private string _sell_remark;
		/// <summary>
		/// 销售订单编号
		/// </summary>
		public string Sell_Code
		{
			set{ _sell_code=value;}
			get{return _sell_code;}
		}
		/// <summary>
		/// 栏号(自增)ID
		/// </summary>
		public int Sell_Lineno
		{
			set{ _sell_lineno=value;}
			get{return _sell_lineno;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Sell_MaID
		{
			set{ _sell_maid=value;}
			get{return _sell_maid;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Sell_MaName
		{
			set{ _sell_maname=value;}
			get{return _sell_maname;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Sell_Model
		{
			set{ _sell_model=value;}
			get{return _sell_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Sell_Unit
		{
			set{ _sell_unit=value;}
			get{return _sell_unit;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public string Sell_CurNumber
		{
			set{ _sell_curnumber=value;}
			get{return _sell_curnumber;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Sell_Clear
		{
			set{ _sell_clear=value;}
			get{return _sell_clear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sell_Safetyone
		{
			set{ _sell_safetyone=value;}
			get{return _sell_safetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Sell_Safetytwo
		{
			set{ _sell_safetytwo=value;}
			get{return _sell_safetytwo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Sell_Remark
		{
			set{ _sell_remark=value;}
			get{return _sell_remark;}
		}
		#endregion Model

	}
}


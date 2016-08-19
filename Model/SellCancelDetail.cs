using System;
namespace Model
{
	/// <summary>
	/// 退货明细表
	/// </summary>
	[Serializable]
	public partial class SellCancelDetail
	{
		public SellCancelDetail()
		{}
		#region Model
		private int _ca_lineno;
		private string _ca_code;
		private string _ca_macode;
		private string _ca_maname;
		private string _ca_model;
		private string _ca_unit;
		private string _ca_curnumber;
		private string _ca_afterprice;
		private string _ca_discount;
		private string _ca_beforediscount;
		private string _ca_price;
		private int? _ca_clear=1;
		private string _ca_safetyone;
		private string _ca_safetytwo;
		private string _ca_remark;
		/// <summary>
		/// 栏号(自增)
		/// </summary>
		public int Ca_Lineno
		{
			set{ _ca_lineno=value;}
			get{return _ca_lineno;}
		}
		/// <summary>
		/// 主表编号
		/// </summary>
		public string Ca_Code
		{
			set{ _ca_code=value;}
			get{return _ca_code;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Ca_MaCode
		{
			set{ _ca_macode=value;}
			get{return _ca_macode;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Ca_MaName
		{
			set{ _ca_maname=value;}
			get{return _ca_maname;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Ca_Model
		{
			set{ _ca_model=value;}
			get{return _ca_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Ca_Unit
		{
			set{ _ca_unit=value;}
			get{return _ca_unit;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public string Ca_CurNumber
		{
			set{ _ca_curnumber=value;}
			get{return _ca_curnumber;}
		}
		/// <summary>
		/// 折扣后的单价
		/// </summary>
		public string Ca_AfterPrice
		{
			set{ _ca_afterprice=value;}
			get{return _ca_afterprice;}
		}
		/// <summary>
		/// 折扣
		/// </summary>
		public string Ca_Discount
		{
			set{ _ca_discount=value;}
			get{return _ca_discount;}
		}
		/// <summary>
		/// 折扣前单价
		/// </summary>
		public string Ca_BeforeDiscount
		{
			set{ _ca_beforediscount=value;}
			get{return _ca_beforediscount;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string Ca_Price
		{
			set{ _ca_price=value;}
			get{return _ca_price;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Ca_Clear
		{
			set{ _ca_clear=value;}
			get{return _ca_clear;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Ca_Safetyone
		{
			set{ _ca_safetyone=value;}
			get{return _ca_safetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Ca_Safetytwo
		{
			set{ _ca_safetytwo=value;}
			get{return _ca_safetytwo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Ca_Remark
		{
			set{ _ca_remark=value;}
			get{return _ca_remark;}
		}
		#endregion Model

	}
}


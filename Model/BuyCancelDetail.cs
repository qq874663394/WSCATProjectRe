using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class BuyCancelDetail
	{
		public BuyCancelDetail()
		{}
		#region Model
		private int _ca_lineno;
		private string _ca_id;
		private string _ca_maid;
		private string _ca_maname;
		private string _ca_model;
		private string _ca_unit;
		private string _ca_curnumber;
		private int? _ca_clear=1;
		private string _ca_safetyone;
		private string _ca_safetytwo;
		private string _ca_remark;
		private string _ca_discountaprice;
		private string _ca_discount;
		private string _ca_discountbprice;
		private string _ca_amountmoney;
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
		public string Ca_ID
		{
			set{ _ca_id=value;}
			get{return _ca_id;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Ca_MaID
		{
			set{ _ca_maid=value;}
			get{return _ca_maid;}
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
		/// <summary>
		/// 单价(折扣后)
		/// </summary>
		public string Ca_DiscountAPrice
		{
			set{ _ca_discountaprice=value;}
			get{return _ca_discountaprice;}
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
		public string Ca_DiscountBPrice
		{
			set{ _ca_discountbprice=value;}
			get{return _ca_discountbprice;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string Ca_AmountMoney
		{
			set{ _ca_amountmoney=value;}
			get{return _ca_amountmoney;}
		}
		#endregion Model

	}
}


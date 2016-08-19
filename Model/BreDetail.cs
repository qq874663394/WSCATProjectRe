using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class BreDetail
	{
		public BreDetail()
		{}
		#region Model
		private string _che_id;
		private int _che_lineno;
		private string _che_maid;
		private string _che_maname;
		private string _che_model;
		private string _che_unit;
		private string _che_curqty;
		private string _che_checkqty;
		private string _che_lostqty;
		private string _che_price;
		private string _che_lostmoney;
		private string _che_cause;
		private int? _che_clear;
		private string _che_safetyone;
		private string _che_safetytwo;
		private string _che_remark;
		/// <summary>
		/// 报损编号
		/// </summary>
		public string Che_ID
		{
			set{ _che_id=value;}
			get{return _che_id;}
		}
		/// <summary>
		/// 栏号(自增)
		/// </summary>
		public int Che_Lineno
		{
			set{ _che_lineno=value;}
			get{return _che_lineno;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Che_MaID
		{
			set{ _che_maid=value;}
			get{return _che_maid;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Che_MaName
		{
			set{ _che_maname=value;}
			get{return _che_maname;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Che_Model
		{
			set{ _che_model=value;}
			get{return _che_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Che_Unit
		{
			set{ _che_unit=value;}
			get{return _che_unit;}
		}
		/// <summary>
		/// 现有数量
		/// </summary>
		public string Che_CurQty
		{
			set{ _che_curqty=value;}
			get{return _che_curqty;}
		}
		/// <summary>
		/// 损坏数量
		/// </summary>
		public string Che_CheckQty
		{
			set{ _che_checkqty=value;}
			get{return _che_checkqty;}
		}
		/// <summary>
		/// 剩余数量
		/// </summary>
		public string Che_LostQty
		{
			set{ _che_lostqty=value;}
			get{return _che_lostqty;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public string Che_Price
		{
			set{ _che_price=value;}
			get{return _che_price;}
		}
		/// <summary>
		/// 盈亏金额
		/// </summary>
		public string Che_LostMoney
		{
			set{ _che_lostmoney=value;}
			get{return _che_lostmoney;}
		}
		/// <summary>
		/// 原因
		/// </summary>
		public string Che_Cause
		{
			set{ _che_cause=value;}
			get{return _che_cause;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Che_Clear
		{
			set{ _che_clear=value;}
			get{return _che_clear;}
		}
		/// <summary>
		/// 预留字段
		/// </summary>
		public string Che_Safetyone
		{
			set{ _che_safetyone=value;}
			get{return _che_safetyone;}
		}
		/// <summary>
		/// 预留字段
		/// </summary>
		public string Che_Safetytwo
		{
			set{ _che_safetytwo=value;}
			get{return _che_safetytwo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Che_Remark
		{
			set{ _che_remark=value;}
			get{return _che_remark;}
		}
		#endregion Model

	}
}


using System;
namespace Model
{
	/// <summary>
	/// 客户类别表
	/// </summary>
	[Serializable]
	public partial class ComeDetail
	{
		public ComeDetail()
		{}
		#region Model
		private string _come_id;
		private int _come_llineno;
		private string _come_name;
		private string _come_model;
		private string _come_unit;
		private string _come_number;
		private string _come_price;
		private string _come_money;
		private string _come_remark;
		private string _come_safetyone;
		private string _come_safetytwo;
		private int? _come_clear;
		private string _come_barcode;
		private string _come_rfid;
		/// <summary>
		/// 入库单号
		/// </summary>
		public string Come_ID
		{
			set{ _come_id=value;}
			get{return _come_id;}
		}
		/// <summary>
		/// 栏号(自增)
		/// </summary>
		public int Come_Llineno
		{
			set{ _come_llineno=value;}
			get{return _come_llineno;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Come_Name
		{
			set{ _come_name=value;}
			get{return _come_name;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Come_Model
		{
			set{ _come_model=value;}
			get{return _come_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Come_Unit
		{
			set{ _come_unit=value;}
			get{return _come_unit;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public string Come_Number
		{
			set{ _come_number=value;}
			get{return _come_number;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public string Come_Price
		{
			set{ _come_price=value;}
			get{return _come_price;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string Come_Money
		{
			set{ _come_money=value;}
			get{return _come_money;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Come_Remark
		{
			set{ _come_remark=value;}
			get{return _come_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Come_Safetyone
		{
			set{ _come_safetyone=value;}
			get{return _come_safetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Come_Safetytwo
		{
			set{ _come_safetytwo=value;}
			get{return _come_safetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Come_Clear
		{
			set{ _come_clear=value;}
			get{return _come_clear;}
		}
		/// <summary>
		/// 条码
		/// </summary>
		public string Come_barcode
		{
			set{ _come_barcode=value;}
			get{return _come_barcode;}
		}
		/// <summary>
		/// RFID
		/// </summary>
		public string Come_rfid
		{
			set{ _come_rfid=value;}
			get{return _come_rfid;}
		}
		#endregion Model

	}
}


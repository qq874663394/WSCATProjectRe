using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OutDetail
	{
		public OutDetail()
		{}
		#region Model
		private string _out_id;
		private int _out_lineno;
		private string _out_maid;
		private string _out_maname;
		private string _out_model;
		private string _out_unit;
		private string _out_number;
		private string _out_price;
		private string _out_money;
		private string _out_satetyone;
		private string _out_satetytwo;
		private int? _out_clear;
		private string _out_barcode;
		private string _out_rfid;
		/// <summary>
		/// 出库编号
		/// </summary>
		public string Out_ID
		{
			set{ _out_id=value;}
			get{return _out_id;}
		}
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Out_Lineno
		{
			set{ _out_lineno=value;}
			get{return _out_lineno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_MaID
		{
			set{ _out_maid=value;}
			get{return _out_maid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_MaName
		{
			set{ _out_maname=value;}
			get{return _out_maname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Model
		{
			set{ _out_model=value;}
			get{return _out_model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Unit
		{
			set{ _out_unit=value;}
			get{return _out_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Number
		{
			set{ _out_number=value;}
			get{return _out_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Price
		{
			set{ _out_price=value;}
			get{return _out_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Money
		{
			set{ _out_money=value;}
			get{return _out_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Satetyone
		{
			set{ _out_satetyone=value;}
			get{return _out_satetyone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_Satetytwo
		{
			set{ _out_satetytwo=value;}
			get{return _out_satetytwo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Out_Clear
		{
			set{ _out_clear=value;}
			get{return _out_clear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_barcode
		{
			set{ _out_barcode=value;}
			get{return _out_barcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Out_rfid
		{
			set{ _out_rfid=value;}
			get{return _out_rfid;}
		}
		#endregion Model

	}
}


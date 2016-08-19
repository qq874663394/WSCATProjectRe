using System;
namespace Model
{
	/// <summary>
	/// 单据编码表
	/// </summary>
	[Serializable]
	public partial class StockDetail
	{
		public StockDetail()
		{}
		#region Model
		private string _sto_id;
		private int _sto_lineno;
		private string _sto_maid;
		private string _sto_macode;
		private string _sto_maname;
		private string _sto_mamodel;
		private string _sto_number;
		private string _sto_price;
		private string _sto_money;
		private DateTime? _sto_date;
		private string _sto_storage;
		private string _sto_stoid;
		private string _sto_static;
		private int? _sto_clear;
		private string _sto_remark;
		private string _sto_safetyone;
		private string _sto_safetytwo;
		/// <summary>
		/// 库存编号
		/// </summary>
		public string Sto_ID
		{
			set{ _sto_id=value;}
			get{return _sto_id;}
		}
		/// <summary>
		/// 栏号(自增)
		/// </summary>
		public int Sto_Lineno
		{
			set{ _sto_lineno=value;}
			get{return _sto_lineno;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Sto_MaID
		{
			set{ _sto_maid=value;}
			get{return _sto_maid;}
		}
		/// <summary>
		/// 物料编码
		/// </summary>
		public string Sto_MaCode
		{
			set{ _sto_macode=value;}
			get{return _sto_macode;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Sto_MaName
		{
			set{ _sto_maname=value;}
			get{return _sto_maname;}
		}
		/// <summary>
		/// 物料规格型号
		/// </summary>
		public string Sto_MaModel
		{
			set{ _sto_mamodel=value;}
			get{return _sto_mamodel;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public string Sto_Number
		{
			set{ _sto_number=value;}
			get{return _sto_number;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public string Sto_Price
		{
			set{ _sto_price=value;}
			get{return _sto_price;}
		}
		/// <summary>
		/// 总计金额
		/// </summary>
		public string Sto_Money
		{
			set{ _sto_money=value;}
			get{return _sto_money;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? Sto_Date
		{
			set{ _sto_date=value;}
			get{return _sto_date;}
		}
		/// <summary>
		/// 仓库名
		/// </summary>
		public string Sto_Storage
		{
			set{ _sto_storage=value;}
			get{return _sto_storage;}
		}
		/// <summary>
		/// 仓库ID
		/// </summary>
		public string Sto_StoID
		{
			set{ _sto_stoid=value;}
			get{return _sto_stoid;}
		}
		/// <summary>
		/// 操作类型
		/// </summary>
		public string Sto_Static
		{
			set{ _sto_static=value;}
			get{return _sto_static;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Sto_Clear
		{
			set{ _sto_clear=value;}
			get{return _sto_clear;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Sto_Remark
		{
			set{ _sto_remark=value;}
			get{return _sto_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Sto_Safetyone
		{
			set{ _sto_safetyone=value;}
			get{return _sto_safetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Sto_Safetytwo
		{
			set{ _sto_safetytwo=value;}
			get{return _sto_safetytwo;}
		}
		#endregion Model

	}
}


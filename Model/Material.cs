using System;
namespace Model
{
	/// <summary>
	/// 物料信息表
	/// </summary>
	[Serializable]
	public partial class Material
	{
		public Material()
		{}
		#region Model
		private int _ma_id;
		private string _ma_picname;
		private string _ma_name;
		private string _ma_model;
		private string _ma_rfid;
		private string _ma_barcode;
		private string _ma_code;
		private string _ma_typeid;
		private string _ma_typename;
		private string _ma_price;
		private string _ma_pricea;
		private string _ma_priceb;
		private string _ma_pricec;
		private string _ma_priced;
		private string _ma_pricee;
		private DateTime? _ma_createdate= DateTime.Now;
		private string _ma_supplier;
		private string _ma_supid;
		private string _ma_zhujima;
		private string _ma_unit;
		private string _ma_inprice;
		private DateTime? _ma_indate;
		private string _ma_remark;
		private int? _ma_enable=1;
		private int? _ma_clear=1;
		private string _ma_safeyone;
		private string _ma_safetytwo;
		/// <summary>
		/// 
		/// </summary>
		public int Ma_ID
		{
			set{ _ma_id=value;}
			get{return _ma_id;}
		}
		/// <summary>
		/// 物料图片名称
		/// </summary>
		public string Ma_PicName
		{
			set{ _ma_picname=value;}
			get{return _ma_picname;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Ma_Name
		{
			set{ _ma_name=value;}
			get{return _ma_name;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Ma_Model
		{
			set{ _ma_model=value;}
			get{return _ma_model;}
		}
		/// <summary>
		/// RFID
		/// </summary>
		public string Ma_RFID
		{
			set{ _ma_rfid=value;}
			get{return _ma_rfid;}
		}
		/// <summary>
		/// 条码
		/// </summary>
		public string Ma_Barcode
		{
			set{ _ma_barcode=value;}
			get{return _ma_barcode;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Ma_Code
		{
			set{ _ma_code=value;}
			get{return _ma_code;}
		}
		/// <summary>
		/// 类别ID
		/// </summary>
		public string Ma_TypeID
		{
			set{ _ma_typeid=value;}
			get{return _ma_typeid;}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string Ma_TypeName
		{
			set{ _ma_typename=value;}
			get{return _ma_typename;}
		}
		/// <summary>
		/// 建议售价
		/// </summary>
		public string Ma_Price
		{
			set{ _ma_price=value;}
			get{return _ma_price;}
		}
		/// <summary>
		/// 售价A
		/// </summary>
		public string Ma_PriceA
		{
			set{ _ma_pricea=value;}
			get{return _ma_pricea;}
		}
		/// <summary>
		/// 售价B
		/// </summary>
		public string Ma_PriceB
		{
			set{ _ma_priceb=value;}
			get{return _ma_priceb;}
		}
		/// <summary>
		/// 售价C
		/// </summary>
		public string Ma_PriceC
		{
			set{ _ma_pricec=value;}
			get{return _ma_pricec;}
		}
		/// <summary>
		/// D售价
		/// </summary>
		public string Ma_PriceD
		{
			set{ _ma_priced=value;}
			get{return _ma_priced;}
		}
		/// <summary>
		/// 售价E
		/// </summary>
		public string Ma_PriceE
		{
			set{ _ma_pricee=value;}
			get{return _ma_pricee;}
		}
		/// <summary>
		/// 生产日期
		/// </summary>
		public DateTime? Ma_CreateDate
		{
			set{ _ma_createdate=value;}
			get{return _ma_createdate;}
		}
		/// <summary>
		/// 供应商
		/// </summary>
		public string Ma_Supplier
		{
			set{ _ma_supplier=value;}
			get{return _ma_supplier;}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string Ma_SupID
		{
			set{ _ma_supid=value;}
			get{return _ma_supid;}
		}
		/// <summary>
		/// 助记码
		/// </summary>
		public string Ma_zhujima
		{
			set{ _ma_zhujima = value;}
			get{return _ma_zhujima; }
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Ma_Unit
		{
			set{ _ma_unit=value;}
			get{return _ma_unit;}
		}
		/// <summary>
		/// 进价
		/// </summary>
		public string Ma_InPrice
		{
			set{ _ma_inprice=value;}
			get{return _ma_inprice;}
		}
		/// <summary>
		/// 进货时间
		/// </summary>
		public DateTime? Ma_InDate
		{
			set{ _ma_indate=value;}
			get{return _ma_indate;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Ma_Remark
		{
			set{ _ma_remark=value;}
			get{return _ma_remark;}
		}
		/// <summary>
		/// 是否可用
		/// </summary>
		public int? Ma_Enable
		{
			set{ _ma_enable=value;}
			get{return _ma_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Ma_Clear
		{
			set{ _ma_clear=value;}
			get{return _ma_clear;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Ma_Safeyone
		{
			set{ _ma_safeyone=value;}
			get{return _ma_safeyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Ma_Safetytwo
		{
			set{ _ma_safetytwo=value;}
			get{return _ma_safetytwo;}
		}
		#endregion Model

	}
}


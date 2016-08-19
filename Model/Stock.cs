using System;
namespace Model
{
	/// <summary>
	/// 单据编码表
	/// </summary>
	[Serializable]
	public partial class Stock
	{
		public Stock()
		{}
		#region Model
		private int _sto_id;
		private string _sto_maid;
		private string _sto_stname;
		private string _sto_stid;
		private string _sto_ininumber;
		private string _sto_iniprice;
		private string _sto_currentnumber;
		private string _sto_currentprice;
		private string _sto_allnumber;
		private string _sto_allprice;
		private string _sto_enanumber;
		private string _sto_floornumber;
		private int? _sto_clear;
		private string _sto_remark;
		private string _sto_safetyone;
		private string _sto_safetytwo;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Sto_ID
		{
			set{ _sto_id=value;}
			get{return _sto_id;}
		}
		/// <summary>
		/// 物料ID
		/// </summary>
		public string Sto_maID
		{
			set{ _sto_maid=value;}
			get{return _sto_maid;}
		}
		/// <summary>
		/// 仓库名
		/// </summary>
		public string Sto_StName
		{
			set{ _sto_stname=value;}
			get{return _sto_stname;}
		}
		/// <summary>
		/// 仓库ID
		/// </summary>
		public string Sto_StID
		{
			set{ _sto_stid=value;}
			get{return _sto_stid;}
		}
		/// <summary>
		/// 期初数量
		/// </summary>
		public string Sto_IniNumber
		{
			set{ _sto_ininumber=value;}
			get{return _sto_ininumber;}
		}
		/// <summary>
		/// 期初总值
		/// </summary>
		public string Sto_IniPrice
		{
			set{ _sto_iniprice=value;}
			get{return _sto_iniprice;}
		}
		/// <summary>
		/// 本期收入数量
		/// </summary>
		public string Sto_CurrentNumber
		{
			set{ _sto_currentnumber=value;}
			get{return _sto_currentnumber;}
		}
		/// <summary>
		/// 本期收入总值
		/// </summary>
		public string Sto_CurrentPrice
		{
			set{ _sto_currentprice=value;}
			get{return _sto_currentprice;}
		}
		/// <summary>
		/// 现有总数量
		/// </summary>
		public string Sto_AllNumber
		{
			set{ _sto_allnumber=value;}
			get{return _sto_allnumber;}
		}
		/// <summary>
		/// 现有总价值
		/// </summary>
		public string Sto_AllPrice
		{
			set{ _sto_allprice=value;}
			get{return _sto_allprice;}
		}
		/// <summary>
		/// 可用总量
		/// </summary>
		public string Sto_EnaNumber
		{
			set{ _sto_enanumber=value;}
			get{return _sto_enanumber;}
		}
		/// <summary>
		/// 安全数量
		/// </summary>
		public string Sto_FloorNumber
		{
			set{ _sto_floornumber=value;}
			get{return _sto_floornumber;}
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


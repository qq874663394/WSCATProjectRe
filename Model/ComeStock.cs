using System;
namespace Model
{
	/// <summary>
	/// 客户类别表
	/// </summary>
	[Serializable]
	public partial class ComeStock
	{
		public ComeStock()
		{}
		#region Model
		private int _come_id;
		private string _come_code;
		private string _come_type;
		private string _come_stock;
		private string _come_operation;
		private string _come_examine;
		private string _come_remark;
		private string _come_safetyone;
		private string _come_safetytwo;
		private int? _come_clear;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Come_ID
		{
			set{ _come_id=value;}
			get{return _come_id;}
		}
		/// <summary>
		/// 入货单号(生成)
		/// </summary>
		public string Come_Code
		{
			set{ _come_code=value;}
			get{return _come_code;}
		}
		/// <summary>
		/// 入货类型
		/// </summary>
		public string Come_Type
		{
			set{ _come_type=value;}
			get{return _come_type;}
		}
		/// <summary>
		/// 仓库
		/// </summary>
		public string Come_Stock
		{
			set{ _come_stock=value;}
			get{return _come_stock;}
		}
		/// <summary>
		/// 入库员
		/// </summary>
		public string Come_Operation
		{
			set{ _come_operation=value;}
			get{return _come_operation;}
		}
		/// <summary>
		/// 审查人
		/// </summary>
		public string Come_Examine
		{
			set{ _come_examine=value;}
			get{return _come_examine;}
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
		#endregion Model

	}
}


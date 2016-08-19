using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OutStock
	{
		public OutStock()
		{}
		#region Model
		private int _out_id;
		private string _out_code;
		private string _out_type;
		private string _out_stock;
		private string _out_operation;
		private string _out_examine;
		private string _out_remark;
		private string _out_satetyone;
		private string _out_satetytwo;
		private int? _out_clear;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Out_ID
		{
			set{ _out_id=value;}
			get{return _out_id;}
		}
		/// <summary>
		/// 出货单号（生成）
		/// </summary>
		public string Out_Code
		{
			set{ _out_code=value;}
			get{return _out_code;}
		}
		/// <summary>
		/// 出货类型
		/// </summary>
		public string Out_Type
		{
			set{ _out_type=value;}
			get{return _out_type;}
		}
		/// <summary>
		/// 仓库
		/// </summary>
		public string Out_Stock
		{
			set{ _out_stock=value;}
			get{return _out_stock;}
		}
		/// <summary>
		/// 出库员
		/// </summary>
		public string Out_Operation
		{
			set{ _out_operation=value;}
			get{return _out_operation;}
		}
		/// <summary>
		/// 审查人
		/// </summary>
		public string Out_Examine
		{
			set{ _out_examine=value;}
			get{return _out_examine;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Out_Remark
		{
			set{ _out_remark=value;}
			get{return _out_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Out_Satetyone
		{
			set{ _out_satetyone=value;}
			get{return _out_satetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Out_Satetytwo
		{
			set{ _out_satetytwo=value;}
			get{return _out_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Out_Clear
		{
			set{ _out_clear=value;}
			get{return _out_clear;}
		}
		#endregion Model

	}
}


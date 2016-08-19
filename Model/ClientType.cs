using System;
namespace Model
{
	/// <summary>
	/// 客户类别表
	/// </summary>
	[Serializable]
	public partial class ClientType
	{
		public ClientType()
		{}
		#region Model
		private int _ct_id;
		private string _ct_code;
		private string _ct_name;
		private string _ct_remark;
		private string _ct_safetyone;
		private string _ct_safetytwo;
		private int? _ct_enable=1;
		/// <summary>
		/// 
		/// </summary>
		public int CT_ID
		{
			set{ _ct_id=value;}
			get{return _ct_id;}
		}
		/// <summary>
		/// 类型编号
		/// </summary>
		public string CT_Code
		{
			set{ _ct_code=value;}
			get{return _ct_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CT_Name
		{
			set{ _ct_name=value;}
			get{return _ct_name;}
		}
		/// <summary>
		/// 类别备注
		/// </summary>
		public string CT_Remark
		{
			set{ _ct_remark=value;}
			get{return _ct_remark;}
		}
		/// <summary>
		/// 预留1
		/// </summary>
		public string CT_Safetyone
		{
			set{ _ct_safetyone=value;}
			get{return _ct_safetyone;}
		}
		/// <summary>
		/// 预留2
		/// </summary>
		public string CT_Safetytwo
		{
			set{ _ct_safetytwo=value;}
			get{return _ct_safetytwo;}
		}
		/// <summary>
		/// 0为删除1为保留
		/// </summary>
		public int? CT_Enable
		{
			set{ _ct_enable=value;}
			get{return _ct_enable;}
		}
		#endregion Model

	}
}


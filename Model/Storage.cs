using System;
namespace Model
{
	/// <summary>
	/// 仓库表
	/// </summary>
	[Serializable]
	public partial class Storage
	{
		public Storage()
		{}
		#region Model
		private int _st_id;
		private string _st_name;
		private string _st_empname;
		private string _st_phone;
		private string _st_address;
		private int? _st_enable=1;
		private int? _st_clear=1;
		private string _st_remark;
		private string _st_safetyone;
		private string _st_safetytwo;
		private string _st_code;
		/// <summary>
		/// 
		/// </summary>
		public int St_ID
		{
			set{ _st_id=value;}
			get{return _st_id;}
		}
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string St_Name
		{
			set{ _st_name=value;}
			get{return _st_name;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string St_EmpName
		{
			set{ _st_empname=value;}
			get{return _st_empname;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string St_Phone
		{
			set{ _st_phone=value;}
			get{return _st_phone;}
		}
		/// <summary>
		/// 仓库地址
		/// </summary>
		public string St_Address
		{
			set{ _st_address=value;}
			get{return _st_address;}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public int? St_Enable
		{
			set{ _st_enable=value;}
			get{return _st_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? St_Clear
		{
			set{ _st_clear=value;}
			get{return _st_clear;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string St_Remark
		{
			set{ _st_remark=value;}
			get{return _st_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string St_Safetyone
		{
			set{ _st_safetyone=value;}
			get{return _st_safetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string St_Safetytwo
		{
			set{ _st_safetytwo=value;}
			get{return _st_safetytwo;}
		}
		/// <summary>
		/// 仓库编号
		/// </summary>
		public string St_Code
		{
			set{ _st_code=value;}
			get{return _st_code;}
		}
		#endregion Model

	}
}


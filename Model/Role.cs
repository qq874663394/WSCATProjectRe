using System;
namespace Model
{
	/// <summary>
	/// 其他支出项目表
	/// </summary>
	[Serializable]
	public partial class Role
	{
		public Role()
		{}
		#region Model
		private int _role_id;
		private string _role_code;
		private string _role_name;
		private string _role_modules;
		/// <summary>
		/// 
		/// </summary>
		public int Role_ID
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 角色编码
		/// </summary>
		public string Role_Code
		{
			set{ _role_code=value;}
			get{return _role_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Role_Name
		{
			set{ _role_name=value;}
			get{return _role_name;}
		}
		/// <summary>
		/// 能操作的模块，每个模块之间用逗号分割
		/// </summary>
		public string Role_Modules
		{
			set{ _role_modules=value;}
			get{return _role_modules;}
		}
		#endregion Model

	}
}


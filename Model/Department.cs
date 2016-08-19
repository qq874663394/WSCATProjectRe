using System;
namespace Model
{
	/// <summary>
	/// 人员类别表
	/// </summary>
	[Serializable]
	public partial class Department
	{
		public Department()
		{}
		#region Model
		private int _dt_id;
		private string _dt_code;
		private string _dt_rolecode;
		private string _dt_name;
		private int? _dt_clear=1;
		/// <summary>
		/// 
		/// </summary>
		public int Dt_ID
		{
			set{ _dt_id=value;}
			get{return _dt_id;}
		}
		/// <summary>
		/// 类型编号
		/// </summary>
		public string Dt_Code
		{
			set{ _dt_code=value;}
			get{return _dt_code;}
		}
		/// <summary>
		/// 角色编号
		/// </summary>
		public string Dt_RoleCode
		{
			set{ _dt_rolecode=value;}
			get{return _dt_rolecode;}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string Dt_Name
		{
			set{ _dt_name=value;}
			get{return _dt_name;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Dt_Clear
		{
			set{ _dt_clear=value;}
			get{return _dt_clear;}
		}
		#endregion Model

	}
}


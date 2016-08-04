using System;
namespace Model
{
	/// <summary>
	/// 供应商类别表
	/// </summary>
	[Serializable]
	public partial class Profession
	{
		public Profession()
		{}
		#region Model
		private int _st_id;
        private string _st_code;
        private string _st_name;
		private string _st_parentID;
		private int? _st_enable=1;
		private int? _st_clear=1;
		
		/// <summary>
		/// 
		/// </summary>
		public int ST_ID
		{
			set{ _st_id=value;}
			get{return _st_id;}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string ST_Name
		{
			set{ _st_name=value;}
			get{return _st_name;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string ST_Code
		{
			set{ _st_code = value;}
			get{return _st_code; }
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public int? ST_Enable
		{
			set{ _st_enable=value;}
			get{return _st_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? ST_Clear
		{
			set{ _st_clear=value;}
			get{return _st_clear;}
		}
		/// <summary>
		/// 类别编号
		/// </summary>
		public string ST_ParentId
		{
			set{ _st_parentID = value;}
			get{return _st_parentID; }
		}
		#endregion Model

	}
}


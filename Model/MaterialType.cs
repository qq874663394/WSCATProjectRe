using System;
namespace Model
{
	/// <summary>
	/// 物料类别表
	/// </summary>
	[Serializable]
	public partial class MaterialType
	{
		public MaterialType()
		{}
		#region Model
		private int _mt_id;
        private string _mt_code;
        private string _mt_name;
        private string _mt_parentid;
        private int? _mt_enable=1;
		private int? _mt_clear=1;
		
		/// <summary>
		/// 自增
		/// </summary>
		public int MT_ID
		{
			set{ _mt_id=value;}
			get{return _mt_id;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string MT_Code
		{
			set{ _mt_code = value;}
			get{return _mt_code; }
		}
        /// <summary>
		/// 类别名称
		/// </summary>
		public string MT_Name
        {
            set { _mt_name = value; }
            get { return _mt_name; }
        }
        /// <summary>
		/// 类别名称
		/// </summary>
		public string MT_ParentID
        {
            set { _mt_parentid = value; }
            get { return _mt_parentid; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int? MT_Enable
		{
			set{ _mt_enable=value;}
			get{return _mt_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? MT_Clear
		{
			set{ _mt_clear=value;}
			get{return _mt_clear;}
		}
		
		#endregion Model

	}
}


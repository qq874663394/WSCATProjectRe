using System;
namespace Model
{
	/// <summary>
	/// 其他支出项目表
	/// </summary>
	[Serializable]
	public partial class ProjectCost
	{
		public ProjectCost()
		{}
        #region Model
        private int _pc_id;
        private string _pc_code;
        private string _pc_name;
        private string _pc_parentid;
        private int? _pc_enable;
        private int? _pc_clear;
        /// <summary>
        /// 自增ID
        /// </summary>
        public int PC_ID
        {
            set { _pc_id = value; }
            get { return _pc_id; }
        }
        /// <summary>
        /// 类型编号
        /// </summary>
        public string PC_Code
        {
            set { _pc_code = value; }
            get { return _pc_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PC_Name
        {
            set { _pc_name = value; }
            get { return _pc_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PC_ParentId
        {
            set { _pc_parentid = value; }
            get { return _pc_parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PC_Enable
        {
            set { _pc_enable = value; }
            get { return _pc_enable; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PC_Clear
        {
            set { _pc_clear = value; }
            get { return _pc_clear; }
        }

        #endregion Model

    }
}


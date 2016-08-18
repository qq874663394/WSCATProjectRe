using System;
namespace Model
{
	/// <summary>
	/// 仓库表
	/// </summary>
	[Serializable]
	public partial class Unit
	{
		public Unit()
		{}
		#region Model
		private int _unit_id;
		private string _unit_code;
		private string _unit_name;
        private DateTime _unit_updatedate;
        /// <summary>
        /// 
        /// </summary>
        public int Unit_ID
		{
			set{ _unit_id=value;}
			get{return _unit_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit_Code
		{
			set{ _unit_code=value;}
			get{return _unit_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit_Name
		{
			set{ _unit_name=value;}
			get{return _unit_name;}
		}
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime Unit_UpdateDate
        {
            set { _unit_updatedate = value; }
            get { return _unit_updatedate; }
        }
        #endregion Model

    }
}


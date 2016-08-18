using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OrderType
	{
		public OrderType()
		{}
		#region Model
		private int _ot_id;
		private string _ot_name;
		private string _ot_code;
        private DateTime _ot_updatedate;
        /// <summary>
        /// 类型ID
        /// </summary>
        public int Ot_ID
		{
			set{ _ot_id=value;}
			get{return _ot_id;}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string Ot_Name
		{
			set{ _ot_name=value;}
			get{return _ot_name;}
		}
		/// <summary>
		/// 类型编号
		/// </summary>
		public string Ot_Code
		{
			set{ _ot_code=value;}
			get{return _ot_code;}
		}
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime Ot_UpdateDate
        {
            set { _ot_updatedate = value; }
            get { return _ot_updatedate; }
        }
        #endregion Model

    }
}


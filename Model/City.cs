using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class City
	{
		public City()
		{}
		#region Model
		private int _city_id;
		private string _city_name;
		private string _city_parentid;
        private int _city_enable = 1;
        private int _city_clear = 1;
        private string _city_code;
		/// <summary>
		/// 
		/// </summary>
		public int City_ID
		{
			set{ _city_id=value;}
			get{return _city_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City_Name
		{
			set{ _city_name=value;}
			get{return _city_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City_ParentId
		{
			set{ _city_parentid=value;}
			get{return _city_parentid;}
		}

        public int City_Enable
        {
            get
            {
                return _city_enable;
            }

            set
            {
                _city_enable = value;
            }
        }

        public int City_Clear
        {
            get
            {
                return _city_clear;
            }

            set
            {
                _city_clear = value;
            }
        }

        public string City_Code
        {
            get
            {
                return _city_code;
            }

            set
            {
                _city_code = value;
            }
        }
        #endregion Model

    }
}


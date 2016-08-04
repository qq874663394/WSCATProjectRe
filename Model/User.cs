using System;
namespace Model
{
	/// <summary>
	/// 仓库表
	/// </summary>
	[Serializable]
	public partial class User
	{
		public User()
		{}
		#region Model
		private int _user_id;
        private string _user_code;
		private string _user_zhiwen;
		private string _user_name;
		private string _user_cardcode;
		private string _user_password;
		private string _user_role;
		private int? _user_manager=0;
		/// <summary>
		/// 
		/// </summary>
		public int User_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 指纹
		/// </summary>
		public string User_zhiwen
		{
			set{ _user_zhiwen=value;}
			get{return _user_zhiwen;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string User_Name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// RFID卡号
		/// </summary>
		public string User_CardCode
		{
			set{ _user_cardcode=value;}
			get{return _user_cardcode;}
		}
		/// <summary>
		/// 加密
		/// </summary>
		public string User_Password
		{
			set{ _user_password=value;}
			get{return _user_password;}
		}
		/// <summary>
		/// 权限的外键
		/// </summary>
		public string User_Role
		{
			set{ _user_role=value;}
			get{return _user_role;}
		}
		/// <summary>
		/// 是否是管理员,0为不是,1为是
		/// </summary>
		public int? User_Manager
		{
			set{ _user_manager=value;}
			get{return _user_manager;}
		}

        /// <summary>
        /// 编号
        /// </summary>
        public string User_code
        {
            get
            {
                return _user_code;
            }

            set
            {
                _user_code = value;
            }
        }
        #endregion Model

    }
}


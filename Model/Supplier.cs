using System;
namespace Model
{
	/// <summary>
	/// 仓库表
	/// </summary>
	[Serializable]
	public partial class Supplier
	{
		public Supplier()
		{}
		#region Model
		private int _su_id;
		private string _su_name;
		private string _su_phone;
		private string _su_address;
		private string _su_fax;
		private string _su_email;
		private string _su_bankaccounts;
		private string _su_bank;
		private string _su_profession;
		private string _su_procode;
		private string _su_credit;
		private string _su_money= "0";
		private string _su_surplus= "0";
		private string _su_reckoning= "0";
		private string _su_empname;
		private string _su_empphone;
		private string _su_remark;
		private int? _su_enable=1;
		private int? _su_clear=1;
		private string _su_safetone;
		private string _su_safettwo;
		private string _su_code;
		private string _su_area;
        private string _su_enableStr;
		/// <summary>
		/// 
		/// </summary>
		public int Su_ID
		{
			set{ _su_id=value;}
			get{return _su_id;}
		}
		/// <summary>
		/// 供应商名
		/// </summary>
		public string Su_Name
		{
			set{ _su_name=value;}
			get{return _su_name;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Su_Phone
		{
			set{ _su_phone=value;}
			get{return _su_phone;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Su_Address
		{
			set{ _su_address=value;}
			get{return _su_address;}
		}
		/// <summary>
		/// 传真
		/// </summary>
		public string Su_fax
		{
			set{ _su_fax=value;}
			get{return _su_fax;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Su_Email
		{
			set{ _su_email=value;}
			get{return _su_email;}
		}
		/// <summary>
		/// 银行卡号
		/// </summary>
		public string Su_Bankaccounts
		{
			set{ _su_bankaccounts=value;}
			get{return _su_bankaccounts;}
		}
		/// <summary>
		/// 开户行
		/// </summary>
		public string Su_Bank
		{
			set{ _su_bank=value;}
			get{return _su_bank;}
		}
		/// <summary>
		/// 所属行业
		/// </summary>
		public string Su_Profession
		{
			set{ _su_profession=value;}
			get{return _su_profession;}
		}
		/// <summary>
		/// 行业类别ID
		/// </summary>
		public string Su_ProCode
		{
			set{ _su_procode=value;}
			get{return _su_procode;}
		}
		/// <summary>
		/// 信用等级
		/// </summary>
		public string Su_Credit
		{
			set{ _su_credit=value;}
			get{return _su_credit;}
		}
		/// <summary>
		/// 账款额度
		/// </summary>
		public string Su_Money
		{
			set{ _su_money=value;}
			get{return _su_money;}
		}
		/// <summary>
		/// 剩余额度
		/// </summary>
		public string Su_Surplus
		{
			set{ _su_surplus=value;}
			get{return _su_surplus;}
		}
		/// <summary>
		/// 月结日
		/// </summary>
		public string Su_Reckoning
		{
			set{ _su_reckoning=value;}
			get{return _su_reckoning;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string Su_Empname
		{
			set{ _su_empname=value;}
			get{return _su_empname;}
		}
		/// <summary>
		/// 联系人移动电话
		/// </summary>
		public string Su_EmpPhone
		{
			set{ _su_empphone=value;}
			get{return _su_empphone;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Su_Remark
		{
			set{ _su_remark=value;}
			get{return _su_remark;}
		}
		/// <summary>
		/// 是否可用
		/// </summary>
		public int? Su_Enable
		{
			set{ _su_enable=value;}
			get{return _su_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Su_Clear
		{
			set{ _su_clear=value;}
			get{return _su_clear;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Su_Safetone
		{
			set{ _su_safetone=value;}
			get{return _su_safetone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Su_Safettwo
		{
			set{ _su_safettwo=value;}
			get{return _su_safettwo;}
		}
		/// <summary>
		/// 供应商编号
		/// </summary>
		public string Su_Code
		{
			set{ _su_code=value;}
			get{return _su_code;}
		}
		/// <summary>
		/// 地区
		/// </summary>
		public string Su_Area
		{
			set{ _su_area=value;}
			get{return _su_area;}
		}

        public string Su_EnableStr
        {
            get
            {
                return _su_enableStr;
            }

            set
            {
                _su_enableStr = value;
            }
        }
        #endregion Model

    }
}


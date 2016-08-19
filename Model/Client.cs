using System;
namespace Model
{
	/// <summary>
	/// 客户表
	/// </summary>
	[Serializable]
	public partial class Client
	{
		public Client()
		{}
		#region Model
		private int _cli_id;
		private string _cli_code;
		private string _cli_zhiwen;
		private string _cli_name;
		private string _cli_picname;
		private string _cli_phone;
		private string _cli_phonetwo;
		private string _cli_faxes;
        private string _cli_Citycode;
		private string _cli_area;
		private string _cli_address;
		private string _cli_linkman;
        private string _cli_company;
		private string _cli_typecode;
        private string _cli_typename;
        private string _cli_discountcode;
		private string _cli_bankaccounts;
		private string _cli_openbank;
		private DateTime? _cli_olddata;
		private DateTime? _cli_oldreturn;
		private DateTime? _cli_newoutdata;
		private DateTime? _cli_newintodata;
		private DateTime? _cli_createdata= DateTime.Now;
		private string _cli_limit;
		private string _cli_remainlimit;
		private string _cli_clearlimitdate;
		private string _cli_shouldmoney;
		private string _cli_getmoney;
		private string _cli_premoney;
		private string _cli_remark;
		private string _cli_safetone;
		private string _cli_safettwo;
		private int? _cli_enable=1;
		/// <summary>
		/// 
		/// </summary>
		public int Cli_ID
		{
			set{ _cli_id=value;}
			get{return _cli_id;}
		}
		/// <summary>
		/// 客户编号
		/// </summary>
		public string Cli_Code
		{
			set{ _cli_code=value;}
			get{return _cli_code;}
		}
		/// <summary>
		/// 指纹
		/// </summary>
		public string Cli_zhiwen
		{
			set{ _cli_zhiwen=value;}
			get{return _cli_zhiwen;}
		}
		/// <summary>
		/// 客户名
		/// </summary>
		public string Cli_Name
		{
			set{ _cli_name=value;}
			get{return _cli_name;}
		}
		/// <summary>
		/// 图片名称
		/// </summary>
		public string Cli_PicName
		{
			set{ _cli_picname=value;}
			get{return _cli_picname;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string Cli_Phone
		{
			set{ _cli_phone=value;}
			get{return _cli_phone;}
		}
		/// <summary>
		/// 座机号码
		/// </summary>
		public string Cli_PhoneTwo
		{
			set{ _cli_phonetwo=value;}
			get{return _cli_phonetwo;}
		}
		/// <summary>
		/// 传真
		/// </summary>
		public string Cli_faxes
		{
			set{ _cli_faxes=value;}
			get{return _cli_faxes;}
		}
		/// <summary>
		/// 地区，用/划分级
		/// </summary>
		public string Cli_area
		{
			set{ _cli_area=value;}
			get{return _cli_area;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Cli_Address
		{
			set{ _cli_address=value;}
			get{return _cli_address;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string Cli_LinkMan
		{
			set{ _cli_linkman=value;}
			get{return _cli_linkman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cli_TypeCode
		{
			set{ _cli_typecode=value;}
			get{return _cli_typecode;}
		}
		/// <summary>
		/// 折扣ID
		/// </summary>
		public string Cli_DiscountCode
		{
			set{ _cli_discountcode=value;}
			get{return _cli_discountcode;}
		}
		/// <summary>
		/// 银行帐号
		/// </summary>
		public string Cli_Bankaccounts
		{
			set{ _cli_bankaccounts=value;}
			get{return _cli_bankaccounts;}
		}
		/// <summary>
		/// 开户行
		/// </summary>
		public string Cli_OpenBank
		{
			set{ _cli_openbank=value;}
			get{return _cli_openbank;}
		}
		/// <summary>
		/// 最初销售时间
		/// </summary>
		public DateTime? Cli_Olddata
		{
			set{ _cli_olddata=value;}
			get{return _cli_olddata;}
		}
		/// <summary>
		/// 最初退货时间
		/// </summary>
		public DateTime? Cli_Oldreturn
		{
			set{ _cli_oldreturn=value;}
			get{return _cli_oldreturn;}
		}
		/// <summary>
		/// 最后退货时间
		/// </summary>
		public DateTime? Cli_Newoutdata
		{
			set{ _cli_newoutdata=value;}
			get{return _cli_newoutdata;}
		}
		/// <summary>
		/// 最后销售是时间
		/// </summary>
		public DateTime? Cli_Newintodata
		{
			set{ _cli_newintodata=value;}
			get{return _cli_newintodata;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? Cli_Createdata
		{
			set{ _cli_createdata=value;}
			get{return _cli_createdata;}
		}
		/// <summary>
		/// 可用额度
		/// </summary>
		public string Cli_Limit
		{
			set{ _cli_limit=value;}
			get{return _cli_limit;}
		}
		/// <summary>
		/// 剩余额度
		/// </summary>
		public string Cli_RemainLimit
		{
			set{ _cli_remainlimit=value;}
			get{return _cli_remainlimit;}
		}
		/// <summary>
		/// 结账日期
		/// </summary>
		public string Cli_ClearLimitdate
		{
			set{ _cli_clearlimitdate=value;}
			get{return _cli_clearlimitdate;}
		}
		/// <summary>
		/// 应收款
		/// </summary>
		public string Cli_ShouldMoney
		{
			set{ _cli_shouldmoney=value;}
			get{return _cli_shouldmoney;}
		}
		/// <summary>
		/// 已收款
		/// </summary>
		public string Cli_GetMoney
		{
			set{ _cli_getmoney=value;}
			get{return _cli_getmoney;}
		}
		/// <summary>
		/// 预收款
		/// </summary>
		public string Cli_PreMoney
		{
			set{ _cli_premoney=value;}
			get{return _cli_premoney;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Cli_Remark
		{
			set{ _cli_remark=value;}
			get{return _cli_remark;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Cli_safetone
		{
			set{ _cli_safetone=value;}
			get{return _cli_safetone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Cli_safettwo
		{
			set{ _cli_safettwo=value;}
			get{return _cli_safettwo;}
		}
		/// <summary>
		/// 是否删除,0为删除1为保留
		/// </summary>
		public int? Cli_Enable
		{
			set{ _cli_enable=value;}
			get{return _cli_enable;}
		}
        /// <summary>
        /// 单位名
        /// </summary>
        public string Cli_Company
        {
            get
            {
                return _cli_company;
            }

            set
            {
                _cli_company = value;
            }
        }
        /// <summary>
        /// 地区编号
        /// </summary>
        public string Cli_Citycode
        {
            get
            {
                return _cli_Citycode;
            }

            set
            {
                _cli_Citycode = value;
            }
        }
        /// <summary>
        /// 客户类别名称
        /// </summary>
        public string Cli_typename
        {
            get
            {
                return _cli_typename;
            }

            set
            {
                _cli_typename = value;
            }
        }
        #endregion Model

    }
}


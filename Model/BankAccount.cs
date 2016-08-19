using System;
namespace Model
{
	/// <summary>
	/// 账户表
	/// </summary>
	[Serializable]
	public partial class BankAccount
	{
		public BankAccount()
		{}
		#region Model
		private int _ba_id;
		private string _ba_code;
		private string _ba_openbank;
		private string _ba_account;
		private string _ba_cardholder;
		private string _ba_remark;
		private string _ba_availableprice;
		private int? _ba_enable=1;
		private int? _ba_clear=1;
		/// <summary>
		/// 
		/// </summary>
		public int Ba_ID
		{
			set{ _ba_id=value;}
			get{return _ba_id;}
		}
		/// <summary>
		/// 账户编号
		/// </summary>
		public string Ba_Code
		{
			set{ _ba_code=value;}
			get{return _ba_code;}
		}
		/// <summary>
		/// 开户行
		/// </summary>
		public string Ba_OpenBank
		{
			set{ _ba_openbank=value;}
			get{return _ba_openbank;}
		}
		/// <summary>
		/// 银行账户
		/// </summary>
		public string Ba_Account
		{
			set{ _ba_account=value;}
			get{return _ba_account;}
		}
		/// <summary>
		/// 持卡人
		/// </summary>
		public string Ba_CardHolder
		{
			set{ _ba_cardholder=value;}
			get{return _ba_cardholder;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Ba_Remark
		{
			set{ _ba_remark=value;}
			get{return _ba_remark;}
		}
		/// <summary>
		/// 可用金额
		/// </summary>
		public string Ba_AvailablePrice
		{
			set{ _ba_availableprice=value;}
			get{return _ba_availableprice;}
		}
		/// <summary>
		/// 是否可用
		/// </summary>
		public int? Ba_Enable
		{
			set{ _ba_enable=value;}
			get{return _ba_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Ba_Clear
		{
			set{ _ba_clear=value;}
			get{return _ba_clear;}
		}
		#endregion Model

	}
}


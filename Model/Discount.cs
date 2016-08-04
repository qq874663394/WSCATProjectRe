using System;
namespace Model
{
	/// <summary>
	/// 客户折扣表
	/// </summary>
	[Serializable]
	public partial class Discount
	{
		public Discount()
		{}
		#region Model
		private int _dis_id;
		private string _dis_name;
		private string _dis_clientcode;
		private DateTime? _dis_createdate= DateTime.Now;
		private DateTime? _dis_cleardate;
		private string _dis_discount;
		private int? _dis_enable=1;
		private int? _dis_clear=1;
		private string _dis_remark;
		private string _dis_code;
		/// <summary>
		/// 
		/// </summary>
		public int Dis_ID
		{
			set{ _dis_id=value;}
			get{return _dis_id;}
		}
		/// <summary>
		/// 客户名称
		/// </summary>
		public string Dis_Name
		{
			set{ _dis_name=value;}
			get{return _dis_name;}
		}
		/// <summary>
		/// 客户编码
		/// </summary>
		public string Dis_ClientCode
		{
			set{ _dis_clientcode=value;}
			get{return _dis_clientcode;}
		}
		/// <summary>
		/// 建立时间
		/// </summary>
		public DateTime? Dis_CreateDate
		{
			set{ _dis_createdate=value;}
			get{return _dis_createdate;}
		}
		/// <summary>
		/// 到期时间
		/// </summary>
		public DateTime? Dis_ClearDate
		{
			set{ _dis_cleardate=value;}
			get{return _dis_cleardate;}
		}
		/// <summary>
		/// 折数（%）
		/// </summary>
		public string Dis_Discount
		{
			set{ _dis_discount=value;}
			get{return _dis_discount;}
		}
		/// <summary>
		/// 是否可用
		/// </summary>
		public int? Dis_Enable
		{
			set{ _dis_enable=value;}
			get{return _dis_enable;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Dis_Clear
		{
			set{ _dis_clear=value;}
			get{return _dis_clear;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Dis_Remark
		{
			set{ _dis_remark=value;}
			get{return _dis_remark;}
		}
		/// <summary>
		/// 折扣编号
		/// </summary>
		public string Dis_Code
		{
			set{ _dis_code=value;}
			get{return _dis_code;}
		}
		#endregion Model

	}
}


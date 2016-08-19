using System;
namespace Model
{
	/// <summary>
	/// 其他支出项目表
	/// </summary>
	[Serializable]
	public partial class SellCancel
	{
		public SellCancel()
		{}
		#region Model
		private int _ca_id;
		private string _ca_code;
		private string _ca_clientname;
		private string _ca_clientphone;
		private DateTime? _ca_outdate= DateTime.Now;
		private string _ca_salemanid;
		private string _ca_manname;
		private int? _ca_enable=1;
		private int? _ca_againin;
		private string _ca_operation;
		private string _ca_auditman;
		private string _ca_remark;
		private string _ca_satetyone;
		private string _ca_satetytwo;
		private int? _ca_clear=1;
		/// <summary>
		/// 
		/// </summary>
		public int Ca_ID
		{
			set{ _ca_id=value;}
			get{return _ca_id;}
		}
		/// <summary>
		/// 退货编号
		/// </summary>
		public string Ca_Code
		{
			set{ _ca_code=value;}
			get{return _ca_code;}
		}
		/// <summary>
		/// 客户名称
		/// </summary>
		public string Ca_ClientName
		{
			set{ _ca_clientname=value;}
			get{return _ca_clientname;}
		}
		/// <summary>
		/// 客户电话
		/// </summary>
		public string Ca_ClientPhone
		{
			set{ _ca_clientphone=value;}
			get{return _ca_clientphone;}
		}
		/// <summary>
		/// 退货时间
		/// </summary>
		public DateTime? Ca_OutDate
		{
			set{ _ca_outdate=value;}
			get{return _ca_outdate;}
		}
		/// <summary>
		/// 业务员编号
		/// </summary>
		public string Ca_SalemanID
		{
			set{ _ca_salemanid=value;}
			get{return _ca_salemanid;}
		}
		/// <summary>
		/// 业务员姓名
		/// </summary>
		public string Ca_ManName
		{
			set{ _ca_manname=value;}
			get{return _ca_manname;}
		}
		/// <summary>
		/// 是否已审核
		/// </summary>
		public int? Ca_Enable
		{
			set{ _ca_enable=value;}
			get{return _ca_enable;}
		}
		/// <summary>
		/// 是否重新入库
		/// </summary>
		public int? Ca_AgainIn
		{
			set{ _ca_againin=value;}
			get{return _ca_againin;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string Ca_Operation
		{
			set{ _ca_operation=value;}
			get{return _ca_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Ca_Auditman
		{
			set{ _ca_auditman=value;}
			get{return _ca_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Ca_Remark
		{
			set{ _ca_remark=value;}
			get{return _ca_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Ca_Satetyone
		{
			set{ _ca_satetyone=value;}
			get{return _ca_satetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Ca_Satetytwo
		{
			set{ _ca_satetytwo=value;}
			get{return _ca_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Ca_Clear
		{
			set{ _ca_clear=value;}
			get{return _ca_clear;}
		}
		#endregion Model

	}
}


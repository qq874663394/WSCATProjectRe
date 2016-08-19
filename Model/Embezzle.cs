using System;
namespace Model
{
	/// <summary>
	/// 客户折扣表
	/// </summary>
	[Serializable]
	public partial class Embezzle
	{
		public Embezzle()
		{}
		#region Model
		private int _e_id;
		private string _e_code;
		private int? _e_type;
		private string _e_accountcode;
		private string _e_currentunits;
		private string _e_unitcode;
		private string _e_unitname;
		private string _e_empcode;
		private string _e_empname;
		private string _e_operation;
		private string _e_auditman;
		private string _e_salesman;
		private DateTime? _e_date= DateTime.Now;
		private string _e_abstracts;
		private string _e_satetyone;
		private string _e_satetytwo;
		private int? _e_clear=1;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int E_ID
		{
			set{ _e_id=value;}
			get{return _e_id;}
		}
		/// <summary>
		/// 挪用单号
		/// </summary>
		public string E_Code
		{
			set{ _e_code=value;}
			get{return _e_code;}
		}
		/// <summary>
		/// 借款类型
		/// </summary>
		public int? E_Type
		{
			set{ _e_type=value;}
			get{return _e_type;}
		}
		/// <summary>
		/// 结算账户编码
		/// </summary>
		public string E_AccountCode
		{
			set{ _e_accountcode=value;}
			get{return _e_accountcode;}
		}
		/// <summary>
		/// 往来单位编码
		/// </summary>
		public string E_CurrentUnits
		{
			set{ _e_currentunits=value;}
			get{return _e_currentunits;}
		}
		/// <summary>
		/// 单位编码
		/// </summary>
		public string E_UnitCode
		{
			set{ _e_unitcode=value;}
			get{return _e_unitcode;}
		}
		/// <summary>
		/// 单位名
		/// </summary>
		public string E_UnitName
		{
			set{ _e_unitname=value;}
			get{return _e_unitname;}
		}
		/// <summary>
		/// 员工工号
		/// </summary>
		public string E_EmpCode
		{
			set{ _e_empcode=value;}
			get{return _e_empcode;}
		}
		/// <summary>
		/// 员工名
		/// </summary>
		public string E_EmpName
		{
			set{ _e_empname=value;}
			get{return _e_empname;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string E_Operation
		{
			set{ _e_operation=value;}
			get{return _e_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string E_AuditMan
		{
			set{ _e_auditman=value;}
			get{return _e_auditman;}
		}
		/// <summary>
		/// 开单业务员
		/// </summary>
		public string E_SalesMan
		{
			set{ _e_salesman=value;}
			get{return _e_salesman;}
		}
		/// <summary>
		/// 日期
		/// </summary>
		public DateTime? E_Date
		{
			set{ _e_date=value;}
			get{return _e_date;}
		}
		/// <summary>
		/// 摘要
		/// </summary>
		public string E_Abstracts
		{
			set{ _e_abstracts=value;}
			get{return _e_abstracts;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string E_Satetyone
		{
			set{ _e_satetyone=value;}
			get{return _e_satetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string E_Satetytwo
		{
			set{ _e_satetytwo=value;}
			get{return _e_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? E_Clear
		{
			set{ _e_clear=value;}
			get{return _e_clear;}
		}
		#endregion Model

	}
}


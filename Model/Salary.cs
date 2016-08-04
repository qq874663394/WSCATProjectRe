using System;
namespace Model
{
	/// <summary>
	/// 其他支出项目表
	/// </summary>
	[Serializable]
	public partial class Salary
	{
		public Salary()
		{}
		#region Model
		private int _sy_id;
		private string _sy_code;
		private string _sy_salarymoney;
		private string _sy_safetyone;
		/// <summary>
		/// 
		/// </summary>
		public int Sy_ID
		{
			set{ _sy_id=value;}
			get{return _sy_id;}
		}
		/// <summary>
		/// 类型编号
		/// </summary>
		public string Sy_Code
		{
			set{ _sy_code=value;}
			get{return _sy_code;}
		}
		/// <summary>
		/// 工资金额
		/// </summary>
		public string Sy_SalaryMoney
		{
			set{ _sy_salarymoney=value;}
			get{return _sy_salarymoney;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Sy_Safetyone
		{
			set{ _sy_safetyone=value;}
			get{return _sy_safetyone;}
		}
		#endregion Model

	}
}


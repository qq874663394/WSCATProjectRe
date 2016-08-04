using System;
namespace Model
{
	/// <summary>
	/// 客户折扣表
	/// </summary>
	[Serializable]
	public partial class EmbezzleDetail
	{
		public EmbezzleDetail()
		{}
		#region Model
		private int _ed_id;
		private string _ed_code;
		private string _ed_detail;
		private string _ed_money;
		private string _ed_remark;
		private string _ed_satetyone;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int ED_ID
		{
			set{ _ed_id=value;}
			get{return _ed_id;}
		}
		/// <summary>
		/// 挪用主表编号
		/// </summary>
		public string ED_Code
		{
			set{ _ed_code=value;}
			get{return _ed_code;}
		}
		/// <summary>
		/// 详细说明
		/// </summary>
		public string ED_Detail
		{
			set{ _ed_detail=value;}
			get{return _ed_detail;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string ED_Money
		{
			set{ _ed_money=value;}
			get{return _ed_money;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string ED_Remark
		{
			set{ _ed_remark=value;}
			get{return _ed_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string ED_Satetyone
		{
			set{ _ed_satetyone=value;}
			get{return _ed_satetyone;}
		}
		#endregion Model

	}
}


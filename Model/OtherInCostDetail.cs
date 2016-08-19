using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OtherInCostDetail
	{
		public OtherInCostDetail()
		{}
		#region Model
		private int _oicd_id;
		private string _oicd_costcode;
		private string _oicd_oiccode;
		private string _oicd_money;
		private string _oicd_abstracts;
		private string _oicd_remark;
		private string _oicd_satetyone;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int OICD_ID
		{
			set{ _oicd_id=value;}
			get{return _oicd_id;}
		}
		/// <summary>
		/// 支出主表编码
		/// </summary>
		public string OICD_CostCode
		{
			set{ _oicd_costcode=value;}
			get{return _oicd_costcode;}
		}
		/// <summary>
		/// 收入项目编码
		/// </summary>
		public string OICD_OICCode
		{
			set{ _oicd_oiccode=value;}
			get{return _oicd_oiccode;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public string OICD_Money
		{
			set{ _oicd_money=value;}
			get{return _oicd_money;}
		}
		/// <summary>
		/// 摘要
		/// </summary>
		public string OICD_Abstracts
		{
			set{ _oicd_abstracts=value;}
			get{return _oicd_abstracts;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string OICD_Remark
		{
			set{ _oicd_remark=value;}
			get{return _oicd_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string OICD_Satetyone
		{
			set{ _oicd_satetyone=value;}
			get{return _oicd_satetyone;}
		}
		#endregion Model

	}
}


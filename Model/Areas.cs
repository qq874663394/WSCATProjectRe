using System;
namespace Model
{
	/// <summary>
	/// Areas:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Areas
	{
		public Areas()
		{}
		#region Model
		private int _areas_id;
		private string _areas_code;
		private string _areas_oneproject;
		private string _areas_twoproject;
		private string _areas_threeproject;
		private string _areas_fourproject;
		private string _areas_fiveproject;
		/// <summary>
		/// 
		/// </summary>
		public int Areas_ID
		{
			set{ _areas_id=value;}
			get{return _areas_id;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Areas_Code
		{
			set{ _areas_code=value;}
			get{return _areas_code;}
		}
		/// <summary>
		/// 地区1
		/// </summary>
		public string Areas_OneProject
		{
			set{ _areas_oneproject=value;}
			get{return _areas_oneproject;}
		}
		/// <summary>
		/// 地区2
		/// </summary>
		public string Areas_TwoProject
		{
			set{ _areas_twoproject=value;}
			get{return _areas_twoproject;}
		}
		/// <summary>
		/// 地区3
		/// </summary>
		public string Areas_ThreeProject
		{
			set{ _areas_threeproject=value;}
			get{return _areas_threeproject;}
		}
		/// <summary>
		/// 地区4
		/// </summary>
		public string Areas_FourProject
		{
			set{ _areas_fourproject=value;}
			get{return _areas_fourproject;}
		}
		/// <summary>
		/// 地区5
		/// </summary>
		public string Areas_FiveProject
		{
			set{ _areas_fiveproject=value;}
			get{return _areas_fiveproject;}
		}
		#endregion Model

	}
}


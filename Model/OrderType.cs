using System;
namespace Model
{
	/// <summary>
	/// 单据类型表
	/// </summary>
	[Serializable]
	public partial class OrderType
	{
		public OrderType()
		{}
		#region Model
		private int _ot_id;
		private string _ot_name;
		private string _ot_code;
		/// <summary>
		/// 类型ID
		/// </summary>
		public int Ot_ID
		{
			set{ _ot_id=value;}
			get{return _ot_id;}
		}
		/// <summary>
		/// 类型名称
		/// </summary>
		public string Ot_Name
		{
			set{ _ot_name=value;}
			get{return _ot_name;}
		}
		/// <summary>
		/// 类型编号
		/// </summary>
		public string Ot_Code
		{
			set{ _ot_code=value;}
			get{return _ot_code;}
		}
		#endregion Model

	}
}


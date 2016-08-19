using System;
namespace Model
{
	/// <summary>
	/// 仓库表
	/// </summary>
	[Serializable]
	public partial class Unit
	{
		public Unit()
		{}
		#region Model
		private int _unit_id;
		private string _unit_code;
		private string _unit_name;
		/// <summary>
		/// 
		/// </summary>
		public int Unit_ID
		{
			set{ _unit_id=value;}
			get{return _unit_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit_Code
		{
			set{ _unit_code=value;}
			get{return _unit_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit_Name
		{
			set{ _unit_name=value;}
			get{return _unit_name;}
		}
		#endregion Model

	}
}


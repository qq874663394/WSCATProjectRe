using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class Borrow
	{
		public Borrow()
		{}
		#region Model
		private int _bo_typeid;
		private string _bo_typename;
		/// <summary>
		/// 
		/// </summary>
		public int Bo_TypeID
		{
			set{ _bo_typeid=value;}
			get{return _bo_typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bo_TypeName
		{
			set{ _bo_typename=value;}
			get{return _bo_typename;}
		}
		#endregion Model

	}
}


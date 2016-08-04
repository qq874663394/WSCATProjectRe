using System;
namespace Model
{
	/// <summary>
	/// 上下班时刻表
	/// </summary>
	[Serializable]
	public partial class Work
	{
		public Work()
		{}
		#region Model
		private int _wk_id;
		private string _wk_code;
		private DateTime? _wk_wokedate;
		private DateTime? _wk_ringdate;
		private DateTime? _wk_allowlatedate;
		private DateTime? _wk_allowleavedate;
		private string _wk_rest;
		/// <summary>
		/// 
		/// </summary>
		public int Wk_ID
		{
			set{ _wk_id=value;}
			get{return _wk_id;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Wk_Code
		{
			set{ _wk_code=value;}
			get{return _wk_code;}
		}
		/// <summary>
		/// 上班时刻
		/// </summary>
		public DateTime? Wk_WokeDate
		{
			set{ _wk_wokedate=value;}
			get{return _wk_wokedate;}
		}
		/// <summary>
		/// 下班时刻
		/// </summary>
		public DateTime? Wk_RingDate
		{
			set{ _wk_ringdate=value;}
			get{return _wk_ringdate;}
		}
		/// <summary>
		/// 允许迟到分钟数
		/// </summary>
		public DateTime? Wk_AllowLateDate
		{
			set{ _wk_allowlatedate=value;}
			get{return _wk_allowlatedate;}
		}
		/// <summary>
		/// 允许早退分钟数
		/// </summary>
		public DateTime? Wk_AllowLeaveDate
		{
			set{ _wk_allowleavedate=value;}
			get{return _wk_allowleavedate;}
		}
		/// <summary>
		/// 每月休息天数
		/// </summary>
		public string Wk_Rest
		{
			set{ _wk_rest=value;}
			get{return _wk_rest;}
		}
		#endregion Model

	}
}


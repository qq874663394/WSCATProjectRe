using System;
namespace Model
{
	/// <summary>
	/// 单据编码表
	/// </summary>
	[Serializable]
	public partial class Serialization
	{
		public Serialization()
		{}
		#region Model
		private int _ser_id;
		private string _ser_code;
		private string _ser_description;
		private string _ser_prelenght;
		private int? _ser_alllenght;
		private string _ser_prefix;
		private DateTime? _ser_currentdate= DateTime.Now;
		private int? _ser_segno;
		private int? _ser_clear=1;
		/// <summary>
		/// 单据编号
		/// </summary>
		public int Ser_ID
		{
			set{ _ser_id=value;}
			get{return _ser_id;}
		}
		/// <summary>
		/// 编码代码
		/// </summary>
		public string Ser_Code
		{
			set{ _ser_code=value;}
			get{return _ser_code;}
		}
		/// <summary>
		/// 编码说明
		/// </summary>
		public string Ser_Description
		{
			set{ _ser_description=value;}
			get{return _ser_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ser_PreLenght
		{
			set{ _ser_prelenght=value;}
			get{return _ser_prelenght;}
		}
		/// <summary>
		/// 总编码长度
		/// </summary>
		public int? Ser_AllLenght
		{
			set{ _ser_alllenght=value;}
			get{return _ser_alllenght;}
		}
		/// <summary>
		/// 编码规则
		/// </summary>
		public string Ser_Prefix
		{
			set{ _ser_prefix=value;}
			get{return _ser_prefix;}
		}
		/// <summary>
		/// 当前日期
		/// </summary>
		public DateTime? Ser_CurrentDate
		{
			set{ _ser_currentdate=value;}
			get{return _ser_currentdate;}
		}
		/// <summary>
		/// 下个编号值
		/// </summary>
		public int? Ser_SegNo
		{
			set{ _ser_segno=value;}
			get{return _ser_segno;}
		}
		/// <summary>
		/// 是否停用
		/// </summary>
		public int? Ser_Clear
		{
			set{ _ser_clear=value;}
			get{return _ser_clear;}
		}
		#endregion Model

	}
}


using System;
namespace Model
{
	/// <summary>
	/// 物料类别表
	/// </summary>
	[Serializable]
	public partial class Move
	{
		public Move()
		{}
		#region Model
		private string _move_id;
		private int _move_lineno;
		private DateTime? _move_date;
		private string _move_operator;
		private string _move_model;
		private string _move_stoinid;
		private string _move_stooutid;
		private string _move_stooutname;
		private string _move_stoinname;
		private int? _move_clear=1;
		private string _move_safetyone;
		private string _move_safetytwo;
		private string _move_remark;
		/// <summary>
		/// 调价编号
		/// </summary>
		public string Move_ID
		{
			set{ _move_id=value;}
			get{return _move_id;}
		}
		/// <summary>
		/// 调拨单号(生成)
		/// </summary>
		public int Move_Lineno
		{
			set{ _move_lineno=value;}
			get{return _move_lineno;}
		}
		/// <summary>
		/// 调拨日期
		/// </summary>
		public DateTime? Move_Date
		{
			set{ _move_date=value;}
			get{return _move_date;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string Move_Operator
		{
			set{ _move_operator=value;}
			get{return _move_operator;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Move_Model
		{
			set{ _move_model=value;}
			get{return _move_model;}
		}
		/// <summary>
		/// 调入仓库编号
		/// </summary>
		public string Move_StoInID
		{
			set{ _move_stoinid=value;}
			get{return _move_stoinid;}
		}
		/// <summary>
		/// 调出仓库编号
		/// </summary>
		public string Move_StoOutID
		{
			set{ _move_stooutid=value;}
			get{return _move_stooutid;}
		}
		/// <summary>
		/// 调出仓库名称
		/// </summary>
		public string Move_StoOutName
		{
			set{ _move_stooutname=value;}
			get{return _move_stooutname;}
		}
		/// <summary>
		/// 调入仓库名称
		/// </summary>
		public string Move_StoInName
		{
			set{ _move_stoinname=value;}
			get{return _move_stoinname;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Move_Clear
		{
			set{ _move_clear=value;}
			get{return _move_clear;}
		}
		/// <summary>
		/// 预留字段1
		/// </summary>
		public string Move_Safetyone
		{
			set{ _move_safetyone=value;}
			get{return _move_safetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Move_Safetytwo
		{
			set{ _move_safetytwo=value;}
			get{return _move_safetytwo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Move_Remark
		{
			set{ _move_remark=value;}
			get{return _move_remark;}
		}
		#endregion Model

	}
}


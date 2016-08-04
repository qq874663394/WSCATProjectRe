using System;
namespace Model
{
	/// <summary>
	/// 物料类别表
	/// </summary>
	[Serializable]
	public partial class MoveDetail
	{
		public MoveDetail()
		{}
		#region Model
		private string _move_id;
		private int _move_lineno;
		private string _move_maid;
		private string _move_maname;
		private string _move_model;
		private string _move_unit;
		private string _move_curnumber;
		private int? _move_clear;
		private string _move_safetyone;
		private string _move_safetytwo;
		private string _move_remark;
		/// <summary>
		/// 调拨编号
		/// </summary>
		public string Move_ID
		{
			set{ _move_id=value;}
			get{return _move_id;}
		}
		/// <summary>
		/// 栏号(自增)
		/// </summary>
		public int Move_Lineno
		{
			set{ _move_lineno=value;}
			get{return _move_lineno;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Move_MaID
		{
			set{ _move_maid=value;}
			get{return _move_maid;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Move_MaName
		{
			set{ _move_maname=value;}
			get{return _move_maname;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Move_Model
		{
			set{ _move_model=value;}
			get{return _move_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Move_Unit
		{
			set{ _move_unit=value;}
			get{return _move_unit;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public string Move_CurNumber
		{
			set{ _move_curnumber=value;}
			get{return _move_curnumber;}
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


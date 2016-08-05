﻿using System;
namespace Model
{
	/// <summary>
	/// 其他支出项目表
	/// </summary>
	[Serializable]
	public partial class Sell
	{
		public Sell()
		{}
		#region Model
		private int _sell_id;
		private string _sell_code;
		private string _sell_type;
		private DateTime? _sell_date= DateTime.Now;
		private string _sell_transporttype;
		private int? _sell_review=0;
		private DateTime? _sell_changedate;
		private string _sell_operation;
		private string _sell_auditman;
		private string _sell_remark;
		private string _sell_satetyone;
		private string _sell_satetytwo;
		private int? _sell_clear=1;

        private int? _sell_isPay;
        private int? _sell_isPutSto;
        private int? _sell_payMathod;
        private DateTime _sell_getDate;
        private string _sell_logistics;
        private string _sell_logCode;
        private string _sell_logPhone;
		/// <summary>
		/// 
		/// </summary>
		public int Sell_ID
		{
			set{ _sell_id=value;}
			get{return _sell_id;}
		}
		/// <summary>
		/// 销售编号
		/// </summary>
		public string Sell_Code
		{
			set{ _sell_code=value;}
			get{return _sell_code;}
		}
		/// <summary>
		/// 单据类型
		/// </summary>
		public string Sell_Type
		{
			set{ _sell_type=value;}
			get{return _sell_type;}
		}
		/// <summary>
		/// 订单日期
		/// </summary>
		public DateTime? Sell_Date
		{
			set{ _sell_date=value;}
			get{return _sell_date;}
		}
		/// <summary>
		/// 运送方式
		/// </summary>
		public string Sell_TransportType
		{
			set{ _sell_transporttype=value;}
			get{return _sell_transporttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sell_Review
		{
			set{ _sell_review=value;}
			get{return _sell_review;}
		}
		/// <summary>
		/// 调价日期
		/// </summary>
		public DateTime? Sell_ChangeDate
		{
			set{ _sell_changedate=value;}
			get{return _sell_changedate;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string Sell_Operation
		{
			set{ _sell_operation=value;}
			get{return _sell_operation;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string Sell_Auditman
		{
			set{ _sell_auditman=value;}
			get{return _sell_auditman;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Sell_Remark
		{
			set{ _sell_remark=value;}
			get{return _sell_remark;}
		}
		/// <summary>
		/// 保留字段1
		/// </summary>
		public string Sell_Satetyone
		{
			set{ _sell_satetyone=value;}
			get{return _sell_satetyone;}
		}
		/// <summary>
		/// 保留字段2
		/// </summary>
		public string Sell_Satetytwo
		{
			set{ _sell_satetytwo=value;}
			get{return _sell_satetytwo;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Sell_Clear
		{
			set{ _sell_clear=value;}
			get{return _sell_clear;}
		}

        public int? Sell_IsPay
        {
            get
            {
                return _sell_isPay;
            }

            set
            {
                _sell_isPay = value;
            }
        }

        public int? Sell_IsPutSto
        {
            get
            {
                return _sell_isPutSto;
            }

            set
            {
                _sell_isPutSto = value;
            }
        }

        public int? Sell_PayMathod
        {
            get
            {
                return _sell_payMathod;
            }

            set
            {
                _sell_payMathod = value;
            }
        }

        public DateTime Sell_GetDate
        {
            get
            {
                return _sell_getDate;
            }

            set
            {
                _sell_getDate = value;
            }
        }

        public string Sell_Logistics
        {
            get
            {
                return _sell_logistics;
            }

            set
            {
                _sell_logistics = value;
            }
        }

        public string Sell_LogCode
        {
            get
            {
                return _sell_logCode;
            }

            set
            {
                _sell_logCode = value;
            }
        }

        public string Sell_LogPhone
        {
            get
            {
                return _sell_logPhone;
            }

            set
            {
                _sell_logPhone = value;
            }
        }
        #endregion Model

    }
}


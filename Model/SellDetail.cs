using System;
namespace Model
{
	/// <summary>
	/// 销售订单明细表
	/// </summary>
	[Serializable]
	public partial class SellDetail
	{
		public SellDetail()
		{}
        #region Model
        private int _sell_lineno;
        private string _sell_code;
        private string _sell_stockCode;
        private string _sell_stockName;
        private string _sell_lineCode;
		private string _sell_maid;
		private string _sell_maname;
		private string _sell_model;
		private string _sell_unit;
		private decimal _sell_curnumber;
        private decimal _sell_renumber;
        private decimal _sell_lostnumber;
        private decimal _sell_discountAPrice;
        private decimal _sell_discount;
        private decimal _sell_discountBPrice;
        private decimal _sell_money;
		private int? _sell_clear=1;
		private string _sell_safetyone;
		private string _sell_safetytwo;
		private string _sell_remark;
        private DateTime _sellde_updatedate;

        /// <summary>
        /// 销售订单编号
        /// </summary>
        public string Sell_Code
		{
			set{ _sell_code=value;}
			get{return _sell_code;}
		}
		/// <summary>
		/// 栏号(自增)ID
		/// </summary>
		public int Sell_Lineno
		{
			set{ _sell_lineno=value;}
			get{return _sell_lineno;}
		}
		/// <summary>
		/// 物料编号
		/// </summary>
		public string Sell_MaID
		{
			set{ _sell_maid=value;}
			get{return _sell_maid;}
		}
		/// <summary>
		/// 物料名称
		/// </summary>
		public string Sell_MaName
		{
			set{ _sell_maname=value;}
			get{return _sell_maname;}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		public string Sell_Model
		{
			set{ _sell_model=value;}
			get{return _sell_model;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string Sell_Unit
		{
			set{ _sell_unit=value;}
			get{return _sell_unit;}
		}
		/// <summary>
		/// 预期数量
		/// </summary>
		public decimal Sell_CurNumber
		{
			set{ _sell_curnumber=value;}
			get{return _sell_curnumber;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int? Sell_Clear
		{
			set{ _sell_clear=value;}
			get{return _sell_clear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sell_Safetyone
		{
			set{ _sell_safetyone=value;}
			get{return _sell_safetyone;}
		}
		/// <summary>
		/// 预留字段2
		/// </summary>
		public string Sell_Safetytwo
		{
			set{ _sell_safetytwo=value;}
			get{return _sell_safetytwo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Sell_Remark
		{
			set{ _sell_remark=value;}
			get{return _sell_remark;}
		}

        public string Sell_StockCode
        {
            get
            {
                return _sell_stockCode;
            }

            set
            {
                _sell_stockCode = value;
            }
        }

        public string Sell_StockName
        {
            get
            {
                return _sell_stockName;
            }

            set
            {
                _sell_stockName = value;
            }
        }

        public string Sell_LineCode
        {
            get
            {
                return _sell_lineCode;
            }

            set
            {
                _sell_lineCode = value;
            }
        }

        public decimal Sell_DiscountAPrice
        {
            get
            {
                return _sell_discountAPrice;
            }

            set
            {
                _sell_discountAPrice = value;
            }
        }

        public decimal Sell_Discount
        {
            get
            {
                return _sell_discount;
            }

            set
            {
                _sell_discount = value;
            }
        }

        public decimal Sell_DiscountBPrice
        {
            get
            {
                return _sell_discountBPrice;
            }

            set
            {
                _sell_discountBPrice = value;
            }
        }

        public decimal Sell_Money
        {
            get
            {
                return _sell_money;
            }

            set
            {
                _sell_money = value;
            }
        }

        /// <summary>
        /// 实际数量
        /// </summary>
        public decimal Sell_ReNumber
        {
            get
            {
                return _sell_renumber;
            }

            set
            {
                _sell_renumber = value;
            }
        }

        /// <summary>
        /// 欠缺数量
        /// </summary>
        public decimal Sell_LostNumber
        {
            get
            {
                return _sell_lostnumber;
            }

            set
            {
                _sell_lostnumber = value;
            }
        }
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime SellDe_UpdateDate
        {
            set { _sellde_updatedate = value; }
            get { return _sellde_updatedate; }
        }

        #endregion Model

    }
}


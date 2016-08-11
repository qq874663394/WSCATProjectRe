using System;
namespace Model
{
	/// <summary>
	/// 借款类型表
	/// </summary>
	[Serializable]
	public partial class BuyDetail
	{
		public BuyDetail()
		{}
        #region Model
        private string _buy_id;
        private int _buy_lineno;
        private string _buy_code;
        private string _buy_stockcode;
        private string _buy_stockname;
        private string _buy_maid;
        private string _buy_maname;
        private string _buy_model;
        private string _buy_unit;
        private decimal? _buy_curnumber;
        private decimal? _buy_discountaprice;
        private decimal? _buy_discount;
        private decimal? _buy_discountbprice;
        private decimal? _buy_amountmoney;
        private int? _buy_clear;
        private string _buy_safetyone;
        private string _buy_safetytwo;
        private string _buy_remark;
        private string _buy_linecode;

        /// <summary>
        /// 栏号自增
        /// </summary>
        public int Buy_Lineno
        {
            set { _buy_lineno = value; }
            get { return _buy_lineno; }
        }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string Buy_MaID
        {
            set { _buy_maid = value; }
            get { return _buy_maid; }
        }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string Buy_MaName
        {
            set { _buy_maname = value; }
            get { return _buy_maname; }
        }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Buy_Model
        {
            set { _buy_model = value; }
            get { return _buy_model; }
        }
        /// <summary>
        /// 单位
        /// </summary>
        public string Buy_Unit
        {
            set { _buy_unit = value; }
            get { return _buy_unit; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal? Buy_CurNumber
        {
            set { _buy_curnumber = value; }
            get { return _buy_curnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Buy_DiscountAPrice
        {
            set { _buy_discountaprice = value; }
            get { return _buy_discountaprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Buy_Discount
        {
            set { _buy_discount = value; }
            get { return _buy_discount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Buy_DiscountBPrice
        {
            set { _buy_discountbprice = value; }
            get { return _buy_discountbprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Buy_AmountMoney
        {
            set { _buy_amountmoney = value; }
            get { return _buy_amountmoney; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int? Buy_Clear
        {
            set { _buy_clear = value; }
            get { return _buy_clear; }
        }
        /// <summary>
        /// 预留字段1
        /// </summary>
        public string Buy_Safetyone
        {
            set { _buy_safetyone = value; }
            get { return _buy_safetyone; }
        }
        /// <summary>
        /// 预留字段2
        /// </summary>
        public string Buy_Safetytwo
        {
            set { _buy_safetytwo = value; }
            get { return _buy_safetytwo; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Buy_Remark
        {
            set { _buy_remark = value; }
            get { return _buy_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Buy_LineCode
        {
            set { _buy_linecode = value; }
            get { return _buy_linecode; }
        }

        public string Buy_StockCode
        {
            get
            {
                return _buy_stockcode;
            }

            set
            {
                _buy_stockcode = value;
            }
        }

        public string Buy_StockName
        {
            get
            {
                return _buy_stockname;
            }

            set
            {
                _buy_stockname = value;
            }
        }

        public string Buy_Code
        {
            get
            {
                return _buy_code;
            }

            set
            {
                _buy_code = value;
            }
        }
        #endregion Model

    }
}


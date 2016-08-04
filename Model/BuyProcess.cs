using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BuyProcess
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public int BP_ID
        {
            get;
            set;
        }

        /// <summary>
        /// 编号
        /// </summary>
        public string BP_Code
        {
            get;
            set;
        }

        /// <summary>
        /// 对应货品栏号
        /// </summary>
        public string BP_SellLineno
        {
            get;
            set;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? BP_Datetime
        {
            get;
            set;
        }

        /// <summary>
        /// 所做操作
        /// </summary>
        public string BP_Opt
        {
            get;
            set;
        }

        /// <summary>
        /// 操作人
        /// </summary>
        public string BP_Ope
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string BP_Remark
        {
            get;
            set;
        }

        private int bp_clear = 1;
        /// <summary>
        /// 是否清除
        /// </summary>
        public int BP_Clear
        {
            get { return bp_clear; }
            set { bp_clear = value; }
        }
    }
}

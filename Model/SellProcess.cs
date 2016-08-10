using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SellProcess
    {
        private int _sp_ID;
        private string _sp_Code;
        private string _sp_SellLineno;
        private DateTime? _sp_Datetime;
        private string _sp_Opt;
        private string _sp_Ope;
        private string _sp_Remark;
        private int? _sp_Clear;

        /// <summary>
        /// 自增id
        /// </summary>
        public int Sp_ID
        {
            get
            {
                return _sp_ID;
            }

            set
            {
                _sp_ID = value;
            }
        }

        /// <summary>
        /// code
        /// </summary>
        public string Sp_Code
        {
            get
            {
                return _sp_Code;
            }

            set
            {
                _sp_Code = value;
            }
        }

        /// <summary>
        /// 销售单单号
        /// </summary>
        public string Sp_SellLineno
        {
            get
            {
                return _sp_SellLineno;
            }

            set
            {
                _sp_SellLineno = value;
            }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? Sp_Datetime
        {
            get
            {
                return _sp_Datetime;
            }

            set
            {
                _sp_Datetime = value;
            }
        }

        /// <summary>
        /// 所做操作
        /// </summary>
        public string Sp_Opt
        {
            get
            {
                return _sp_Opt;
            }

            set
            {
                _sp_Opt = value;
            }
        }

        /// <summary>
        /// 操作人
        /// </summary>
        public string Sp_Ope
        {
            get
            {
                return _sp_Ope;
            }

            set
            {
                _sp_Ope = value;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Sp_Remark
        {
            get
            {
                return _sp_Remark;
            }

            set
            {
                _sp_Remark = value;
            }
        }

        /// <summary>
        /// 是否清除
        /// </summary>
        public int? Sp_Clear
        {
            get
            {
                return _sp_Clear;
            }

            set
            {
                _sp_Clear = value;
            }
        }
    }
}

using DAL;
using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperUtility.Encrypt;

namespace BLL
{
    public class SellDetailManager
    {
        SellDetailService sds = new SellDetailService();
        /// <summary>
        /// 查询最近售价
        /// </summary>
        /// <returns></returns>
        public DataTable SelPriceByMaName(string Ma_Name)
        {
            return sds.SelPriceByMaName(Ma_Name);
        }
        /// <summary>
        /// 查询历史售价
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="maName"></param>
        /// <returns></returns>
        public DataTable SelAccountPriceByAccount(string clientName, string maName)
        {
            return sds.SelAccountPriceByAccount(clientName, maName);
        }		
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(SellDetail model)
        {
            return sds.Add(model);
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <returns></returns>
        public DataTable GetList(string strWhere)
        {
			CodingHelper ch = new CodingHelper();
            return ch.DataTableReCoding(sds.GetList(strWhere).Tables[0]);
        }    
        /// <summary>
        /// 查询历史折扣
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="maName"></param>
        /// <returns></returns>
        public DataTable SelDiscountByAccount(string clientName, string maName)
        {
            return sds.SelDiscountByAccount(clientName, maName);
        }
    }
}

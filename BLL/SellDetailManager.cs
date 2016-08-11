using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

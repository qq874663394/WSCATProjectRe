using DAL;
using Model;
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

        public DataTable SelAccountPriceByAccount(string account)
        {
            return sds.SelAccountPriceByAccount(account);
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
        public DataSet GetList(string strWhere)
        {
            return sds.GetList(strWhere);
        }
    }
}

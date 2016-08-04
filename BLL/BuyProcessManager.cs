using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;
using HelperUtility.Encrypt;

namespace BLL
{
    public class BuyProcessManager
    {
        private readonly BuyProcessService dal = new BuyProcessService();
        CodingHelper ch = new CodingHelper();
        /// <summary>
        /// 查询采购流程表
        /// </summary>
        /// <returns></returns>
        public DataTable SelBuyDataTable(string code)
        {
            return ch.DataTableReCoding((dal.SelBuyDataTable(code)));
        }
        /// <summary>
        /// 根据时间搜索
        /// </summary>
        /// <param name="stat">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns></returns>
        public DataTable SelTimeDataTable(DateTime stat, DateTime end)
        {
            return dal.SelTimeDataTable(stat, end);
        }
        /// <summary>
        /// 新增物流跟进
        /// </summary>
        /// <param name="buyprocess"></param>
        /// <returns></returns>
        public int InsBuyFollow(BuyProcess buyprocess)
        {
            return dal.InsBuyFollow(buyprocess);
        }
    }
}

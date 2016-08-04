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
    public class StockManager
    {
        private readonly StockService dal = new StockService();

        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelStockTable()
        {
            CodingHelper ch = new CodingHelper();
            return ch.DataTableReCoding(dal.SelStockTable());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class StockDetailManager
    {
        private readonly StockDetailService dal = new StockDetailService();
        /// <summary>
        /// 获得数据列表 
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
    }
}

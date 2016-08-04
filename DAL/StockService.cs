using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class StockService
    {
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelStockTable()
        {
            string sql = "select  * from T_Stock where Sto_Clear=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_Stock");
            return ds1.Tables[0];
        }
    }
}

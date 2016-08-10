using HelperUtility.Encrypt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SellDetailService
    {
        CodingHelper ch = new CodingHelper();
        /// <summary>
        /// 查询最近售价
        /// </summary>
        /// <returns></returns>
        public DataTable SelPriceByMaName(string Ma_Name)
        {
            string sql = string.Format("select top 5 '330A59182E3F583F' as 价格类型,Sell_DiscountAPrice as 最近售价,Sell_Discount as 折扣率 from T_SellDetail where Sell_MaName='{0}'", XYEEncoding.strCodeHex(Ma_Name));
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_SellDetail");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
    }
}

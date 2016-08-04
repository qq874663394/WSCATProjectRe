using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BuyDetailService
    {
        CodingHelper ch = new CodingHelper();
        public DataTable SelBuyDetailByCodeToTable(string code)
        {
            string sql = string.Format(@"select bd.Buy_Lineno as 编码,
bd.Buy_MaName as 货品名称,
bd.Buy_Model as 规格型号,
bd.Buy_Unit as 单位,
bd.Buy_CurNumber as 数量,
bd.Buy_DiscountAPrice as 单价,
bd.Buy_Discount as 折扣率,
bd.Buy_DiscountBPrice as  折后单价,
(bd.Buy_CurNumber*bd.Buy_DiscountBPrice) as 总金额
from T_BuyDetail bd,T_Buy buy
where buy.Buy_Code=bd.Buy_ID and buy.Buy_Code='{0}'", XYEEncoding.strCodeHex(code));
            SqlDataAdapter dapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            dapter.Fill(ds, "T_BuyDetail");
            return ds.Tables[0];
        }
    }
}

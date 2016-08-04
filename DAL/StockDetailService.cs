using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public  class StockDetailService
    {
        /// <summary>
        /// 获得数据列表 
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM  T_StockDetail td LEFT JOIN T_Stock ts ON ts.Sto_StCode = td.Sto_StoID LEFT JOIN T_Material tm ON  tm.Ma_Code = td.Sto_MaID ");
            strSql.Append(" where td.Sto_Clear=1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConllectionWaitService
    {
        public int InsConllectionWait(ConllectionWait cw)
        {
            string sql = string.Format(@"INSERT INTO T_ConllectionWait
           (CW_Code
           , CW_ClientCode
           , CW_ClientName
           , CW_AccountCode
           , CW_SellCode
           , CW_SalesMan
           , CW_Operation
           , CW_AuditMan
           , CW_Date
           , CW_Remark
           , CW_AuditStatus
           , CW_Clear)
     VALUES
           (
            @CW_Code
           , @CW_ClientCode
           , @CW_ClientName
           , @CW_AccountCode
           , @CW_SellCode
           , @CW_SalesMan
           , @CW_Operation
           , @CW_AuditMan
           , @CW_Date
           , @CW_Remark
           , @CW_AuditStatus
           , @CW_Clear)");
            SqlParameter[] sps =
            {
                new SqlParameter("@CW_Code",cw.CW_Code),
                new SqlParameter("@CW_ClientCode",cw.CW_ClientCode),
                new SqlParameter("@CW_ClientName",cw.CW_ClientName),
                new SqlParameter("@CW_AccountCode",cw.CW_AccountCode),
                new SqlParameter("@CW_SellCode",cw.CW_SellCode),
                new SqlParameter("@CW_SalesMan",cw.CW_SalesMan),
                new SqlParameter("@CW_Operation",cw.CW_Operation),
                new SqlParameter("@CW_AuditMan",cw.CW_AuditMan),
                new SqlParameter("@CW_Date",cw.CW_Date),
                new SqlParameter("@CW_Remark",cw.CW_Remark),
                new SqlParameter("@CW_AuditStatus",cw.CW_AuditStatus),
                new SqlParameter("@CW_Clear",cw.CW_Clear)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
    }
}

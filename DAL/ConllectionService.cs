using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConllectionService
    {
        public int InsConllection(Conllection conll)
        {
            string sql = string.Format(@"INSERT INTO T_Conllection
           (C_No
           , C_ClientCode
           , C_ClientName
           , C_AccountCode
           , C_AccountName
           , C_SellCode
           , C_SalesMan
           , C_SalesCode
           , C_Operation
           , C_AuditMan
           , C_Date
           , C_Remark
           , C_AuditStatus
           , C_Clear
           , C_Status
           , C_AmountPay
           , C_AmountPaid
           , C_MoneyOwed
           , C_SellCode)
     VALUES
           (
             @C_No
           , @C_ClientCode
           , @C_ClientName
           , @C_AccountCode
           , @C_AccountName
           , @C_SellCode
           , @C_SalesMan
           , @C_SalesCode
           , @C_Operation
           , @C_AuditMan
           , @C_Date
           , @C_Remark
           , @C_AuditStatus
           , @C_Clear
           , @C_Status
           , @C_AmountPay
           , @C_AmountPaid
           , @C_MoneyOwed
           , @C_SellCode
)");
            SqlParameter[] sps =
            {
                new SqlParameter("@C_No",conll.C_No),
                new SqlParameter("@C_ClientCode",conll.C_ClientCode),
                new SqlParameter("@C_ClientName",conll.C_ClientName),
                new SqlParameter("@C_AccountCode",conll.C_AccountCode),
                new SqlParameter("@C_AccountName",conll.C_AccountName),
                new SqlParameter("@C_SellCode",conll.C_SellCode),
                new SqlParameter("@C_SalesMan",conll.C_SalesMan),
                new SqlParameter("@C_SalesCode",conll.C_SalesCode),
                new SqlParameter("@C_Operation",conll.C_Operation),
                new SqlParameter("@C_AuditMan",conll.C_AuditMan),
                new SqlParameter("@C_Date",conll.C_Date),
                new SqlParameter("@C_Remark",conll.C_Remark),
                new SqlParameter("@C_AuditStatus",conll.C_AuditStatus),
                new SqlParameter("@C_Clear",conll.C_Clear),
                new SqlParameter("@C_Status",conll.C_Status),
                new SqlParameter("@C_AmountPay",conll.C_AmountPay),
                new SqlParameter("@C_AmountPaid",conll.C_AccountPaid),
                new SqlParameter("@C_MoneyOwed",conll.C_MoneyOwed),
                new SqlParameter("@C_SellCode",conll.C_SellCode)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
    }
}

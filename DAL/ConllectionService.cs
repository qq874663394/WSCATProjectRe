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
           , C_AccountPaid
           , C_MoneyOwed)
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
           , @C_AccountPaid
           , @C_MoneyOwed
)");
            SqlParameter[] sps =
            {
                new SqlParameter("@C_No",XYEEncoding.strCodeHex(conll.C_No)),
                new SqlParameter("@C_ClientCode",XYEEncoding.strCodeHex(conll.C_ClientCode)),
                new SqlParameter("@C_ClientName",XYEEncoding.strCodeHex(conll.C_ClientName)),
                new SqlParameter("@C_AccountCode",XYEEncoding.strCodeHex(conll.C_AccountCode)),
                new SqlParameter("@C_AccountName",XYEEncoding.strCodeHex(conll.C_AccountName)),
                new SqlParameter("@C_SellCode",XYEEncoding.strCodeHex(conll.C_SellCode)),
                new SqlParameter("@C_SalesMan",XYEEncoding.strCodeHex(conll.C_SalesMan)),
                new SqlParameter("@C_SalesCode",XYEEncoding.strCodeHex(conll.C_SalesCode)),
                new SqlParameter("@C_Operation",XYEEncoding.strCodeHex(conll.C_Operation)),
                new SqlParameter("@C_AuditMan",XYEEncoding.strCodeHex(conll.C_AuditMan)),
                new SqlParameter("@C_Date",conll.C_Date),
                new SqlParameter("@C_Remark",XYEEncoding.strCodeHex(conll.C_Remark)),
                new SqlParameter("@C_AuditStatus",conll.C_AuditStatus),
                new SqlParameter("@C_Clear",conll.C_Clear),
                new SqlParameter("@C_Status",conll.C_Status),
                new SqlParameter("@C_AmountPay",XYEEncoding.strCodeHex(conll.C_AmountPay)),
                new SqlParameter("@C_AccountPaid",XYEEncoding.strCodeHex(conll.C_AccountPaid)),
                new SqlParameter("@C_MoneyOwed",XYEEncoding.strCodeHex(conll.C_MoneyOwed))
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string C_No)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Conllection");
            strSql.Append(" where C_No=@C_No");
            SqlParameter[] parameters = {
                    new SqlParameter("@C_No", SqlDbType.VarChar,512)
            };
            parameters[0].Value = XYEEncoding.strCodeHex(C_No);

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
    }
}

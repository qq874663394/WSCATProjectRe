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
    public class ConllectionWaitService
    {
        CodingHelper ch = new CodingHelper();
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

        /// <summary>
        /// 获得资金收款单数据列表 
        /// </summary>
        public DataTable GetList()
        {
            string strsql = (@" select Sell_ID ,  
               (case 
               when Sell_IsPay=0 then '2A502E315B0A'
               when Sell_IsPay=1 then '565B53322E315B0A'
               when Sell_IsPay=2 then '36352E315B0A'
               end
               ) as Sell_IsPay ,
               Sell_Code,
               (case 
               when Sell_Review=1 then '36352D175E2F'
               else '2A502D175E2F' end
               ) as Sell_Review ,
               Sell_Date ,       
               Sell_fukuanfangshi ,
               Sell_OddMoney,
               Sell_InMoney,
               Sell_LastMoney,
               Sell_Operation ,
               Sell_Auditman ,
               Sell_Remark ,
               Sell_ClientName ,
               Sell_Salesman
                from T_Sell where Sell_Review=1 and (Sell_IsPay=0 or Sell_IsPay=1) ");
            SqlDataAdapter adapter = new SqlDataAdapter(strsql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Sell");
            return ch.DataTableReCoding(ds.Tables[0]);
        }

    }
}

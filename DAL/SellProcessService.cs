using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class SellProcessService
    {
        public int Add(SellProcess sps)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Sell(");
            strSql.Append("Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,");
            strSql.Append("Sell_IsPay,Sell_IsPutSto,Sell_PayMathod,Sell_GetDate,Sell_Logistics,Sell_LogCode,Sell_LogPhone,Sell_Clear,Sell_OddMoney,Sell_AccountCode,Sell_InMoney,Sell_LastMoney)");
            strSql.Append(" values (");
            strSql.Append("@Sell_Code,@Sell_Type,@Sell_Date,@Sell_TransportType,@Sell_Review,@Sell_ChangeDate,@Sell_Operation,@Sell_Auditman,@Sell_Remark,@Sell_Satetyone,@Sell_Satetytwo,");
            strSql.Append("@Sell_IsPay,@Sell_IsPutSto,@Sell_PayMathod,@Sell_GetDate,@Sell_Logistics,@Sell_LogCode,@Sell_LogPhone,@Sell_Clear,@Sell_OddMoney,@Sell_AccountCode,@Sell_InMoney,@Sell_LastMoney)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@SP_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_SellLineno", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_Datetime", SqlDbType.DateTime),
                    new SqlParameter("@SP_Opt", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_Ope", SqlDbType.Int,4),
                    new SqlParameter("@SP_Remark", SqlDbType.DateTime),
                    new SqlParameter("@SP_Clear", SqlDbType.NVarChar,512)};
            parameters[0].Value = sps.Sp_Code;
            parameters[1].Value = sps.Sp_SellLineno;
            parameters[2].Value = sps.Sp_Datetime;
            parameters[3].Value = sps.Sp_Opt;
            parameters[4].Value = sps.Sp_Ope;
            parameters[5].Value = sps.Sp_Remark;
            parameters[6].Value = sps.Sp_Clear;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
    }
}

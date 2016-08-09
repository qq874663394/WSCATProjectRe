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
    public class BuyService
    {
        CodingHelper ch = new CodingHelper();
        public DataTable SelBuyDataTableToCheck()
        {
            string sql = @"select 
            Distinct buy.Buy_ID as ID,
            buy.Buy_Code as 编号,
            Buy_Date as 单据日期,
            (case 
            when Buy_AuditStatus=1 then '36352D175E2F'
            else '2A502D175E2F' end
            ) as 审核状态,
            (case 
            when Buy_PurchaseStatus=0 then '36352805595F'
            when Buy_PurchaseStatus=1 then '591C34343234'
            when Buy_PurchaseStatus=2 then '50195C525B0A' 
            when Buy_PurchaseStatus=3 then '36355C525B0A'
            when Buy_PurchaseStatus=4 then '565B53325C525B0A' 
            when Buy_PurchaseStatus=5 then '53465F113234'  
            when Buy_PurchaseStatus=6 then '363551595F11'
            end
            ) as 单据状态,
            Buy_SupplierName as 供应商,
            su.Su_Bank as 结算账户,
            --结算账户，本次付款，总金额
            tbd.Buy_AmountMoney as 总金额,
            Buy_SalesMan as 业务员,
            buy.Buy_Remark as 备注
            from T_Buy buy
            left join T_BuyDetail tbd on buy.Buy_Code=tbd.Buy_Code
            left join T_Supplier su on buy.Buy_SupplierCode=su.Su_Code where buy.Buy_Clear=1";
            // and buy.Buy_PurchaseStatus=0 and buy.Buy_AuditStatus=0
            SqlDataAdapter dapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            dapter.Fill(ds, "T_Buy");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        public DataTable SelBuyDataTable()
        {
            string sql = "select * from T_Buy where Buy_Clear=1";
            SqlDataAdapter dapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            dapter.Fill(ds, "T_Buy");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        public DataTable SelBuyByCodeDataTable(string code)
        {
            string sql = string.Format("select * from T_Buy where Buy_Clear=1 and Buy_Code={0}", code);
            SqlDataAdapter dapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            dapter.Fill(ds, "T_Buy");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        public List<Buy> SelBuyByCode(string code)
        {
            List<Buy> list = new List<Buy>();
            string sql = string.Format("select * from T_Buy where Buy_Clear=1 and Buy_Code={0}", code);
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Buy buy = new Buy()
                {
                    Buy_ID = Convert.ToInt32(read["Buy_ID"]),
                    Buy_Code = XYEEncoding.strHexDecode(read["Buy_Code"].ToString()),
                    Buy_Date = Convert.ToDateTime(read["Buy_Date"])
                };
                list.Add(buy);
            }
            return list;
        }
        public Buy SelBuyByCodeToModel(string code)
        {
            string sql = string.Format("select * from T_Buy where Buy_Clear=1 and Buy_Code='{0}'", XYEEncoding.strCodeHex(code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Buy b = new Buy();
                b.Buy_ID = Convert.ToInt32(read["Buy_ID"]);
                b.Buy_Code = XYEEncoding.strHexDecode(read["Buy_Code"].ToString());
                b.Buy_Date = Convert.ToDateTime(read["Buy_Date"]);
                b.Buy_StockCode = XYEEncoding.strHexDecode(read["Buy_StockCode"].ToString());
                b.Buy_StockName = XYEEncoding.strHexDecode(read["Buy_StockName"].ToString());
                b.Buy_PurchaseStatus = read["Buy_PurchaseStatus"] == DBNull.Value ? 0 : Convert.ToInt32(read["Buy_PurchaseStatus"]);
                b.Buy_AuditStatus = read["Buy_AuditStatus"] == DBNull.Value ? 0 : Convert.ToInt32(read["Buy_AuditStatus"]);
                b.Buy_PurchaserID = XYEEncoding.strHexDecode(read["Buy_PurchaserID"].ToString());
                b.Buy_SalesMan = XYEEncoding.strHexDecode(read["Buy_SalesMan"].ToString());
                b.Buy_Operation = XYEEncoding.strHexDecode(read["Buy_Operation"].ToString());
                b.Buy_AuditMan = XYEEncoding.strHexDecode(read["Buy_AuditMan"].ToString());
                b.Buy_Remark = XYEEncoding.strHexDecode(read["Buy_Remark"].ToString());
                b.Buy_Clear = read["Buy_Clear"] == DBNull.Value ? 0 : Convert.ToInt32(read["Buy_Clear"]);
                b.Buy_SupplierCode = XYEEncoding.strHexDecode(read["Buy_SupplierCode"].ToString());
                b.Buy_SupplierName = XYEEncoding.strHexDecode(read["Buy_SupplierName"].ToString());
                b.Buy_Class = XYEEncoding.strHexDecode(read["Buy_Class"].ToString());
                b.Buy_IsPay = read["Buy_IsPay"] == DBNull.Value ? 0 : Convert.ToInt32(read["Buy_IsPay"]);
                b.Buy_PayMethod = read["Buy_PayMethod"] == DBNull.Value ? 0 : Convert.ToInt32(read["Buy_PayMethod"]);
                b.Buy_IsPutSto = read["Buy_IsPutSto"] == DBNull.Value ? 0 : Convert.ToInt32(read["Buy_IsPutSto"]);
                b.Buy_GetDate = read["Buy_GetDate"] == DBNull.Value ? Convert.ToDateTime("1990-01-01") : Convert.ToDateTime(read["Buy_GetDate"]);
                b.Buy_Logistics = XYEEncoding.strHexDecode(read["Buy_Logistics"].ToString());
                b.Buy_LogPhone = XYEEncoding.strHexDecode(read["Buy_LogPhone"].ToString());
                b.Buy_LogCode = XYEEncoding.strHexDecode(read["Buy_LogCode"].ToString());
                return b;
            }
            return null;
        }
        public int UpdateBuyByCode(int purchaseStatus,int auditStatus,string code)
        {
            string sql = string.Format("update T_Buy set Buy_PurchaseStatus={0},Buy_AuditStatus={1} where Buy_Code='{2}'",purchaseStatus,auditStatus, XYEEncoding.strCodeHex(code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        /// <summary>
        /// 更新付款状态
        /// </summary>
        public bool PaymentUpdate(string code, int shu)
        {
            string sql = string.Format("update T_Buy set Buy_PurchaseStatus='{0}' where Buy_Code in( select Buy_BCode from T_BuyPayment where Buy_Code='{1}')", shu, code);
            int rows = DbHelperSQL.ExecuteSql(sql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // <summary>
        /// 更新物流信息以及申请状态
        /// </summary>
        public bool LogisticalUpdate(Buy model)
        {
            string sql = string.Format(@"update T_Buy set 
            Buy_GetDate='{0}',
            Buy_LogCode='{1}',
            Buy_Logistics='{2}',
            Buy_LogPhone='{3}',
            Buy_PurchaseStatus=6 
            where Buy_Code='{4}'", model.Buy_GetDate, model.Buy_LogCode, model.Buy_Logistics, model.Buy_LogPhone, model.Buy_Code);
            int rows = DbHelperSQL.ExecuteSql(sql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获得应付款单数据列表 
        /// </summary>
        public DataTable GetYinFuList()
        {
            string strsql = (@" select Buy_Class as 单据类型 ,Buy_Code as 单据编号,   (case 
               when Buy_Zhuangtai=1 then '36355C525B0A'
               else '2A505C525B0A' end
               ) as 是否付款,
              (case when Buy_States=1 then '36352D175E2F'
               else '2A502D175E2F' end
               ) as 单据状态,
               Buy_SuName as 来往单位,
               Buy_AccountName as 结算账户,
               Buy_AmountPay as 应付金额,
               Buy_AccountPaid as 付款金额,
               Buy_moneyOwed as 未付金额,
               Buy_SalesMan as 业务员,
               Buy_Remark as 摘要
                from T_BuyPayment  where Buy_Class='37425C525B0A5141'");
            SqlDataAdapter adapter = new SqlDataAdapter(strsql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_BuyPayment");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        /// <summary>
        /// 是否存在已审核和已付款的该记录
        /// </summary>
        public bool Exists(string Buy_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select COUNT(1) from T_Buy where Buy_AuditStatus=1 and Buy_PurchaseStatus=4");
            strSql.Append(" and Buy_Code=@Buy_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Buy_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Buy_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 提交申请单更新状态
        /// </summary>
        /// <param name="code"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        public bool PaymentUpdateByCode(string code, int shu)
        {
            string sql = string.Format("update T_Buy set Buy_PurchaseStatus='{0}' where Buy_Code ='{1}'", shu, code);
            int rows = DbHelperSQL.ExecuteSql(sql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量增加多条数据 
        /// </summary>
        /// <param name="sqlList">要增加的sql</param>
        /// <returns>影响行数</returns>
        public int AddBatch(List<string> sqlList)
        {
            if (sqlList.Count > 0)
            {
                int influence = DbHelperSQL.ExecuteSqlTran(sqlList);
                return influence;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 批量增加多条数据到销售单
        /// </summary>
        /// <param name="buyValues">主单数据,数量为22个字段</param>
        /// <param name="detailList">从单数据,商品的信息.17个字段</param>
        /// <returns>受影响的行数</returns>
        public int AddBatch(Buy buy, List<BuyDetail> buyDetail)
        {
            if (buy == null)
            {
                return 0;
            }
            if (buyDetail.Count() < 1)
            {
                return 0;
            }
            StringBuilder sb;
            List<string> sqlList = new List<string>();
            sb = new StringBuilder();
            sb.Append("insert into T_Buy(");
            sb.Append("Buy_Code,Buy_Date,");
            sb.Append("Buy_SupplierCode,Buy_SupplierName,Buy_PurchaseStatus,Buy_AuditStatus,");
            sb.Append("Buy_PurchaserID,Buy_SalesMan,Buy_Operation,Buy_AuditMan,Buy_Remark,Buy_Clear,Buy_IsPay,Buy_PayMethod,");
            sb.Append("Buy_IsPutSto,Buy_Class");
            sb.Append(") values ('");
            sb.Append(buy.Buy_Code + "','" + buy.Buy_Date + "','" + buy.Buy_SupplierCode + "','"
                + buy.Buy_SupplierName + "'," + buy.Buy_PurchaseStatus + "," + buy.Buy_AuditStatus + ",'"
                + buy.Buy_PurchaserID + "','" + buy.Buy_SalesMan + "','" + buy.Buy_Operation + "','"
                + buy.Buy_AuditMan + "','" + buy.Buy_Remark + "'," + buy.Buy_Clear + ","
                + buy.Buy_IsPay + "," + buy.Buy_PayMethod + "," + buy.Buy_IsPutSto + ",'"
                + buy.Buy_Class + "')");
            sqlList.Add(sb.ToString());

            foreach (BuyDetail value in buyDetail)
            {
                sb = new StringBuilder();
                sb.Append("insert into T_BuyDetail(");
                sb.Append("Buy_LineCode,Buy_StockCode,Buy_StockName,Buy_Code,Buy_MaID,Buy_MaName,");
                sb.Append("Buy_Model,Buy_Unit,Buy_CurNumber,Buy_DiscountAPrice,");
                sb.Append("Buy_Discount,Buy_DiscountBPrice,Buy_AmountMoney,Buy_Clear,Buy_Remark");
                sb.Append(") values ('");
                sb.Append(value.Buy_LineCode + "','" + value.Buy_StockCode + "','" +
                    value.Buy_StockName + "','" + value.Buy_Code + "','" + value.Buy_MaID + "','" +
                    value.Buy_MaName + "','" + value.Buy_Model + "','" + value.Buy_Unit + "','" +
                    value.Buy_CurNumber + "','" + value.Buy_DiscountAPrice + "','" + value.Buy_Discount + "','" +
                    value.Buy_DiscountBPrice + "','" + value.Buy_AmountMoney + "'," + value.Buy_Clear + ",'" +
                    value.Buy_Remark + "')");
                sqlList.Add(sb.ToString());
            }
            try
            {
                int influenceRow = AddBatch(sqlList);
                return influenceRow;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

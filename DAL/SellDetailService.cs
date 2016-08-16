using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
using HelperUtility.Encrypt;

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
            string sql = string.Format("select top 5 '330A59182E3F583F' as 价格类型,Sell_DiscountAPrice as 价格,Sell_Discount as 折扣率 from T_SellDetail where Sell_MaName='{0}' order by Sell_Lineno desc", XYEEncoding.strCodeHex(Ma_Name));
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_SellDetail");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        /// <summary>
        /// 查询历史售价
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="maName"></param>
        /// <returns></returns>
        public DataTable SelAccountPriceByAccount(string clientName,string maName)
        {
            string sql = string.Format(@"select DISTINCT '241E2E532E3F583F' as 价格类型,sd.Sell_DiscountAPrice as 价格,sd.Sell_Discount as 折扣率 from T_Sell s
inner join T_SellDetail sd on  sd.Sell_Code = s.Sell_Code
where s.Sell_ClientName = '{0}' and sd.Sell_MaName = '{1}' order by 价格", XYEEncoding.strCodeHex(clientName), XYEEncoding.strCodeHex(maName));
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"T_SellDetail");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        /// <summary>
        /// 查询历史折扣
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="maName"></param>
        /// <returns></returns>
        public DataTable SelDiscountByAccount(string clientName, string maName)
        {
            string sql = string.Format(@"select DISTINCT '241E2E532E3F583F' as 价格类型,sd.Sell_DiscountAPrice as 价格,sd.Sell_Discount as 折扣率 from T_Sell s
inner join T_SellDetail sd on  sd.Sell_Code = s.Sell_Code
where s.Sell_ClientName = '{0}' and sd.Sell_MaName = '{1}'", XYEEncoding.strCodeHex(clientName), XYEEncoding.strCodeHex(maName));
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_SellDetail");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        /// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SellDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_SellDetail(");
            strSql.Append("Sell_Code,Sell_StockCode,Sell_StockName,Sell_LineCode,Sell_MaID,Sell_MaName,Sell_Model,Sell_Unit,Sell_CurNumber,");
            strSql.Append("Sell_ReNumber,Sell_LostNumber,Sell_DiscountAPrice,Sell_Discount,Sell_DiscountBPrice,Sell_Money,Sell_Clear,Sell_Safetyone,Sell_Safetytwo,Sell_Remark)");
            strSql.Append(" values (");
            strSql.Append("@Sell_Code,@Sell_StockCode,@Sell_StockName,@Sell_LineCode,@Sell_MaID,@Sell_MaName,@Sell_Model,@Sell_Unit,@Sell_CurNumber,");
            strSql.Append("@Sell_ReNumber,@Sell_LostNumber,@Sell_DiscountAPrice,@Sell_Discount,@Sell_DiscountBPrice,@Sell_Money,@Sell_Clear,@Sell_Safetyone,@Sell_Safetytwo,@Sell_Remark)");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_StockCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_StockName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LineCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_MaID", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_MaName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Model", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Unit", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_CurNumber", SqlDbType.Decimal),
                    new SqlParameter("@Sell_ReNumber", SqlDbType.Decimal),
                    new SqlParameter("@Sell_LostNumber", SqlDbType.Decimal),
                    new SqlParameter("@Sell_DiscountAPrice", SqlDbType.Decimal),
                    new SqlParameter("@Sell_Discount", SqlDbType.Decimal),
                    new SqlParameter("@Sell_DiscountBPrice", SqlDbType.Decimal),
                    new SqlParameter("@Sell_Money", SqlDbType.Decimal),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Sell_Safetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Safetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar,1024)};
            parameters[0].Value = model.Sell_Code;
            parameters[1].Value = model.Sell_StockCode;
            parameters[2].Value = model.Sell_StockName;
            parameters[3].Value = model.Sell_LineCode;
            parameters[4].Value = model.Sell_MaID;
            parameters[5].Value = model.Sell_MaName;
            parameters[6].Value = model.Sell_Model;
            parameters[7].Value = model.Sell_Unit;
            parameters[8].Value = model.Sell_CurNumber;
            parameters[9].Value = model.Sell_ReNumber;
            parameters[10].Value = model.Sell_LostNumber;
            parameters[11].Value = model.Sell_DiscountAPrice;
            parameters[12].Value = model.Sell_Discount;
            parameters[13].Value = model.Sell_DiscountBPrice;
            parameters[14].Value = model.Sell_Money;
            parameters[15].Value = model.Sell_Clear;
            parameters[16].Value = model.Sell_Safetyone;
            parameters[17].Value = model.Sell_Safetytwo;
            parameters[18].Value = model.Sell_Remark;

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

        /// <summary>
        /// 根据where条件查询所有的数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sell_Code,Sell_StockName,Sell_MaID,Sell_MaName,");
            strSql.Append("Sell_Model,Sell_Unit,Sell_CurNumber,Sell_ReNumber,Sell_LostNumber,");
            strSql.Append("Sell_Discount,Sell_DiscountBPrice,Sell_Money,Sell_Remark");
            strSql.Append(" FROM T_SellDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}

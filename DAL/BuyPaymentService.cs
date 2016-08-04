using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;
using HelperUtility.Encrypt;

namespace DAL
{
    public class BuyPaymentService
    {

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Buy_ID", "T_BuyPayment");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Buy_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_BuyPayment");
            strSql.Append(" where Buy_ID=@Buy_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Buy_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Buy_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BuyPayment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_BuyPayment(");
            strSql.Append("Buy_Code,Buy_SuCode,Buy_SuName,Buy_BCode,Buy_Name,Buy_AccountCode,Buy_AccountName,Buy_Date,Buy_AmountPay,Buy_AccountPaid,Buy_moneyOwed,Buy_SalesMan,Buy_SalesCode,Buy_AuditMan,Buy_Premoney,Buy_Actmoney,Buy_Zhuangtai,Buy_Remark,Buy_Satetyone,Buy_Satetytwo,Buy_Clear,Buy_States)");
            strSql.Append(" values (");
            strSql.Append("@Buy_Code,@Buy_SuCode,@Buy_SuName,@Buy_BCode,@Buy_Name,@Buy_AccountCode,@Buy_AccountName,@Buy_Date,@Buy_AmountPay,@Buy_AccountPaid,@Buy_moneyOwed,@Buy_SalesMan,@Buy_SalesCode,@Buy_AuditMan,@Buy_Premoney,@Buy_Actmoney,@Buy_Zhuangtai,@Buy_Remark,@Buy_Satetyone,@Buy_Satetytwo,@Buy_Clear,@Buy_States)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Buy_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SuCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SuName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_BCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AccountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AccountName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Date", SqlDbType.DateTime),
                    new SqlParameter("@Buy_AmountPay", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AccountPaid", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_moneyOwed", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SalesMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SalesCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AuditMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Premoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Actmoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Zhuangtai", SqlDbType.Money,8),
                    new SqlParameter("@Buy_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@Buy_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Buy_States", SqlDbType.Int,4)};
            parameters[0].Value = model.Buy_Code;
            parameters[1].Value = model.Buy_SuCode;
            parameters[2].Value = model.Buy_SuName;
            parameters[3].Value = model.Buy_BCode;
            parameters[4].Value = model.Buy_Name;
            parameters[5].Value = model.Buy_AccountCode;
            parameters[6].Value = model.Buy_AccountName;
            parameters[7].Value = model.Buy_Date;
            parameters[8].Value = model.Buy_AmountPay;
            parameters[9].Value = model.Buy_AccountPaid;
            parameters[10].Value = model.Buy_moneyOwed;
            parameters[11].Value = model.Buy_SalesMan;
            parameters[12].Value = model.Buy_SalesCode;
            parameters[13].Value = model.Buy_AuditMan;
            parameters[14].Value = model.Buy_Premoney;
            parameters[15].Value = model.Buy_Actmoney;
            parameters[16].Value = model.Buy_Zhuangtai;
            parameters[17].Value = model.Buy_Remark;
            parameters[18].Value = model.Buy_Satetyone;
            parameters[19].Value = model.Buy_Satetytwo;
            parameters[20].Value = model.Buy_Clear;
            parameters[21].Value = model.Buy_States;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(BuyPayment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_BuyPayment set ");
            strSql.Append("Buy_Code=@Buy_Code,");
            strSql.Append("Buy_SuCode=@Buy_SuCode,");
            strSql.Append("Buy_SuName=@Buy_SuName,");
            strSql.Append("Buy_BCode=@Buy_BCode,");
            strSql.Append("Buy_Name=@Buy_Name,");
            strSql.Append("Buy_AccountCode=@Buy_AccountCode,");
            strSql.Append("Buy_AccountName=@Buy_AccountName,");
            strSql.Append("Buy_Date=@Buy_Date,");
            strSql.Append("Buy_AmountPay=@Buy_AmountPay,");
            strSql.Append("Buy_AccountPaid=@Buy_AccountPaid,");
            strSql.Append("Buy_moneyOwed=@Buy_moneyOwed,");
            strSql.Append("Buy_SalesMan=@Buy_SalesMan,");
            strSql.Append("Buy_SalesCode=@Buy_SalesCode,");
            strSql.Append("Buy_AuditMan=@Buy_AuditMan,");
            strSql.Append("Buy_Premoney=@Buy_Premoney,");
            strSql.Append("Buy_Actmoney=@Buy_Actmoney,");
            strSql.Append("Buy_Zhuangtai=@Buy_Zhuangtai,");
            strSql.Append("Buy_Remark=@Buy_Remark,");
            strSql.Append("Buy_Satetyone=@Buy_Satetyone,");
            strSql.Append("Buy_Satetytwo=@Buy_Satetytwo,");
            strSql.Append("Buy_Clear=@Buy_Clear,");
            strSql.Append("Buy_States=@Buy_States");
            strSql.Append(" where Buy_ID=@Buy_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Buy_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SuCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SuName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_BCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AccountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AccountName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Date", SqlDbType.DateTime),
                    new SqlParameter("@Buy_AmountPay", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AccountPaid", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_moneyOwed", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SalesMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_SalesCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_AuditMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Premoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Actmoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Zhuangtai", SqlDbType.Money,8),
                    new SqlParameter("@Buy_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@Buy_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Buy_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Buy_States", SqlDbType.Int,4),
                    new SqlParameter("@Buy_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Buy_Code;
            parameters[1].Value = model.Buy_SuCode;
            parameters[2].Value = model.Buy_SuName;
            parameters[3].Value = model.Buy_BCode;
            parameters[4].Value = model.Buy_Name;
            parameters[5].Value = model.Buy_AccountCode;
            parameters[6].Value = model.Buy_AccountName;
            parameters[7].Value = model.Buy_Date;
            parameters[8].Value = model.Buy_AmountPay;
            parameters[9].Value = model.Buy_AccountPaid;
            parameters[10].Value = model.Buy_moneyOwed;
            parameters[11].Value = model.Buy_SalesMan;
            parameters[12].Value = model.Buy_SalesCode;
            parameters[13].Value = model.Buy_AuditMan;
            parameters[14].Value = model.Buy_Premoney;
            parameters[15].Value = model.Buy_Actmoney;
            parameters[16].Value = model.Buy_Zhuangtai;
            parameters[17].Value = model.Buy_Remark;
            parameters[18].Value = model.Buy_Satetyone;
            parameters[19].Value = model.Buy_Satetytwo;
            parameters[20].Value = model.Buy_Clear;
            parameters[21].Value = model.Buy_States;
            parameters[22].Value = model.Buy_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Buy_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_BuyPayment ");
            strSql.Append(" where Buy_ID=@Buy_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Buy_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Buy_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Buy_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_BuyPayment ");
            strSql.Append(" where Buy_ID in (" + Buy_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        /// 得到一个对象实体
        /// </summary>
        public BuyPayment GetModel(string Buy_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Buy_ID,Buy_Code,Buy_SuCode,Buy_SuName,Buy_BCode,Buy_Name,Buy_AccountCode,Buy_AccountName,Buy_Date,Buy_AmountPay,Buy_AccountPaid,Buy_moneyOwed,Buy_SalesMan,Buy_SalesCode,Buy_AuditMan,Buy_Premoney,Buy_Actmoney,Buy_Zhuangtai,Buy_Remark,Buy_Satetyone,Buy_Satetytwo,Buy_Clear,Buy_States from T_BuyPayment ");
            strSql.Append(" where Buy_Code=@Buy_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Buy_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Buy_Code;

            BuyPayment model = new BuyPayment();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BuyPayment DataRowToModel(DataRow row)
        {
            BuyPayment model = new BuyPayment();
            if (row != null)
            {
                if (row["Buy_ID"] != null && row["Buy_ID"].ToString() != "")
                {
                    model.Buy_ID = int.Parse(row["Buy_ID"].ToString());
                }
                if (row["Buy_Code"] != null)
                {
                    model.Buy_Code = row["Buy_Code"].ToString();
                }
                if (row["Buy_SuCode"] != null)
                {
                    model.Buy_SuCode = row["Buy_SuCode"].ToString();
                }
                if (row["Buy_SuName"] != null)
                {
                    model.Buy_SuName = row["Buy_SuName"].ToString();
                }
                if (row["Buy_BCode"] != null)
                {
                    model.Buy_BCode = row["Buy_BCode"].ToString();
                }
                if (row["Buy_Name"] != null)
                {
                    model.Buy_Name = row["Buy_Name"].ToString();
                }
                if (row["Buy_AccountCode"] != null)
                {
                    model.Buy_AccountCode = row["Buy_AccountCode"].ToString();
                }
                if (row["Buy_AccountName"] != null)
                {
                    model.Buy_AccountName = row["Buy_AccountName"].ToString();
                }
                if (row["Buy_Date"] != null && row["Buy_Date"].ToString() != "")
                {
                    model.Buy_Date = DateTime.Parse(row["Buy_Date"].ToString());
                }
                if (row["Buy_AmountPay"] != null)
                {
                    model.Buy_AmountPay = row["Buy_AmountPay"].ToString();
                }
                if (row["Buy_AccountPaid"] != null)
                {
                    model.Buy_AccountPaid = row["Buy_AccountPaid"].ToString();
                }
                if (row["Buy_moneyOwed"] != null)
                {
                    model.Buy_moneyOwed = row["Buy_moneyOwed"].ToString();
                }
                if (row["Buy_SalesMan"] != null)
                {
                    model.Buy_SalesMan = row["Buy_SalesMan"].ToString();
                }
                if (row["Buy_SalesCode"] != null)
                {
                    model.Buy_SalesCode = row["Buy_SalesCode"].ToString();
                }
                if (row["Buy_AuditMan"] != null)
                {
                    model.Buy_AuditMan = row["Buy_AuditMan"].ToString();
                }
                if (row["Buy_Premoney"] != null)
                {
                    model.Buy_Premoney = row["Buy_Premoney"].ToString();
                }
                if (row["Buy_Actmoney"] != null)
                {
                    model.Buy_Actmoney = row["Buy_Actmoney"].ToString();
                }
                if (row["Buy_Zhuangtai"] != null && row["Buy_Zhuangtai"].ToString() != "")
                {
                    model.Buy_Zhuangtai = int.Parse(row["Buy_Zhuangtai"].ToString());
                }
                if (row["Buy_Remark"] != null)
                {
                    model.Buy_Remark = row["Buy_Remark"].ToString();
                }
                if (row["Buy_Satetyone"] != null)
                {
                    model.Buy_Satetyone = row["Buy_Satetyone"].ToString();
                }
                if (row["Buy_Satetytwo"] != null)
                {
                    model.Buy_Satetytwo = row["Buy_Satetytwo"].ToString();
                }
                if (row["Buy_Clear"] != null && row["Buy_Clear"].ToString() != "")
                {
                    model.Buy_Clear = int.Parse(row["Buy_Clear"].ToString());
                }
                if (row["Buy_States"] != null && row["Buy_States"].ToString() != "")
                {
                    model.Buy_States = int.Parse(row["Buy_States"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Buy_ID,Buy_Code,Buy_SuCode,Buy_SuName,Buy_BCode,Buy_Name,Buy_AccountCode,Buy_AccountName,Buy_Date,Buy_AmountPay,Buy_AccountPaid,Buy_moneyOwed,Buy_SalesMan,Buy_SalesCode,Buy_AuditMan,Buy_Premoney,Buy_Actmoney,Buy_Zhuangtai,Buy_Remark,Buy_Satetyone,Buy_Satetytwo,Buy_Clear,Buy_States ");
            strSql.Append(" FROM T_BuyPayment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Buy_ID,Buy_Code,Buy_SuCode,Buy_SuName,Buy_BCode,Buy_Name,Buy_AccountCode,Buy_AccountName,Buy_Date,Buy_AmountPay,Buy_AccountPaid,Buy_moneyOwed,Buy_SalesMan,Buy_SalesCode,Buy_AuditMan,Buy_Premoney,Buy_Actmoney,Buy_Zhuangtai,Buy_Remark,Buy_Satetyone,Buy_Satetytwo,Buy_Clear,Buy_States ");
            strSql.Append(" FROM T_BuyPayment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_BuyPayment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Buy_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_BuyPayment T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_BuyPayment";
			parameters[1].Value = "Buy_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 更新付款状态和审核状态是方法
        /// </summary>
        public bool PaymentUpdate(BuyPayment model)
        {
            string sql = string.Format(@"update T_BuyPayment set 
            Buy_Zhuangtai=1,
            Buy_States=1,
            Buy_Actmoney='{0}',
            Buy_AuditMan='{1}',
            Buy_Remark='{2}' 
            where  Buy_Class = '37425C525B0A5141' and Buy_Code = '{3}'", model.Buy_Actmoney, model.Buy_AuditMan, model.Buy_Remark, model.Buy_Code);
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
        /// 更改审核状态
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool ReveiweUpdate(string code)
        {
            string sql = string.Format("update T_BuyPayment set Buy_States=1 where Buy_Code='{0}'", code);
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
        /// 新增申请付款单
        /// </summary>
        /// <param name="buypay"></param>
        /// <returns></returns>
        public int InsBuyPayment(BuyPayment buypay)
        {
            string sql = @"INSERT INTO T_BuyPayment  
           (Buy_Code
           ,Buy_BCode
           ,Buy_Date
           ,Buy_SuName
           ,Buy_AccountName
           ,Buy_AmountPay
           ,Buy_moneyOwed
           ,Buy_AccountPaid
           ,Buy_SalesMan
           ,Buy_Remark
           ,Buy_States
           ,Buy_Class) 
          Values
          (@Buy_Code
           ,@Buy_BCode
           ,@Buy_Date
           ,@Buy_SuName
           ,@Buy_AccountName
           ,@Buy_AmountPay
           ,@Buy_moneyOwed
           ,@Buy_AccountPaid
           ,@Buy_SalesMan
           ,@Buy_Remark
           ,@Buy_States
            ,@Buy_Class)";
            SqlParameter[] sps =
                {
                new SqlParameter ("@Buy_Code",XYEEncoding.strCodeHex(buypay.Buy_Code)),
                new SqlParameter ("@Buy_BCode",XYEEncoding.strCodeHex(buypay.Buy_BCode)),
                new SqlParameter("@Buy_Date",(buypay.Buy_Date)),
                new SqlParameter("@Buy_SuName",XYEEncoding.strCodeHex( buypay.Buy_SuName)),
                new SqlParameter("@Buy_AccountName",XYEEncoding.strCodeHex(buypay.Buy_AccountName)),
                new SqlParameter("@Buy_AmountPay",XYEEncoding.strCodeHex(buypay.Buy_AmountPay)),
                new SqlParameter("@Buy_moneyOwed", XYEEncoding.strCodeHex(buypay.Buy_moneyOwed)),
                new SqlParameter("@Buy_AccountPaid", XYEEncoding.strCodeHex(buypay.Buy_AccountPaid)),
                new SqlParameter("@Buy_SalesMan",XYEEncoding.strCodeHex( buypay.Buy_SalesMan)),
                new SqlParameter("@Buy_Remark",buypay.Buy_Remark),
                new SqlParameter("@Buy_States",buypay.Buy_States),
                new SqlParameter("@Buy_Class",buypay.Buy_Class)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        /// <summary>
        /// 根据采购单号查询商品明细
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet SelEmp(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select buy.Buy_StockName as 仓库名称  
                , b.Buy_MaID as 货品编号
                , b.Buy_MaName as 货品名称
                , b.Buy_Model as 规格型号
                , b.Buy_Unit as 单位
                , b.Buy_CurNumber as 数量
                , b.Buy_AmountMoney as 单价
                , b.Buy_Discount as 折扣率
                , b.Buy_DiscountAPrice as 折扣后的单价
                , b.Buy_Remark as 备注 from T_BuyDetail b  ");
            strSql.Append(" left join  T_Buy buy  on b.Buy_ID=buy.Buy_Code  ");
            strSql.Append("  where b.Buy_Clear=1 and buy.Buy_AuditStatus=1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

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
    public class SellService
    {
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Sell_ID", "T_Sell");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Sell_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Sell");
            strSql.Append(" where Sell_ID=@Sell_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Sell model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Sell(");
            strSql.Append("Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,Sell_Clear)");
            strSql.Append(" values (");
            strSql.Append("@Sell_Code,@Sell_Type,@Sell_Date,@Sell_TransportType,@Sell_Review,@Sell_ChangeDate,@Sell_Operation,@Sell_Auditman,@Sell_Remark,@Sell_Satetyone,@Sell_Satetytwo,@Sell_Clear)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Date", SqlDbType.DateTime),
                    new SqlParameter("@Sell_TransportType", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Review", SqlDbType.Int,4),
                    new SqlParameter("@Sell_ChangeDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Operation", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Auditman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4)};
            parameters[0].Value = model.Sell_Code;
            parameters[1].Value = model.Sell_Type;
            parameters[2].Value = model.Sell_Date;
            parameters[3].Value = model.Sell_TransportType;
            parameters[4].Value = model.Sell_Review;
            parameters[5].Value = model.Sell_ChangeDate;
            parameters[6].Value = model.Sell_Operation;
            parameters[7].Value = model.Sell_Auditman;
            parameters[8].Value = model.Sell_Remark;
            parameters[9].Value = model.Sell_Satetyone;
            parameters[10].Value = model.Sell_Satetytwo;
            parameters[11].Value = model.Sell_Clear;

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
        public bool Update(Sell model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Sell set ");
            strSql.Append("Sell_Type=@Sell_Type,");
            strSql.Append("Sell_Date=@Sell_Date,");
            strSql.Append("Sell_TransportType=@Sell_TransportType,");
            strSql.Append("Sell_Review=@Sell_Review,");
            strSql.Append("Sell_ChangeDate=@Sell_ChangeDate,");
            strSql.Append("Sell_Operation=@Sell_Operation,");
            strSql.Append("Sell_Auditman=@Sell_Auditman,");
            strSql.Append("Sell_Remark=@Sell_Remark,");
            strSql.Append("Sell_Satetyone=@Sell_Satetyone,");
            strSql.Append("Sell_Satetytwo=@Sell_Satetytwo,");
            strSql.Append("Sell_Clear=@Sell_Clear");
            strSql.Append(" where Sell_Code=@Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Date", SqlDbType.DateTime),
                    new SqlParameter("@Sell_TransportType", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Review", SqlDbType.Int,4),
                    new SqlParameter("@Sell_ChangeDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Operation", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Auditman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.Sell_Type;
            parameters[1].Value = model.Sell_Date;
            parameters[2].Value = model.Sell_TransportType;
            parameters[3].Value = model.Sell_Review;
            parameters[4].Value = model.Sell_ChangeDate;
            parameters[5].Value = model.Sell_Operation;
            parameters[6].Value = model.Sell_Auditman;
            parameters[7].Value = model.Sell_Remark;
            parameters[8].Value = model.Sell_Satetyone;
            parameters[9].Value = model.Sell_Satetytwo;
            parameters[10].Value = model.Sell_Clear;
            parameters[11].Value = model.Sell_Code;

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
        public bool Delete(int Sell_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Sell ");
            strSql.Append(" where Sell_ID=@Sell_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_ID;

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
        /// 批量删除数据如果
        /// </summary>
        public bool DeleteList(string Sell_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Sell ");
            strSql.Append(" where Sell_ID in (" + Sell_IDlist + ")  ");
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
        public Sell GetModel(int Sell_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,Sell_Clear from T_Sell ");
            strSql.Append(" where Sell_ID=@Sell_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_ID;

            Sell model = new Sell();
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
        public Sell DataRowToModel(DataRow row)
        {
            Sell model = new Sell();
            if (row != null)
            {
                if (row["Sell_ID"] != null && row["Sell_ID"].ToString() != "")
                {
                    model.Sell_ID = int.Parse(row["Sell_ID"].ToString());
                }
                if (row["Sell_Code"] != null)
                {
                    model.Sell_Code = row["Sell_Code"].ToString();
                }
                if (row["Sell_Type"] != null)
                {
                    model.Sell_Type = row["Sell_Type"].ToString();
                }
                if (row["Sell_Date"] != null && row["Sell_Date"].ToString() != "")
                {
                    model.Sell_Date = DateTime.Parse(row["Sell_Date"].ToString());
                }
                if (row["Sell_TransportType"] != null)
                {
                    model.Sell_TransportType = row["Sell_TransportType"].ToString();
                }
                if (row["Sell_Review"] != null && row["Sell_Review"].ToString() != "")
                {
                    model.Sell_Review = int.Parse(row["Sell_Review"].ToString());
                }
                if (row["Sell_ChangeDate"] != null && row["Sell_ChangeDate"].ToString() != "")
                {
                    model.Sell_ChangeDate = DateTime.Parse(row["Sell_ChangeDate"].ToString());
                }
                if (row["Sell_Operation"] != null)
                {
                    model.Sell_Operation = row["Sell_Operation"].ToString();
                }
                if (row["Sell_Auditman"] != null)
                {
                    model.Sell_Auditman = row["Sell_Auditman"].ToString();
                }
                if (row["Sell_Remark"] != null)
                {
                    model.Sell_Remark = row["Sell_Remark"].ToString();
                }
                if (row["Sell_Satetyone"] != null)
                {
                    model.Sell_Satetyone = row["Sell_Satetyone"].ToString();
                }
                if (row["Sell_Satetytwo"] != null)
                {
                    model.Sell_Satetytwo = row["Sell_Satetytwo"].ToString();
                }
                if (row["Sell_Clear"] != null && row["Sell_Clear"].ToString() != "")
                {
                    model.Sell_Clear = int.Parse(row["Sell_Clear"].ToString());
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
            strSql.Append("select Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,Sell_Clear ");
            strSql.Append(" FROM T_Sell ");
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
            strSql.Append(" Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,Sell_Clear ");
            strSql.Append(" FROM T_Sell ");
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
            strSql.Append("select count(1) FROM T_Sell ");
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
                strSql.Append("order by T.Sell_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_Sell T ");
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
			parameters[0].Value = "T_Sell";
			parameters[1].Value = "Sell_ID";
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Sell_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Sell");
            strSql.Append(" where Sell_Code=@Sell_Code and Sell_Clear = @Sell_Clear");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Sell_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Sell ");
            strSql.Append(" where Sell_Code=@Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Sell_Code;

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
        /// 根据code做假删除
        /// </summary>
        /// <param name="Sell_Code"></param>
        /// <returns></returns>
        public bool DeleteFake(string Sell_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Sell  ");
            strSql.Append("set Sell_Clear = 0 ");
            strSql.Append("where Sell_Code = @Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = Sell_Code;

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

        //public DataSet GetListSellInDetail()
        //{

        //}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        //public Sell GetModel(int Sell_ID)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select  top 1 Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,Sell_Clear from T_Sell ");
        //    strSql.Append(" where Sell_ID=@Sell_ID");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@Sell_ID", SqlDbType.Int,4)
        //    };
        //    parameters[0].Value = Sell_ID;

        //    Sell model = new Sell();
        //    DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        #endregion  ExtensionMethod
    }
}

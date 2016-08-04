using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
using Model;

namespace DAL
{
	/// <summary>
	/// 数据访问类:Discount
	/// </summary>
	public partial class DiscountService
    {
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Dis_ID", "T_Discount"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Dis_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Discount");
			strSql.Append(" where Dis_ID=@Dis_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Dis_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Discount model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Discount(");
			strSql.Append("Dis_Name,Dis_ClientCode,Dis_CreateDate,Dis_ClearDate,Dis_Discount,Dis_Enable,Dis_Clear,Dis_Remark,Dis_Code)");
			strSql.Append(" values (");
			strSql.Append("@Dis_Name,@Dis_ClientCode,@Dis_CreateDate,@Dis_ClearDate,@Dis_Discount,@Dis_Enable,@Dis_Clear,@Dis_Remark,@Dis_Code)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_ClientCode", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Dis_ClearDate", SqlDbType.DateTime),
					new SqlParameter("@Dis_Discount", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_Enable", SqlDbType.Int,4),
					new SqlParameter("@Dis_Clear", SqlDbType.Int,4),
					new SqlParameter("@Dis_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@Dis_Code", SqlDbType.NVarChar,512)};
			parameters[0].Value = model.Dis_Name;
			parameters[1].Value = model.Dis_ClientCode;
			parameters[2].Value = model.Dis_CreateDate;
			parameters[3].Value = model.Dis_ClearDate;
			parameters[4].Value = model.Dis_Discount;
			parameters[5].Value = model.Dis_Enable;
			parameters[6].Value = model.Dis_Clear;
			parameters[7].Value = model.Dis_Remark;
			parameters[8].Value = model.Dis_Code;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Discount model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Discount set ");
			strSql.Append("Dis_Name=@Dis_Name,");
			strSql.Append("Dis_ClientCode=@Dis_ClientCode,");
			strSql.Append("Dis_CreateDate=@Dis_CreateDate,");
			strSql.Append("Dis_ClearDate=@Dis_ClearDate,");
			strSql.Append("Dis_Discount=@Dis_Discount,");
			strSql.Append("Dis_Enable=@Dis_Enable,");
			strSql.Append("Dis_Clear=@Dis_Clear,");
			strSql.Append("Dis_Remark=@Dis_Remark,");
			strSql.Append("Dis_Code=@Dis_Code");
			strSql.Append(" where Dis_ID=@Dis_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_ClientCode", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Dis_ClearDate", SqlDbType.DateTime),
					new SqlParameter("@Dis_Discount", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_Enable", SqlDbType.Int,4),
					new SqlParameter("@Dis_Clear", SqlDbType.Int,4),
					new SqlParameter("@Dis_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@Dis_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@Dis_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Dis_Name;
			parameters[1].Value = model.Dis_ClientCode;
			parameters[2].Value = model.Dis_CreateDate;
			parameters[3].Value = model.Dis_ClearDate;
			parameters[4].Value = model.Dis_Discount;
			parameters[5].Value = model.Dis_Enable;
			parameters[6].Value = model.Dis_Clear;
			parameters[7].Value = model.Dis_Remark;
			parameters[8].Value = model.Dis_Code;
			parameters[9].Value = model.Dis_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int Dis_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Discount ");
			strSql.Append(" where Dis_ID=@Dis_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Dis_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Dis_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Discount ");
			strSql.Append(" where Dis_ID in ("+Dis_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Discount GetModel(int Dis_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Dis_ID,Dis_Name,Dis_ClientCode,Dis_CreateDate,Dis_ClearDate,Dis_Discount,Dis_Enable,Dis_Clear,Dis_Remark,Dis_Code from T_Discount ");
			strSql.Append(" where Dis_ID=@Dis_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Dis_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Dis_ID;

			Discount model=new Discount();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Discount DataRowToModel(DataRow row)
		{
			Discount model=new Discount();
			if (row != null)
			{
				if(row["Dis_ID"]!=null && row["Dis_ID"].ToString()!="")
				{
					model.Dis_ID=int.Parse(row["Dis_ID"].ToString());
				}
				if(row["Dis_Name"]!=null)
				{
					model.Dis_Name=row["Dis_Name"].ToString();
				}
				if(row["Dis_ClientCode"]!=null)
				{
					model.Dis_ClientCode=row["Dis_ClientCode"].ToString();
				}
				if(row["Dis_CreateDate"]!=null && row["Dis_CreateDate"].ToString()!="")
				{
					model.Dis_CreateDate=DateTime.Parse(row["Dis_CreateDate"].ToString());
				}
				if(row["Dis_ClearDate"]!=null && row["Dis_ClearDate"].ToString()!="")
				{
					model.Dis_ClearDate=DateTime.Parse(row["Dis_ClearDate"].ToString());
				}
				if(row["Dis_Discount"]!=null)
				{
					model.Dis_Discount=row["Dis_Discount"].ToString();
				}
				if(row["Dis_Enable"]!=null && row["Dis_Enable"].ToString()!="")
				{
					model.Dis_Enable=int.Parse(row["Dis_Enable"].ToString());
				}
				if(row["Dis_Clear"]!=null && row["Dis_Clear"].ToString()!="")
				{
					model.Dis_Clear=int.Parse(row["Dis_Clear"].ToString());
				}
				if(row["Dis_Remark"]!=null)
				{
					model.Dis_Remark=row["Dis_Remark"].ToString();
				}
				if(row["Dis_Code"]!=null)
				{
					model.Dis_Code=row["Dis_Code"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Dis_ID,Dis_Name,Dis_ClientCode,Dis_CreateDate,Dis_ClearDate,Dis_Discount,Dis_Enable,Dis_Clear,Dis_Remark,Dis_Code ");
			strSql.Append(" FROM T_Discount ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Dis_ID,Dis_Name,Dis_ClientCode,Dis_CreateDate,Dis_ClearDate,Dis_Discount,Dis_Enable,Dis_Clear,Dis_Remark,Dis_Code ");
			strSql.Append(" FROM T_Discount ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_Discount ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Dis_ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Discount T ");
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
			parameters[0].Value = "T_Discount";
			parameters[1].Value = "Dis_ID";
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
        public bool Exists(string Dis_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Discount");
            strSql.Append(" where Dis_Code=@Dis_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Dis_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Dis_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Dis_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Discount ");
            strSql.Append(" where Dis_Code=@Dis_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Dis_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Dis_Code;

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
        /// 得到一个对象实体
        /// </summary>
        public Discount GetModel(string Dis_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Dis_ID,Dis_Name,Dis_ClientCode,Dis_CreateDate,Dis_ClearDate,Dis_Discount,Dis_Enable,Dis_Clear,Dis_Remark,Dis_Code from T_Discount ");
            strSql.Append(" where Dis_Code=@Dis_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Dis_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Dis_Code;

            Discount model = new Discount();
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
        #endregion  ExtensionMethod
    }
}


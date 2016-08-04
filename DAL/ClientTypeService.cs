using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
using Model;

namespace DAL
{
	/// <summary>
	/// 数据访问类:ClientType
	/// </summary>
	public partial class ClientTypeService
	{
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CT_ID", "T_ClientType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_ClientType");
			strSql.Append(" where CT_ID=@CT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = CT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ClientType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_ClientType(");
			strSql.Append("CT_Code,CT_Name,CT_Remark,CT_Safetyone,CT_Safetytwo,CT_Enable)");
			strSql.Append(" values (");
			strSql.Append("@CT_Code,@CT_Name,@CT_Remark,@CT_Safetyone,@CT_Safetytwo,@CT_Enable)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CT_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@CT_Safetyone", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Safetytwo", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Enable", SqlDbType.Int,4)};
			parameters[0].Value = model.CT_Code;
			parameters[1].Value = model.CT_Name;
			parameters[2].Value = model.CT_Remark;
			parameters[3].Value = model.CT_Safetyone;
			parameters[4].Value = model.CT_Safetytwo;
			parameters[5].Value = model.CT_Enable;

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
		public bool Update(ClientType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_ClientType set ");
			strSql.Append("CT_Code=@CT_Code,");
			strSql.Append("CT_Name=@CT_Name,");
			strSql.Append("CT_Remark=@CT_Remark,");
			strSql.Append("CT_Safetyone=@CT_Safetyone,");
			strSql.Append("CT_Safetytwo=@CT_Safetytwo,");
			strSql.Append("CT_Enable=@CT_Enable");
			strSql.Append(" where CT_ID=@CT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CT_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@CT_Safetyone", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Safetytwo", SqlDbType.NVarChar,512),
					new SqlParameter("@CT_Enable", SqlDbType.Int,4),
					new SqlParameter("@CT_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CT_Code;
			parameters[1].Value = model.CT_Name;
			parameters[2].Value = model.CT_Remark;
			parameters[3].Value = model.CT_Safetyone;
			parameters[4].Value = model.CT_Safetytwo;
			parameters[5].Value = model.CT_Enable;
			parameters[6].Value = model.CT_ID;

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
		public bool Delete(int CT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ClientType ");
			strSql.Append(" where CT_ID=@CT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = CT_ID;

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
		public bool DeleteList(string CT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ClientType ");
			strSql.Append(" where CT_ID in (" + CT_IDlist + ")  ");
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
		public ClientType GetModel(int CT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select top 1 CT_ID,CT_Code,CT_Name,CT_Remark,CT_Safetyone,CT_Safetytwo,CT_Enable from T_ClientType ");
			strSql.Append(" where CT_ID=@CT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = CT_ID;

			ClientType model=new ClientType();
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
		public ClientType DataRowToModel(DataRow row)
		{
			ClientType model=new ClientType();
			if (row != null)
			{
				if(row["CT_ID"]!=null && row["CT_ID"].ToString()!="")
				{
					model.CT_ID=int.Parse(row["CT_ID"].ToString());
				}
				if(row["CT_Code"]!=null)
				{
					model.CT_Code=row["CT_Code"].ToString();
				}
				if(row["CT_Name"]!=null)
				{
					model.CT_Name=row["CT_Name"].ToString();
				}
				if(row["CT_Remark"]!=null)
				{
					model.CT_Remark=row["CT_Remark"].ToString();
				}
				if(row["CT_Safetyone"]!=null)
				{
					model.CT_Safetyone=row["CT_Safetyone"].ToString();
				}
				if(row["CT_Safetytwo"]!=null)
				{
					model.CT_Safetytwo=row["CT_Safetytwo"].ToString();
				}
				if(row["CT_Enable"]!=null && row["CT_Enable"].ToString()!="")
				{
					model.CT_Enable=int.Parse(row["CT_Enable"].ToString());
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
			strSql.Append("select CT_ID,CT_Code,CT_Name,CT_Remark,CT_Safetyone,CT_Safetytwo,CT_Enable ");
			strSql.Append(" FROM T_ClientType ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where " + strWhere);
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
			strSql.Append(" CT_ID,CT_Code,CT_Name,CT_Remark,CT_Safetyone,CT_Safetytwo,CT_Enable ");
			strSql.Append(" FROM T_ClientType ");
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
			strSql.Append("select count(1) FROM T_ClientType ");
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
				strSql.Append("order by T.CT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_ClientType T ");
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
			parameters[0].Value = "T_ClientType";
			parameters[1].Value = "CT_ID";
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
        public bool Exists(string CT_Code,int CT_Enable)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_ClientType");
            strSql.Append(" where CT_Code=@CT_Code and CT_Enable=@CT_Enable");
            SqlParameter[] parameters = {
                    new SqlParameter("@CT_Code", SqlDbType.VarChar,512),
                    new SqlParameter("@CT_Enable", SqlDbType.Int)
            };
            parameters[0].Value = CT_Code;
            parameters[1].Value = CT_Enable;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 假删除一条数据，将enable置为0
        /// </summary>
        public bool Delete(string CT_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_ClientType");
            strSql.Append(" set CT_Enable=0");
            strSql.Append(" where CT_Code=@CT_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@CT_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = CT_Code;

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
        /// 根据Code更新一条数据 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateByCode(ClientType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_ClientType set ");
            strSql.Append("CT_Name=@CT_Name,");
            strSql.Append("CT_Remark=@CT_Remark,");
            strSql.Append("CT_Safetyone=@CT_Safetyone,");
            strSql.Append("CT_Safetytwo=@CT_Safetytwo,");
            strSql.Append("CT_Enable=@CT_Enable");
            strSql.Append(" where CT_Code=@CT_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@CT_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@CT_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@CT_Safetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@CT_Safetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@CT_Enable", SqlDbType.Int,4),
                    new SqlParameter("@CT_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.CT_Name;
            parameters[1].Value = model.CT_Remark;
            parameters[2].Value = model.CT_Safetyone;
            parameters[3].Value = model.CT_Safetytwo;
            parameters[4].Value = model.CT_Enable;
            parameters[5].Value = model.CT_Code;

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
		/// 假删除表里的所有数据
		/// </summary>
		public bool FakeDeleteList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_ClientType ");
            strSql.Append(" set CT_Enable = 0 where CT_Enable = 1");
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
        /// 根据名称模糊检索
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public DataSet Search(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CT_ID,CT_Code,CT_Name,CT_Remark from T_ClientType");
            strSql.Append(" where CT_Enable = 1 and CT_Name Like '%");
            strSql.Append(name);
            strSql.Append("%'");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            return ds;
        }
        #endregion  ExtensionMethod
    }
}


using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
using Model;
using HelperUtility.Encrypt;

namespace DAL
{
	/// <summary>
	/// 数据访问类:MaterialType
	/// </summary>
	public partial class MaterialTypeService
    {
        CodingHelper ch = new CodingHelper();
        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataTable GetListToTable(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MT_ID,MT_Code,MT_Name,MT_ParentID,MT_Enable,MT_Clear");
            strSql.Append(" FROM T_MaterialType where MT_Enable = 1 and MT_Clear = 1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(strSql.ToString(), DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_MaterialType");
            return ch.DataTableReCoding(ds1.Tables[0]);
        }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MT_ID", "T_MaterialType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_MaterialType");
			strSql.Append(" where MT_ID=@MT_ID and MT_Enable = 1 and MT_Clear = 1");
			SqlParameter[] parameters = {
					new SqlParameter("@MT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MaterialType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_MaterialType(");
			strSql.Append("MT_Code,MT_Name,MT_ParentID,MT_Enable,MT_Clear)");
			strSql.Append(" values (");
			strSql.Append("@MT_Code,@MT_Name,@MT_ParentID,@MT_Enable,@MT_Clear)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MT_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@MT_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@MT_ParentID", SqlDbType.NVarChar,512),
					new SqlParameter("@MT_Enable", SqlDbType.Int),
					new SqlParameter("@MT_Clear", SqlDbType.Int)};
			parameters[0].Value = model.MT_Code;
			parameters[1].Value = model.MT_Name;
			parameters[2].Value = model.MT_ParentID;
			parameters[3].Value = model.MT_Enable;
			parameters[4].Value = model.MT_Clear;

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
		public bool Update(MaterialType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_MaterialType set ");
			strSql.Append("MT_Code=@MT_Code,");
			strSql.Append("MT_Name=@MT_Name,");
			strSql.Append("MT_ParentID=@MT_ParentID,");
			strSql.Append("MT_Enable=@MT_Enable,");
			strSql.Append("MT_Clear=@MT_Clear,");
			strSql.Append(" where MT_ID=@MT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MT_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@MT_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@MT_ParentID", SqlDbType.NVarChar,512),
					new SqlParameter("@MT_Enable", SqlDbType.Int),
					new SqlParameter("@MT_Clear", SqlDbType.Int),
					new SqlParameter("@MT_ID", SqlDbType.Int)};
			parameters[0].Value = model.MT_Code;
			parameters[1].Value = model.MT_Name;
			parameters[2].Value = model.MT_ParentID;
			parameters[3].Value = model.MT_Enable;
			parameters[4].Value = model.MT_Clear;
			parameters[5].Value = model.MT_ID;

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
		public bool Delete(int MT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MaterialType ");
			strSql.Append(" where MT_ID=@MT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MT_ID;

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
		public bool DeleteList(string MT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_MaterialType ");
			strSql.Append(" where MT_ID in ("+MT_IDlist + ")  ");
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
		public MaterialType GetModel(int MT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MT_ID,MT_Code,MT_Name,MT_ParentID,MT_Enable,MT_Clear from T_MaterialType");
			strSql.Append(" where MT_ID=@MT_ID and MT_Enable = 1 and MT_Clear = 1");
			SqlParameter[] parameters = {
					new SqlParameter("@MT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = MT_ID;

			MaterialType model=new MaterialType();
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
		public MaterialType DataRowToModel(DataRow row)
		{
			MaterialType model=new MaterialType();
			if (row != null)
			{
				if(row["MT_ID"]!=null && row["MT_ID"].ToString()!="")
				{
					model.MT_ID=int.Parse(row["MT_ID"].ToString());
				}
                if (row["MT_Code"] != null)
                {
                    model.MT_Code = row["MT_Code"].ToString();
                }
                if (row["MT_Name"] != null)
                {
                    model.MT_Name = row["MT_Name"].ToString();
                }
                if (row["MT_ParentID"] != null)
                {
                    model.MT_ParentID = row["MT_ParentID"].ToString();
                }
                if (row["MT_Enable"]!=null && row["MT_Enable"].ToString()!="")
				{
					model.MT_Enable=int.Parse(row["MT_Enable"].ToString());
				}
				if(row["MT_Clear"]!=null && row["MT_Clear"].ToString()!="")
				{
					model.MT_Clear=int.Parse(row["MT_Clear"].ToString());
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
			strSql.Append("select MT_ID,MT_Code,MT_Name,MT_ParentID,MT_Enable,MT_Clear");
			strSql.Append(" FROM T_MaterialType where MT_Enable = 1 and MT_Clear = 1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
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
			strSql.Append(" MT_ID,MT_Code,MT_Name,MT_ParentID,MT_Enable,MT_Clear ");
			strSql.Append(" FROM T_MaterialType where MT_Enable = 1 and MT_Clear = 1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and " + strWhere);
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
			strSql.Append("select count(1) FROM T_MaterialType where MT_Enable = 1 and MT_Clear = 1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
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
				strSql.Append("order by T.MT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_MaterialType T ");
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
			parameters[0].Value = "T_MaterialType";
			parameters[1].Value = "MT_ID";
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
        public bool Exists(string MT_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_MaterialType");
            strSql.Append(" where MT_Code=@MT_Code and MT_Enable = 1 and MT_Clear = 1");
            SqlParameter[] parameters = {
                    new SqlParameter("@MT_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = MT_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
		/// 根据code更新一条数据
		/// </summary>
		public bool UpdateByCode(MaterialType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_MaterialType set ");
            strSql.Append("MT_Name=@MT_Name,");
            strSql.Append("MT_ParentID=@MT_ParentID,");
            strSql.Append("MT_Enable=@MT_Enable,");
            strSql.Append("MT_Clear=@MT_Clear,");
            strSql.Append(" where MT_Code=@MT_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@MT_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@MT_ParentID", SqlDbType.NVarChar,512),
                    new SqlParameter("@MT_Enable", SqlDbType.Int),
                    new SqlParameter("@MT_Clear", SqlDbType.Int),
                    new SqlParameter("@MT_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.MT_Name;
            parameters[1].Value = model.MT_ParentID;
            parameters[2].Value = model.MT_Enable;
            parameters[3].Value = model.MT_Clear;
            parameters[4].Value = model.MT_Code;

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
        /// <param name="code">要删除的类型code</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_MaterialType set MT_Clear = 0");
            strSql.Append(" where MT_Code=@MT_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@MT_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = code;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
        /// 假删除所有除了根节点之外的所有节点
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        public bool DeleteAllFake()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_MaterialType set MT_Clear = 0 ");
            strSql.Append(" where MT_Enable == 1 and MT_Clear == 1 and MT_ParentID <> D4");
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

        #endregion  ExtensionMethod
    }
}


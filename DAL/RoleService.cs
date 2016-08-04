using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class RoleService
    {
        #region  BasicMethod
        
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Role_ID", "T_Role");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Role_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Role");
            strSql.Append(" where Role_ID=@Role_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Role_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Role(");
            strSql.Append("Role_Code,Role_Name,Role_Modules)");
            strSql.Append(" values (");
            strSql.Append("@Role_Code,@Role_Name,@Role_Modules)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Role_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Role_Modules", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Role_Code;
            parameters[1].Value = model.Role_Name;
            parameters[2].Value = model.Role_Modules;

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
        public bool Update(Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Role set ");
            strSql.Append("Role_Code=@Role_Code,");
            strSql.Append("Role_Name=@Role_Name,");
            strSql.Append("Role_Modules=@Role_Modules");
            strSql.Append(" where Role_ID=@Role_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Role_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Role_Modules", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Role_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Role_Code;
            parameters[1].Value = model.Role_Name;
            parameters[2].Value = model.Role_Modules;
            parameters[3].Value = model.Role_ID;

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
        public bool Delete(int Role_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Role ");
            strSql.Append(" where Role_ID=@Role_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Role_ID;

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
        public bool DeleteList(string Role_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Role ");
            strSql.Append(" where Role_ID in (" + Role_IDlist + ")  ");
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
        public Role GetModel(int Role_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Role_ID,Role_Code,Role_Name,Role_Modules from T_Role ");
            strSql.Append(" where Role_ID=@Role_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Role_ID;

            Role model = new Model.Role();
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
        public Role DataRowToModel(DataRow row)
        {
            Role model = new Role();
            if (row != null)
            {
                if (row["Role_ID"] != null && row["Role_ID"].ToString() != "")
                {
                    model.Role_ID = int.Parse(row["Role_ID"].ToString());
                }
                if (row["Role_Code"] != null)
                {
                    model.Role_Code = row["Role_Code"].ToString();
                }
                if (row["Role_Name"] != null)
                {
                    model.Role_Name = row["Role_Name"].ToString();
                }
                if (row["Role_Modules"] != null)
                {
                    model.Role_Modules = row["Role_Modules"].ToString();
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
            strSql.Append("select Role_ID,Role_Code,Role_Name,Role_Modules ");
            strSql.Append(" FROM T_Role ");
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
            strSql.Append(" Role_ID,Role_Code,Role_Name,Role_Modules ");
            strSql.Append(" FROM T_Role ");
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
            strSql.Append("select count(1) FROM T_Role ");
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
                strSql.Append("order by T.Role_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_Role T ");
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
			parameters[0].Value = "T_Role";
			parameters[1].Value = "Role_ID";
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
        public bool Exists(string Role_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Role");
            strSql.Append(" where Role_Code=@Role_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Role_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Role GetModel(string Role_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Role_ID,Role_Code,Role_Name,Role_Modules from T_Role ");
            strSql.Append(" where Role_Code=@Role_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Role_Code;

            Role model = new Role();
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
        /// 更新一条数据
        /// </summary>
        public bool UpdateByCode(Role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Role set ");
            strSql.Append("Role_Name=@Role_Name,");
            strSql.Append("Role_Modules=@Role_Modules");
            strSql.Append(" where Role_Code=@Role_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Role_Modules", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Role_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.Role_Name;
            parameters[1].Value = model.Role_Modules;
            parameters[2].Value = model.Role_Code;

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
        public bool Delete(string Role_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Role ");
            strSql.Append(" where Role_Code=@Role_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Role_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Role_Code;

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

        
        #endregion  ExtensionMethod
    }
}

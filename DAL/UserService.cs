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
    public class UserService
    {
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("User_ID", "T_User");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int User_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_User");
            strSql.Append(" where User_ID=@User_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = User_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_User(");
            strSql.Append("User_Code,User_zhiwen,User_Name,User_CardCode,User_Password,User_Role,User_Manager)");
            strSql.Append(" values (");
            strSql.Append("@User_Code,@User_zhiwen,@User_Name,@User_CardCode,@User_Password,@User_Role,@User_Manager)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_zhiwen", SqlDbType.NVarChar,-1),
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_CardCode", SqlDbType.NVarChar,-1),
                    new SqlParameter("@User_Password", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Role", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Manager", SqlDbType.Int,4)};
            parameters[0].Value = model.User_code;
            parameters[1].Value = model.User_zhiwen;
            parameters[2].Value = model.User_Name;
            parameters[3].Value = model.User_CardCode;
            parameters[4].Value = model.User_Password;
            parameters[5].Value = model.User_Role;
            parameters[6].Value = model.User_Manager;

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
        public bool Update(User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_User set ");
            strSql.Append("User_Code=@User_Code,");
            strSql.Append("User_zhiwen=@User_zhiwen,");
            strSql.Append("User_Name=@User_Name,");
            strSql.Append("User_CardCode=@User_CardCode,");
            strSql.Append("User_Password=@User_Password,");
            strSql.Append("User_Role=@User_Role,");
            strSql.Append("User_Manager=@User_Manager");
            strSql.Append(" where User_ID=@User_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_zhiwen", SqlDbType.NVarChar,-1),
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_CardCode", SqlDbType.NVarChar,-1),
                    new SqlParameter("@User_Password", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Role", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Manager", SqlDbType.Int,4),
                    new SqlParameter("@User_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.User_code;
            parameters[1].Value = model.User_zhiwen;
            parameters[2].Value = model.User_Name;
            parameters[3].Value = model.User_CardCode;
            parameters[4].Value = model.User_Password;
            parameters[5].Value = model.User_Role;
            parameters[6].Value = model.User_Manager;
            parameters[7].Value = model.User_ID;

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
        public bool Delete(int User_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_User ");
            strSql.Append(" where User_ID=@User_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = User_ID;

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
        public bool DeleteList(string User_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_User ");
            strSql.Append(" where User_ID in (" + User_IDlist + ")  ");
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
        public Model.User GetModel(int User_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 User_ID,User_Code,User_zhiwen,User_Name,User_CardCode,User_Password,User_Role,User_Manager from T_User ");
            strSql.Append(" where User_ID=@User_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = User_ID;

            User model = new User();
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
        public User DataRowToModel(DataRow row)
        {
            User model = new User();
            if (row != null)
            {
                if (row["User_ID"] != null && row["User_ID"].ToString() != "")
                {
                    model.User_ID = int.Parse(row["User_ID"].ToString());
                }
                if (row["User_Code"] != null)
                {
                    model.User_code = row["User_Code"].ToString();
                }
                if (row["User_zhiwen"] != null)
                {
                    model.User_zhiwen = row["User_zhiwen"].ToString();
                }
                if (row["User_Name"] != null)
                {
                    model.User_Name = row["User_Name"].ToString();
                }
                if (row["User_CardCode"] != null)
                {
                    model.User_CardCode = row["User_CardCode"].ToString();
                }
                if (row["User_Password"] != null)
                {
                    model.User_Password = row["User_Password"].ToString();
                }
                if (row["User_Role"] != null)
                {
                    model.User_Role = row["User_Role"].ToString();
                }
                if (row["User_Manager"] != null && row["User_Manager"].ToString() != "")
                {
                    model.User_Manager = int.Parse(row["User_Manager"].ToString());
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
            strSql.Append("select User_ID,User_Code,User_zhiwen,User_Name,User_CardCode,User_Password,User_Role,User_Manager ");
            strSql.Append(" FROM T_User");
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
            strSql.Append(" User_ID,User_Code,User_zhiwen,User_Name,User_CardCode,User_Password,User_Role,User_Manager ");
            strSql.Append(" FROM T_User ");
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
            strSql.Append("select count(1) FROM T_User ");
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
                strSql.Append("order by T.User_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_User T ");
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
			parameters[0].Value = "T_User";
			parameters[1].Value = "User_ID";
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
        public bool Exists(string User_Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_User");
            strSql.Append(" where User_Name=@User_Name");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = User_Name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据code更新一条数据
        /// </summary>
        public bool UpdateByCode(User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_User set ");
            strSql.Append("User_zhiwen=@User_zhiwen,");
            strSql.Append("User_Name=@User_Name,");
            strSql.Append("User_CardCode=@User_CardCode,");
            strSql.Append("User_Password=@User_Password,");
            strSql.Append("User_Role=@User_Role,");
            strSql.Append("User_Manager=@User_Manager");
            strSql.Append(" where User_Code=@User_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_zhiwen", SqlDbType.NVarChar,-1),
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_CardCode", SqlDbType.NVarChar,-1),
                    new SqlParameter("@User_Password", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Role", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Manager", SqlDbType.Int,4),
                    new SqlParameter("@User_Code", SqlDbType.NVarChar,512),};
            parameters[0].Value = model.User_zhiwen;
            parameters[1].Value = model.User_Name;
            parameters[2].Value = model.User_CardCode;
            parameters[3].Value = model.User_Password;
            parameters[4].Value = model.User_Role;
            parameters[5].Value = model.User_Manager;
            parameters[6].Value = model.User_code;

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
        /// 根据用户名和密码获得一个对象实体
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public User GetModel(string name, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 User_ID,User_Code,User_zhiwen,User_Name,User_CardCode,User_Password,User_Role,User_Manager from T_User ");
            strSql.Append(" where User_Name = @User_Name and User_Password = @User_Password");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Password", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = name;
            parameters[1].Value = password;

            User model = new User();
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
        /// 根据user_role做内链接 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable GetUserAndRoleModel(string name, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 T_User.User_ID,T_User.User_Code,T_User.User_zhiwen,T_User.User_Name,T_User.User_CardCode,T_User.User_Password,T_User.User_Role,T_User.User_Manager,");
            strSql.Append("T_Role.Role_Name,T_Role.Role_Modules ");
            strSql.Append("from T_User join T_Role on T_User.User_Role = T_Role.Role_Code ");
            strSql.Append("and T_User.User_Name = @User_Name and T_User.User_Password = @User_Password");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Password", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = name;
            parameters[1].Value = password;

            User model = new User();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

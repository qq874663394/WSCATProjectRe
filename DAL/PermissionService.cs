using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using HelperUtility.Encrypt;

namespace DAL
{
    public class PermissionService
    {
        /// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Per_ID", "T_Permission");
        }

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Per_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Discount");
            strSql.Append(" where Per_Code=@Per_Code and Per_Clear = 1");
            SqlParameter[] parameters = {
                    new SqlParameter("@Per_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Per_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Permission model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Permission(");
            strSql.Append("Per_Code,Per_ModuleName,Per_ReadState,Per_WriteState,Per_AuditState,Per_Clear,Per_Type,Per_RoleCode)");
            strSql.Append(" values (");
            strSql.Append("@Per_Code,@Per_ModuleName,@Per_ReadState,@Per_WriteState,@Per_AuditState,@Per_Clear,@Per_Type,@Per_RoleCode)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Per_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_ModuleName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_ReadState", SqlDbType.DateTime),
                    new SqlParameter("@Per_WriteState", SqlDbType.DateTime),
                    new SqlParameter("@Per_AuditState", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Per_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_RoleCode", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.Per_Code;
            parameters[1].Value = model.Per_ModuleName;
            parameters[2].Value = model.Per_ReadState;
            parameters[3].Value = model.Per_WriteState;
            parameters[4].Value = model.Per_AuditState;
            parameters[5].Value = model.Per_Clear;
            parameters[6].Value = model.Per_Type;
            parameters[7].Value = model.Per_RoleCode;

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
		public bool Update(Permission model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Permission set ");
            strSql.Append("Per_ModuleName=@Per_ModuleName,");
            strSql.Append("Per_ReadState=@Per_ReadState,");
            strSql.Append("Per_WriteState=@Per_WriteState,");
            strSql.Append("Per_AuditState=@Per_AuditState,");
            strSql.Append("Per_Clear=@Per_Clear,");
            strSql.Append("Per_Type=@Per_Type,");
            strSql.Append("Per_RoleCode=@Per_RoleCode");
            strSql.Append(" where Per_Code=@Per_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Per_ModuleName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_ReadState", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_WriteState", SqlDbType.DateTime),
                    new SqlParameter("@Per_AuditState", SqlDbType.DateTime),
                    new SqlParameter("@Per_Clear", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Per_RoleCode", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.Per_ModuleName;
            parameters[1].Value = model.Per_ReadState;
            parameters[2].Value = model.Per_WriteState;
            parameters[3].Value = model.Per_AuditState;
            parameters[4].Value = model.Per_Clear;
            parameters[5].Value = model.Per_Code;
            parameters[6].Value = model.Per_Type;
            parameters[7].Value = model.Per_RoleCode;

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
		/// 获得数据列表 
		/// </summary>
		public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Per_ID,Per_Code,Per_ModuleName,Per_ReadState,Per_WriteState,Per_AuditState,Per_Clear,Per_Type,Per_RoleCode ");
            strSql.Append(" FROM T_Permission where Per_Clear = 1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据code做假删除 
        /// </summary>
        /// <param name="code">要删除的code</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Permission set Per_Clear = 0");
            strSql.Append(" where Per_Code=@Per_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Per_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = code;
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
        /// 批量更新数据
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public bool UpdateBatch(DataTable ds)
        {
            StringBuilder strSql = new StringBuilder();
            foreach(DataRow dr in ds.Rows)
            {
                if(dr.RowState == DataRowState.Modified)
                {
                    strSql.Append("update T_Permission set Per_ReadState = " + dr["Per_ReadState"] +
                        ",Per_WriteState = " + dr["Per_WriteState"] +
                        ",Per_AuditState = " + dr["Per_AuditState"] +
                        " where Per_Code = '" + XYEEncoding.strCodeHex(dr["Per_Code"].ToString()) + "';");
                }
            }

            if(strSql.Length == 0)
            {
                return false;
            }

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
        /// 批量插入权限信息到数据库中
        /// </summary>
        /// <param name="pList"></param>
        /// <returns></returns> 
        public int AddBatch(List<Permission> pList)
        {
            if(pList.Count < 1)
            {
                return 0;
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Permission(Per_Code,Per_ModuleName,Per_ReadState,Per_WriteState,Per_AuditState,Per_Clear,Per_Type,Per_RoleCode) ");
            strSql.Append(" values ");
            foreach(var permission in pList)
            {
                strSql.Append("('" + permission.Per_Code + "','");
                strSql.Append(permission.Per_ModuleName + "',");
                strSql.Append(permission.Per_ReadState + ",");
                strSql.Append(permission.Per_WriteState + ",");
                strSql.Append(permission.Per_AuditState + ",");
                strSql.Append(permission.Per_Clear + ",'");
                strSql.Append(permission.Per_Type + "','");
                strSql.Append(permission.Per_RoleCode + "'),");
            }
            //移除最后一个逗号
            strSql.Remove(strSql.Length - 1, 1);
            int result = DbHelperSQL.ExecuteSql(strSql.ToString());
            return result;
        }
    }
}

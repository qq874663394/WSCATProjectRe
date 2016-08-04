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
    public class StorageService
    {
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("St_ID", "T_Storage");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int St_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Storage");
            strSql.Append(" where St_ID=@St_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@St_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = St_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Storage(");
            strSql.Append("St_Name,St_EmpName,St_Phone,St_Address,St_Enable,St_Clear,St_Remark,St_Safetyone,St_Safetytwo,St_Code)");
            strSql.Append(" values (");
            strSql.Append("@St_Name,@St_EmpName,@St_Phone,@St_Address,@St_Enable,@St_Clear,@St_Remark,@St_Safetyone,@St_Safetytwo,@St_Code)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@St_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_EmpName", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Phone", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Enable", SqlDbType.Int,4),
                    new SqlParameter("@St_Clear", SqlDbType.Int,4),
                    new SqlParameter("@St_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@St_Safetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Safetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.St_Name;
            parameters[1].Value = model.St_EmpName;
            parameters[2].Value = model.St_Phone;
            parameters[3].Value = model.St_Address;
            parameters[4].Value = model.St_Enable;
            parameters[5].Value = model.St_Clear;
            parameters[6].Value = model.St_Remark;
            parameters[7].Value = model.St_Safetyone;
            parameters[8].Value = model.St_Safetytwo;
            parameters[9].Value = model.St_Code;

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
        public bool Update(Storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Storage set ");
            strSql.Append("St_Name=@St_Name,");
            strSql.Append("St_EmpName=@St_EmpName,");
            strSql.Append("St_Phone=@St_Phone,");
            strSql.Append("St_Address=@St_Address,");
            strSql.Append("St_Enable=@St_Enable,");
            strSql.Append("St_Clear=@St_Clear,");
            strSql.Append("St_Remark=@St_Remark,");
            strSql.Append("St_Safetyone=@St_Safetyone,");
            strSql.Append("St_Safetytwo=@St_Safetytwo,");
            strSql.Append("St_Code=@St_Code");
            strSql.Append(" where St_ID=@St_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@St_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_EmpName", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Phone", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Enable", SqlDbType.Int,4),
                    new SqlParameter("@St_Clear", SqlDbType.Int,4),
                    new SqlParameter("@St_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@St_Safetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Safetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.St_Name;
            parameters[1].Value = model.St_EmpName;
            parameters[2].Value = model.St_Phone;
            parameters[3].Value = model.St_Address;
            parameters[4].Value = model.St_Enable;
            parameters[5].Value = model.St_Clear;
            parameters[6].Value = model.St_Remark;
            parameters[7].Value = model.St_Safetyone;
            parameters[8].Value = model.St_Safetytwo;
            parameters[9].Value = model.St_Code;
            parameters[10].Value = model.St_ID;

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
        public bool Delete(int St_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Storage ");
            strSql.Append(" where St_ID=@St_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@St_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = St_ID;

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
        public bool DeleteList(string St_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Storage ");
            strSql.Append(" where St_ID in (" + St_IDlist + ")  ");
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
        public Storage GetModel(int St_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 St_ID,St_Name,St_EmpName,St_Phone,St_Address,St_Enable,St_Clear,St_Remark,St_Safetyone,St_Safetytwo,St_Code from T_Storage ");
            strSql.Append(" where St_ID=@St_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@St_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = St_ID;

            Storage model = new Storage();
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
        public Storage DataRowToModel(DataRow row)
        {
            Storage model = new Storage();
            if (row != null)
            {
                if (row["St_ID"] != null && row["St_ID"].ToString() != "")
                {
                    model.St_ID = int.Parse(row["St_ID"].ToString());
                }
                if (row["St_Name"] != null)
                {
                    model.St_Name = row["St_Name"].ToString();
                }
                if (row["St_EmpName"] != null)
                {
                    model.St_EmpName = row["St_EmpName"].ToString();
                }
                if (row["St_Phone"] != null)
                {
                    model.St_Phone = row["St_Phone"].ToString();
                }
                if (row["St_Address"] != null)
                {
                    model.St_Address = row["St_Address"].ToString();
                }
                if (row["St_Enable"] != null && row["St_Enable"].ToString() != "")
                {
                    model.St_Enable = int.Parse(row["St_Enable"].ToString());
                }
                if (row["St_Clear"] != null && row["St_Clear"].ToString() != "")
                {
                    model.St_Clear = int.Parse(row["St_Clear"].ToString());
                }
                if (row["St_Remark"] != null)
                {
                    model.St_Remark = row["St_Remark"].ToString();
                }
                if (row["St_Safetyone"] != null)
                {
                    model.St_Safetyone = row["St_Safetyone"].ToString();
                }
                if (row["St_Safetytwo"] != null)
                {
                    model.St_Safetytwo = row["St_Safetytwo"].ToString();
                }
                if (row["St_Code"] != null)
                {
                    model.St_Code = row["St_Code"].ToString();
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
            strSql.Append("select St_ID,St_Name,St_EmpName,St_Phone,St_Address,St_Enable,St_Clear,St_Remark,St_Safetyone,St_Safetytwo,St_Code ");
            strSql.Append(" FROM T_Storage where St_Clear = 1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
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
            strSql.Append(" St_ID,St_Name,St_EmpName,St_Phone,St_Address,St_Enable,St_Clear,St_Remark,St_Safetyone,St_Safetytwo,St_Code ");
            strSql.Append(" FROM T_Storage ");
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
            strSql.Append("select count(1) FROM T_Storage ");
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
                strSql.Append("order by T.St_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_Storage T ");
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
			parameters[0].Value = "T_Storage";
			parameters[1].Value = "St_ID";
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
        /// 更新一条数据
        /// </summary>
        public bool UpdateByCode(Storage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Storage set ");
            strSql.Append("St_Name=@St_Name,");
            strSql.Append("St_EmpName=@St_EmpName,");
            strSql.Append("St_Phone=@St_Phone,");
            strSql.Append("St_Address=@St_Address,");
            strSql.Append("St_Enable=@St_Enable,");
            strSql.Append("St_Clear=@St_Clear,");
            strSql.Append("St_Remark=@St_Remark,");
            strSql.Append("St_Safetyone=@St_Safetyone,");
            strSql.Append("St_Safetytwo=@St_Safetytwo");
            strSql.Append(" where St_Code=@St_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@St_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_EmpName", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Phone", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Enable", SqlDbType.Int,4),
                    new SqlParameter("@St_Clear", SqlDbType.Int,4),
                    new SqlParameter("@St_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@St_Safetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Safetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@St_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.St_Name;
            parameters[1].Value = model.St_EmpName;
            parameters[2].Value = model.St_Phone;
            parameters[3].Value = model.St_Address;
            parameters[4].Value = model.St_Enable;
            parameters[5].Value = model.St_Clear;
            parameters[6].Value = model.St_Remark;
            parameters[7].Value = model.St_Safetyone;
            parameters[8].Value = model.St_Safetytwo;
            parameters[9].Value = model.St_Code;

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
        /// 根据编号做假删除 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            String strSql = "update T_Storage set St_Clear = 0 where St_Code = @St_Code";
            SqlParameter[] parameter =
            {
                new SqlParameter("@St_Code",SqlDbType.NVarChar,512)
            };
            parameter[0].Value = code;

            int rows = DbHelperSQL.ExecuteSql(strSql, parameter);
            if(rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        #endregion
    }
}

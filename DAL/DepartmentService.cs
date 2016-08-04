using HelperUtility.Encrypt;
using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DepartmentService
    {
        CodingHelper ch = new CodingHelper();
        #region 添加信息
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="department">参数实体类</param>
        /// <returns></returns>
        public int InsDepartment(Department department)
        {
            string sql = @"INSERT INTO T_Department
           (Dt_Code
           , Dt_RoleCode
           , Dt_Name
           , Dt_Clear)
     VALUES
           (@Dt_Code,
           , @Dt_RoleCode,
           , @Dt_Name,
           , @Dt_Clear";
            SqlParameter[] sps =
            {
                new SqlParameter("@Dt_Code",XYEEncoding.strCodeHex(department.Dt_Code)),
                new SqlParameter("@Dt_RoleCode",XYEEncoding.strCodeHex(department.Dt_RoleCode)),
                new SqlParameter("@Dt_Name",XYEEncoding.strCodeHex(department.Dt_Name)),
                new SqlParameter("@Dt_Clear",department.Dt_Clear)
            };
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="Dt_Code">编号</param>
        /// <returns></returns>
        public int FalseDelClear(string Dt_Code)
        {
            string sql = string.Format("update T_Department set Dt_Clear=0 where Dt_Clear=1 and Dt_Code={0}", XYEEncoding.strCodeHex(Dt_Code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 全部删除
        /// <summary>
        /// 全部删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            string sql = string.Format("update T_Department set Dt_Clear=0 where Dt_Clear=1");
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelDepartment()
        {
            string sql = "select * from T_Department where Dt_Clear=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Department");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <param name="Dt_Code">编号</param>
        /// <returns></returns>
        public Department SelDepartmentByCode(string Dt_Code)
        {
            string sql = string.Format("select * from T_Department WHERE Dt_Code='{0}'", Dt_Code);
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Department department = new Department()
                {
                    Dt_ID = Convert.ToInt32(read["Dt_ID"]),
                    Dt_Name = read["Dt_Name"].ToString(),
                    Dt_RoleCode = read["Dt_RoleCode"].ToString(),
                    Dt_Code = read["Dt_Code"].ToString(),
                    Dt_Clear = Convert.ToInt32(read["Dt_Clear"])
                };
                return department;
            }
            return null;
        }
        #endregion
    }
}

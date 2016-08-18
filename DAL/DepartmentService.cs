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
            string sql = string.Format("insert into T_Department values('{0}','{1}','{2}','{3}')",department.Dt_Code,department.Dt_RoleCode,department.Dt_Name,department.Dt_Clear);
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
            string sql = string.Format("update T_Department set Dt_Clear=0 where Dt_Clear=1 and Dt_Code='{0}'", XYEEncoding.strCodeHex(Dt_Code));
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

        #region 查询信息
        /// <summary>
        /// 查询部门全部信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetListDep()
        {
            string sql = "select * from T_Department td,T_Role tr where td.Dt_RoleCode=tr.Role_Code and td.Dt_Clear=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Department");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        #endregion

        #region 修改信息
        /// <summary>
        /// 根据编号修改信息
        /// </summary>
        /// <param name="empolyee"></param>
        /// <returns></returns>
        public int UpdateDepartment(Department dep)
        {
            string sql = @"update T_Department set 
             Dt_RoleCode=@Dt_RoleCode
            ,Dt_Name=@Dt_Name
             where Dt_Code=@Dt_Code";
            SqlParameter[] sps =
            {
                new SqlParameter("@Dt_RoleCode",XYEEncoding.strCodeHex(dep.Dt_RoleCode)),
                new SqlParameter("@Dt_Name",XYEEncoding.strCodeHex(dep.Dt_Name)),
                new SqlParameter("@Dt_Code",XYEEncoding.strCodeHex(dep.Dt_Code)),
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
            #endregion

        }
    }
}

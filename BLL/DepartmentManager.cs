using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DepartmentManager
    {
        DepartmentService ds = new DepartmentService();
        #region 添加信息
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="department">参数实体类</param>
        /// <returns></returns>
        public int InsDepartment(Department department)
        {
            return ds.InsDepartment(department);
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
            return ds.FalseDelClear(Dt_Code);
        }
        #endregion

        #region 全部删除
        /// <summary>
        /// 全部删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            return ds.FalseALLDelClear();
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelDepartment()
        {
            return ds.SelDepartment();
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
            return ds.SelDepartmentByCode(Dt_Code);
        }
        #endregion
    }
}
using DAL;
using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class ProjectInCostManager
    {
        ProjectInCostService pics = new ProjectInCostService();

        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="projectCost">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsProjectInCost(ProjectInCost projectInCost)
        {
            return pics.InsProjectInCost(projectInCost);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="PIC_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int UpdateClearProjectInCost(string PIC_Code)
        {
            return pics.UpdateClearProjectInCost(PIC_Code);
        }
        #endregion

        #region 假删除全部
        /// <summary>
        /// 假删除全部
        /// </summary>
        /// <returns>受影响行数</returns>
        public int UpdateAllClearProjectInCost()
        {
            return pics.UpdateAllClearProjectInCost();
        }
        #endregion

        #region 禁用
        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="PIC_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int UpdateEnableProjectInCost(string PIC_Code)
        {
            return pics.UpdateEnableProjectInCost(PIC_Code);
        }
        #endregion

        #region 改名称
        /// <summary>
        /// 改名称
        /// </summary>
        /// <param name="PIC_Name">名称</param>
        /// <param name="PIC_Code">编号</param>
        /// <param name="FPIC_Name">之前的名称</param>
        /// <returns>受影响行数</returns>
        public int UpdateNameProjectInCost(string PIC_Name, string PIC_Code, string FPIC_Name)
        {
            return pics.UpdateNameProjectInCost(PIC_Name, PIC_Code, FPIC_Name);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <param name="PIC_Code">编号</param>
        /// <returns>List集合</returns>
        public List<ProjectInCost> SelProjectInCostByCode(string PIC_Code)
        {
            return pics.SelProjectInCostByCode(PIC_Code);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<ProjectInCost> SelProjectInCost()
        {
            return pics.SelProjectInCost();
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelProjectInCostTable()
        {
            return pics.SelProjectInCostTable();
        }
        #endregion
    }
}

using DAL;
using Model;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class ProjectCostManager
    {
        ProjectCostService pics = new ProjectCostService();

        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="projectCost">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsProjectCost(ProjectCost projectCost)
        {
            return pics.InsProjectCost(projectCost);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="PIC_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int UpdateClearProjectCost(string PIC_Code)
        {
            return pics.UpdateClearProjectCost(PIC_Code);
        }
        #endregion

        #region 假删除全部
        /// <summary>
        /// 假删除全部
        /// </summary>
        /// <returns>受影响行数</returns>
        public int UpdateAllClearProjectCost()
        {
            return pics.UpdateAllClearProjectCost();
        }
        #endregion

        #region 禁用
        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="PIC_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int UpdateEnableProjectCost(string PIC_Code)
        {
            return pics.UpdateEnableProjectCost(PIC_Code);
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
        public int UpdateNameProjectCost(string PIC_Name, string PIC_Code, string FPIC_Name)
        {
            return pics.UpdateNameProjectCost(PIC_Name, PIC_Code, FPIC_Name);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <param name="PIC_Code">编号</param>
        /// <returns>List集合</returns>
        public List<ProjectCost> SelProjectCostByCode(string PIC_Code)
        {
            return pics.SelProjectCostByCode(PIC_Code);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<ProjectCost> SelProjectCost()
        {
            return pics.SelProjectCost();
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelProjectCostTable()
        {
            return pics.SelProjectCostTable();
        }
        #endregion
    }
}

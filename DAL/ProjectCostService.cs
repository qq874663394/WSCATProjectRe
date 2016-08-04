using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProjectCostService
    {
        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="projectCost">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsProjectCost(ProjectCost projectCost)
        {
            string sql = @"INSERT INTO T_ProjectCost VALUES
                           (@PIC_Code
                           ,@PIC_Name
                           ,@PIC_ParentId
                           ,@PIC_Enable
                           ,@PIC_Clear)";
            SqlParameter[] sps =
            {
                new SqlParameter("@PIC_Code",XYEEncoding.strCodeHex(projectCost.PC_Code)),
                new SqlParameter("@PIC_Name",XYEEncoding.strCodeHex(projectCost.PC_Code)),
                new SqlParameter("@PIC_ParentId",XYEEncoding.strCodeHex(projectCost.PC_Code)),
                new SqlParameter("@PIC_Enable",projectCost.PC_Code),
                new SqlParameter("@PIC_Clear",projectCost.PC_Code)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
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
            string sql = string.Format("update T_ProjectCost set PIC_Clear=0 where PIC_Code='{0}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 假删除全部
        /// <summary>
        /// 假删除全部
        /// </summary>
        /// <returns>受影响行数</returns>
        public int UpdateAllClearProjectCost()
        {
            string sql = string.Format("update T_ProjectCost set PIC_Clear=0 where PIC_Clear=1 and PIC_Enable=1 and PIC_ParentId<>'D4'");
            return DbHelperSQL.ExecuteSql(sql);
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
            string sql = string.Format("update T_ProjectCost set PIC_Clear=0 where PIC_Code='{0}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Code));
            return DbHelperSQL.ExecuteSql(sql);
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
            string sql = string.Format("update T_ProjectCost set PIC_Name='{0}' where PIC_Code='{1}' and PIC_Name='{2}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Name), XYEEncoding.strCodeHex(PIC_Code), XYEEncoding.strCodeHex(FPIC_Name));
            return DbHelperSQL.ExecuteSql(sql);
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
            List<ProjectCost> list = new List<ProjectCost>();
            string sql = string.Format("select * from T_ProjectCost where PIC_Code='{0}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                ProjectCost pic = new ProjectCost()
                { 
                    PC_ID = Convert.ToInt32(read["PIC_ID"]),
                    PC_Name = XYEEncoding.strHexDecode(read["PIC_Name"].ToString()),
                    PC_Code = XYEEncoding.strHexDecode(read["PIC_Code"].ToString()),
                    PC_ParentId = XYEEncoding.strHexDecode(read["PIC_ParentId"].ToString()),
                    PC_Clear = Convert.ToInt32(read["PIC_Clear"].ToString()),
                    PC_Enable = Convert.ToInt32(read["PIC_Enable"].ToString())
                };
                list.Add(pic);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<ProjectCost> SelProjectCost()
        {
            List<ProjectCost> list = new List<ProjectCost>();
            string sql = "select * from T_ProjectCost where PIC_Clear=1 and PIC_Enable=1";
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                ProjectCost pic = new ProjectCost()
                {
                    PC_ID = Convert.ToInt32(read["PIC_ID"]),
                    PC_Name = XYEEncoding.strHexDecode(read["PIC_Name"].ToString()),
                    PC_Code = XYEEncoding.strHexDecode(read["PIC_Code"].ToString()),
                    PC_ParentId = XYEEncoding.strHexDecode(read["PIC_ParentId"].ToString()),
                    PC_Clear = Convert.ToInt32(read["PIC_Clear"].ToString()),
                    PC_Enable = Convert.ToInt32(read["PIC_Enable"].ToString())
                };
                list.Add(pic);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelProjectCostTable()
        {
            string sql = "select * from T_ProjectCost where PIC_Clear=1 and PIC_Enable=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_ProjectCost");
            return ds1.Tables[0];
        }
        #endregion
    }
}

using HelperUtility.Encrypt;
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
    public class ProjectInCostService
    {
        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="projectInCost">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsProjectInCost(ProjectInCost projectInCost)
        {
            string sql = @"INSERT INTO T_ProjectInCost VALUES
                           (@PIC_Code
                           ,@PIC_Name
                           ,@PIC_ParentId
                           ,@PIC_Enable
                           ,@PIC_Clear)";
            SqlParameter[] sps =
            {
                new SqlParameter("@PIC_Code",XYEEncoding.strCodeHex(projectInCost.PIC_Code)),
                new SqlParameter("@PIC_Name",XYEEncoding.strCodeHex(projectInCost.PIC_Name)),
                new SqlParameter("@PIC_ParentId",XYEEncoding.strCodeHex(projectInCost.PIC_ParentId)),
                new SqlParameter("@PIC_Enable",projectInCost.PIC_Enable),
                new SqlParameter("@PIC_Clear",projectInCost.PIC_Clear)
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
        public int UpdateClearProjectInCost(string PIC_Code)
        {
            string sql = string.Format("update T_ProjectInCost set PIC_Clear=0 where PIC_Code='{0}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 假删除全部
        /// <summary>
        /// 假删除全部
        /// </summary>
        /// <returns>受影响行数</returns>
        public int UpdateAllClearProjectInCost()
        {
            string sql = string.Format("update T_ProjectInCost set PIC_Clear=0 where PIC_Clear=1 and PIC_Enable=1 and PIC_ParentId<>'D4'");
            return DbHelperSQL.ExecuteSql(sql);
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
            string sql = string.Format("update T_ProjectInCost set PIC_Clear=0 where PIC_Code='{0}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Code));
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
        public int UpdateNameProjectInCost(string PIC_Name,string PIC_Code,string FPIC_Name)
        {
            string sql = string.Format("update T_ProjectInCost set PIC_Name='{0}' where PIC_Code='{1}' and PIC_Name='{2}' and PIC_Clear=1 and PIC_Enable=1",XYEEncoding.strCodeHex(PIC_Name),XYEEncoding.strCodeHex(PIC_Code),XYEEncoding.strCodeHex(FPIC_Name));
            return DbHelperSQL.ExecuteSql(sql);
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
            List<ProjectInCost> list = new List<ProjectInCost>();
            string sql = string.Format("select * from T_ProjectInCost where PIC_Code='{0}' and PIC_Clear=1 and PIC_Enable=1", XYEEncoding.strCodeHex(PIC_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                ProjectInCost pic = new ProjectInCost()
                {
                    PIC_ID = Convert.ToInt32(read["PIC_ID"]),
                    PIC_Name = XYEEncoding.strHexDecode(read["PIC_Name"].ToString()),
                    PIC_Code = XYEEncoding.strHexDecode(read["PIC_Code"].ToString()),
                    PIC_ParentId = XYEEncoding.strHexDecode(read["PIC_ParentId"].ToString()),
                    PIC_Clear = Convert.ToInt32(read["PIC_Clear"].ToString()),
                    PIC_Enable = Convert.ToInt32(read["PIC_Enable"].ToString())
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
        public List<ProjectInCost> SelProjectInCost()
        {
            List<ProjectInCost> list = new List<ProjectInCost>();
            string sql = "select * from T_ProjectInCost where PIC_Clear=1 and PIC_Enable=1";
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                ProjectInCost pic = new ProjectInCost()
                {
                    PIC_ID = Convert.ToInt32(read["PIC_ID"]),
                    PIC_Name = XYEEncoding.strHexDecode(read["PIC_Name"].ToString()),
                    PIC_Code = XYEEncoding.strHexDecode(read["PIC_Code"].ToString()),
                    PIC_ParentId = XYEEncoding.strHexDecode(read["PIC_ParentId"].ToString()),
                    PIC_Clear = Convert.ToInt32(read["PIC_Clear"].ToString()),
                    PIC_Enable = Convert.ToInt32(read["PIC_Enable"].ToString())
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
        public DataTable SelProjectInCostTable()
        {
            string sql = "select * from T_ProjectInCost where PIC_Clear=1 and PIC_Enable=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_ProjectInCost");
            return ds1.Tables[0];
        }
        #endregion
    }
}

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
    public class OrderTypeService
    {
        CodingHelper ch = new CodingHelper();
        #region 添加信息
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="OrderType">参数实体类</param>
        /// <returns></returns>
        public int InsOrderType(OrderType orderType)
        {
            string sql = string.Format("insert into T_OrderType (Ot_Name) values('{0}')", orderType);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据ID删除信息
        /// <summary>
        /// 根据ID删除信息
        /// </summary>
        /// <param name="Ot_ID">类型ID</param>
        /// <returns>受影响行数</returns>
        public int DelOrderType(string Ot_ID)
        {
            string sql = string.Format("delete from T_OrderType where Ot_ID={0}", Ot_ID);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 删除所有数据
        /// <summary>
        /// 删除所有数据
        /// </summary>
        /// <returns></returns>
        public int DelAllOrderType()
        {
            string sql = "TRUNCATE TABLE T_ORDERTYPE";
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据工号修改信息
        /// <summary>
        /// 根据工号修改信息
        /// </summary>
        /// <param name="ot"></param>
        /// <returns></returns>
        public int UpdateOrderType(OrderType ot)
        {
            string sql = string.Format("update T_OrderType set Ot_Name='{0}' where Ot_ID={1}", ot.Ot_Name, ot.Ot_ID);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelOrderType()
        {
            string sql = "select * from T_OrderType";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_OrderType");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <param name="Ot_ID">编号</param>
        /// <returns></returns>
        public OrderType SelOrderTypeByCode(int Ot_ID)
        {
            string sql = "select * from T_OrderType";
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                OrderType ot = new OrderType()
                {
                    Ot_ID = Convert.ToInt32(read["Ot_ID"]),
                    Ot_Code = read["Ot_Code"].ToString(),
                    Ot_Name = read["Ot_Name"].ToString()
                };
                return ot;
            }
            return null;
        }
        #endregion
    }
}

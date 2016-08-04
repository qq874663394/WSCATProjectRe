using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BorrowService
    {
        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="Bo_TypeName">类型名称</param>
        /// <returns>受影响行数</returns>
        public int InsBorrow(string Bo_TypeName)
        {
            string sql = string.Format("insert into T_Borrow values('{0}')", Bo_TypeName);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据ID删除信息
        /// <summary>
        /// 根据ID删除信息
        /// </summary>
        /// <param name="Bo_TypeID">类型ID</param>
        /// <returns>受影响行数</returns>
        public int DelBorrow(string Bo_TypeID)
        {
            string sql = string.Format("delete from T_Borrow where Bo_TypeID={0}", Bo_TypeID);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 删除所有数据
        /// <summary>
        /// 删除所有数据
        /// </summary>
        /// <returns></returns>
        public int DelAllBorrow()
        {
            string sql = "TRUNCATE TABLE T_BORROW";
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据ID修改信息
        /// <summary>
        /// 根据ID修改信息
        /// </summary>
        /// <param name="borrow">模型载体</param>
        /// <returns>受影响行数</returns>
        public int UpdateBorrow(Borrow borrow)
        {
            string sql = "update T_Borrow set Bo_TypeName=@Bo_TypeName where Bo_TypeID=@Bo_TypeID";
            SqlParameter[] sps = { new SqlParameter("@Bo_TypeName", borrow.Bo_TypeName), new SqlParameter("@Bo_TypeID", borrow.Bo_TypeID) };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 根据ID查询信息
        /// <summary>
        /// 根据ID查询信息
        /// </summary>
        /// <param name="TypeID">类型ID</param>
        /// <returns>List集合</returns>
        public List<Borrow> SelBorrowByTypeID(int TypeID)
        {
            List<Borrow> list = new List<Borrow>();
            string sql = string.Format("select * from T_Borrow where Bo_TypeID={0}", TypeID);
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Borrow tb = new Borrow()
                {
                    Bo_TypeID = Convert.ToInt32(read["Bo_TypeID"]),
                    Bo_TypeName = read["Bo_TypeName"].ToString()
                };
                list.Add(tb);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<Borrow> SelBorrow()
        {
            List<Borrow> list = new List<Borrow>();
            string sql = "select * from T_Borrow";
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Borrow tb = new Borrow()
                {
                    Bo_TypeID = Convert.ToInt32(read["Bo_TypeID"]),
                    Bo_TypeName = read["Bo_TypeName"].ToString()
                };
                list.Add(tb);
            }
            return list;
        }
        #endregion
    }
}
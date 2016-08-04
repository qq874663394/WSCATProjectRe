using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BorrowManager
    {
        BorrowService bs = new BorrowService();

        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="Bo_TypeName">类型名称</param>
        /// <returns>受影响行数</returns>
        public int InsBorrow(string Bo_TypeName)
        {
            return bs.InsBorrow(Bo_TypeName);
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
            return bs.DelBorrow(Bo_TypeID);
        }
        #endregion

        #region 删除所有数据
        /// <summary>
        /// 删除所有数据
        /// </summary>
        /// <returns></returns>
        public int DelAllBorrow()
        {
            return bs.DelAllBorrow();
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
            return bs.UpdateBorrow(borrow);
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
            return bs.SelBorrowByTypeID(TypeID);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<Borrow> SelBorrow()
        {
            return bs.SelBorrow();
        }
        #endregion
    }
}

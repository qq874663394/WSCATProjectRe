using DAL;
using Model;
using System.Data;
using System.Linq;

namespace BLL
{
    public class OrderTypeManager
    {
        OrderTypeService ots = new OrderTypeService();

        #region 添加信息
        /// <summary>
        /// 添信息
        /// </summary>
        /// <param name="OrderType">参数实体类</param>
        /// <returns></returns>
        public int InsOrderType(OrderType orderType)
        {
            return ots.InsOrderType(orderType);
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
            return ots.DelOrderType(Ot_ID);
        }
        #endregion

        #region 删除所有数据
        /// <summary>
        /// 删除所有数据
        /// </summary>
        /// <returns></returns>
        public int DelAllOrderType()
        {
            return ots.DelAllOrderType();
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
            return ots.UpdateOrderType(ot);
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelOrderType()
        {
            return ots.SelOrderType();
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
            return ots.SelOrderTypeByCode(Ot_ID);
        }
        #endregion
    }
}

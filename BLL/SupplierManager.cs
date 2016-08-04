using DAL;
using Model;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class SupplierManager
    {
        SupplierService ss = new SupplierService();

        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="supplier">模型</param>
        /// <returns>受影响行数</returns>
        public int InsSupplier(Supplier supplier)
        {
            return ss.InsSupplier(supplier);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="Su_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int FalseDelClear(string Su_Code)
        {
            return ss.FalseDelClear(Su_Code);
        }
        #endregion

        #region 全部假删除
        /// <summary>
        /// 全部假删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            return ss.FalseALLDelClear();
        }
        #endregion

        #region 根据编号修改信息
        /// <summary>
        /// 根据编号修改信息
        /// </summary>
        /// <param name="supplier">模型载体</param>
        /// <returns>受影响行数</returns>
        public int UpdateSupplier(Supplier supplier)
        {
            return ss.UpdateSupplier(supplier);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <returns></returns>
        public List<Supplier> SelSupplierByCode(string Su_Code)
        {
            return ss.SelSupplierByCode(Su_Code);
        }
        #endregion

        #region 根据城市查询信息
        /// <summary>
        /// 根据城市查询信息
        /// </summary>
        /// <returns></returns>
        public List<Supplier> SelSupplierByCityCode(string Su_CityName)
        {
            return ss.SelSupplierByCityCode(Su_CityName);
        }
        #endregion

        #region 更新时查询信息
        /// <summary>
        /// 更新时查询信息
        /// </summary>
        /// <returns></returns>
        public Supplier SelUpdateSupplierByCode(string Su_Code)
        {
            return ss.SelUpdateSupplierByCode(Su_Code);
        }
        #endregion

        #region 自定义where查询
        /// <summary>
        /// 自定义where查询
        /// </summary>
        /// <returns></returns>
        public List<Supplier> SelSupplierByWhere(string SQLWhere)
        {
            return ss.SelSupplierByWhere(SQLWhere);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <param name="isDisEC">isDisEC：true仅显示启用,false显示启用和未删除</param>
        /// <returns></returns>
        public List<Supplier> SelSupplier(bool isDisEC)
        {
            return ss.SelSupplier(isDisEC);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelSupplierTable()
        {
            return ss.SelSupplierTable();
        }
        #endregion

        /// <summary>
        /// 查询供应商信息
        /// </summary>
        /// <returns></returns>

        public DataTable SelSupplierTable2()
        {
            return ss.SelSupplierTable2();
        }
    }
}

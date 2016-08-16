using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using HelperUtility.Encrypt;
using System.Data;

namespace BLL
{
    public class SellManager
    {
        private readonly SellService dal = new SellService();
        public Sell SelSellGatheringBySellCode(string Sell_Code)
        {
            return dal.SelSellGatheringBySellCode(Sell_Code);
        }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Sell_ID)
        {
            return dal.Exists(Sell_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Sell model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Sell model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Sell_ID)
        {

            return dal.Delete(Sell_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Sell_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(Sell_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Sell GetModel(string Sell_Code)
        {

            return dal.GetModel(Sell_Code);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Sell> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Sell> DataTableToList(DataTable dt)
        {
            List<Sell> modelList = new List<Sell>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Sell model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        // <summary>
        // 分页获取数据列表
        // </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod

        #region  ExtensionMethod

        /// <summary>
        /// 判断该数据是否存在
        /// </summary>
        /// <param name="Sell_Code">销售单单号</param>
        /// <returns></returns>
        public bool Exists(string Sell_Code)
        {
            return dal.Exists(XYEEncoding.strCodeHex(Sell_Code));
        }

        /// <summary>
        /// 销售单真删除某数据
        /// </summary>
        /// <param name="Sell_Code">销售单单号</param>
        /// <returns></returns>
        public bool Delete(string Sell_Code)
        {
            return dal.Delete(XYEEncoding.strCodeHex(Sell_Code));
        }

        /// <summary>
        /// 根据销售单code假删除某一条数据
        /// </summary>
        /// <param name="Sell_Code">销售单code</param>
        /// <returns></returns>
        public bool DeleteFake(string Sell_Code)
        {
            return dal.DeleteFake(XYEEncoding.strCodeHex(Sell_Code));
        }

        /// <summary>
        /// 销售单保存
        /// </summary>
        /// <param name="sell">销售单单实体</param>
        /// <param name="sd">销售明细实体</param>
        /// <param name="sp">销售流程实体</param>
        /// <param name="inStock">是否生成入库单</param>
        /// <returns></returns>
        public int SaveSellOdd(Sell sell, List<SellDetail> sd, SellProcess sp, bool inStock)
        {
            try
            {
                dal.SaveSellOdd(sell, sd, sp, inStock);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="strWhere">查询的where条件</param>
        /// <returns>数据列表</returns>
        public DataTable GetList(string strWhere)
        {
            CodingHelper ch = new CodingHelper();
            return ch.DataTableReCoding(dal.GetList(strWhere).Tables[0]);
        }

        /// <summary>
        /// 根据仓库code和物料code查询库存量,当仓库code为空时查询所有库存数列表 
        /// </summary>
        /// <param name="stockDT">库存量</param>
        /// <param name="stockCode">仓库code</param>
        /// <param name="maCode">物料code</param>
        /// <returns></returns>
        public DataTable searchMaterialStockNumber(DataTable stockDT, string stockCode, string maCode)
        {
            if (stockCode == "")
            {
                var result = stockDT.AsEnumerable().Where(c => c["Sto_maID"].Equals(maCode));
                DataTable resultDT = stockDT.Clone();
                if (result.Count() > 0)
                {
                    resultDT = result.CopyToDataTable();
                }
                return resultDT;
            }
            else
            {
                var result = stockDT.AsEnumerable().Where(c => c["Sto_maID"].Equals(maCode) &&
                c["Sto_StID"].Equals(stockCode));
                DataTable resultDT = stockDT.Clone();
                if (result.Count() > 0)
                {
                    resultDT = result.CopyToDataTable();
                }
                return resultDT;
            }
        }


        public DataTable searchMaterialByzhujimaAndNameAndModel(DataTable maDT, string value)
        {
            var result = maDT.AsEnumerable().Where(c => c["Ma_Name"].ToString().Contains(value));
            DataTable resultDT = maDT.Clone();
            if (result.Count() > 0)
            {
                resultDT = result.CopyToDataTable();
            }
            return resultDT;
        }

        #endregion  ExtensionMethod
    }
}

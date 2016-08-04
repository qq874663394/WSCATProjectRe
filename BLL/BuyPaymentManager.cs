using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class BuyPaymentManager
    {
        private readonly BuyPaymentService dal = new BuyPaymentService();

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
        public bool Exists(int Buy_ID)
        {
            return dal.Exists(Buy_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BuyPayment model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(BuyPayment model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Buy_ID)
        {

            return dal.Delete(Buy_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Buy_IDlist)
        {
            return dal.DeleteList(Buy_IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BuyPayment GetModel(string Buy_Code)
        {
            return dal.GetModel(Buy_Code);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
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
        public List<BuyPayment> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BuyPayment> DataTableToList(DataTable dt)
        {
            List<BuyPayment> modelList = new List<BuyPayment>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                BuyPayment model;
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool PaymentUpdate(BuyPayment model)
        {
            return dal.PaymentUpdate(model);
        }
        /// <summary>
        /// 更改审核状态
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool ReveiweUpdate(string code)
        {
            return dal.ReveiweUpdate(code);
        }
        /// <summary>
        /// 新增申请付款单
        /// </summary>
        /// <param name="buypay"></param>
        /// <returns></returns>
        public int InsBuyPayment(BuyPayment buypay)
        {
            return dal.InsBuyPayment(buypay);
        }
        /// <summary>
        /// 根据采购单号查询商品明细
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet SelEmp(string strWhere)
        {
            return dal.SelEmp(strWhere);
        }
            #endregion  ExtensionMethod
        }
}

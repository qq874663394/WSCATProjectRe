using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BuyManager
    {
        BuyService bs = new BuyService();

        public DataTable SelBuyDataTableToCheck()
        {
            return bs.SelBuyDataTableToCheck();
        }
        public DataTable SelBuyDataTable()
        {
            return bs.SelBuyDataTable();
        }
        public DataTable SelBuyByCodeDataTable(string code)
        {
            return bs.SelBuyByCodeDataTable(code);
        }
        public List<Buy> SelBuyByCode(string code)
        {
            return bs.SelBuyByCode(code);
        }
        public Buy SelBuyByCodeToModel(string code)
        {
            return bs.SelBuyByCodeToModel(code);
        }
        public int UpdateBuyByCode(int purchaseStatus, int auditStatus, string code)
        {
            return bs.UpdateBuyByCode(purchaseStatus, auditStatus, code);
        }
        /// <summary>
        /// 更新付款状态
        /// </summary>
        public bool PaymentUpdate(string code, int shu)
        {
            return bs.PaymentUpdate(code, shu);
        }
        // <summary>
        /// 更新物流信息以及申请状态
        /// </summary>
        public bool LogisticalUpdate(Buy model)
        {
            return bs.LogisticalUpdate(model);
        }
        /// <summary>
        /// 获得应付款单数据列表 
        /// </summary>
        public DataTable GetYinFuList()
        {
            return bs.GetYinFuList();
        }
        /// <summary>
        /// 是否存在已审核和已付款的该记录
        /// </summary>
        public bool Exists(string Buy_Code)
        {
            return bs.Exists(Buy_Code);
        }
        /// <summary>
        /// 提交申请单更新状态
        /// </summary>
        /// <param name="code"></param>
        /// <param name="shu"></param>
        /// <returns></returns>
        public bool PaymentUpdateByCode(string code, int shu)
        {
            return bs.PaymentUpdateByCode(code, shu);
        }
        /// <summary>
        /// 批量增加多条数据 
        /// </summary>
        /// <param name="sqlList">要增加的sql</param>
        /// <returns>影响行数</returns>
        public int AddBatch(List<string> sqlList)
        {
            return bs.AddBatch(sqlList);
        }
        /// <summary>
        /// 批量增加多条数据到销售单
        /// </summary>
        /// <param name="buyValues">主单数据,数量为22个字段</param>
        /// <param name="detailList">从单数据,商品的信息.17个字段</param>
        /// <returns>受影响的行数</returns>
        public int AddBatch(Buy buy, List<BuyDetail> buyDetail)
        {
            return bs.AddBatch(buy, buyDetail);
        }

        /// <summary>
        /// 查询采购的进度
        /// </summary>
        /// <returns></returns>
        public DataTable SelBuyJindu()
        {
            return bs.SelBuyJindu();
        }

        /// <summary>
        /// 查询采购待处理事项
        /// </summary>
        /// <returns></returns>
        public DataTable SelBuyDaiChuli()
        {
            return bs.SelBuyDaiChuli();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using HelperUtility.Encrypt;
namespace BLL
{
    public class MaterialManager
    {
        private readonly MaterialService dal = new MaterialService();

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
        public bool Exists(int Ma_ID)
        {
            return dal.Exists(Ma_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Material model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Material model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Ma_ID)
        {

            return dal.Delete(Ma_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Ma_IDlist)
        {
            return dal.DeleteList(HelperUtility.
                Validate.RegexValidate.SafeLongFilter(Ma_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Material GetModel(int Ma_ID)
        {

            return dal.GetModel(Ma_ID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            CodingHelper codingHelper = new CodingHelper();
            return codingHelper.DataSetReCoding(dal.GetList(strWhere));
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
        public List<Material> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Material> DataTableToList(DataTable dt)
        {
            List<Material> modelList = new List<Material>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Material model;
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
        // 分页获取数据列表
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod

        #region  ExtensionMethod

        /// <summary>
        /// 假删除数据 
        /// </summary>
        /// <param name="code">删除的编号</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            return (dal.DeleteFake(XYEEncoding.strCodeHex(code)));
        }

        public DataTable searchClientByNodeClick(DataTable dt, string nodeText, string field)
        {
            if (nodeText == "所有类型")
            {
                return dt;
            }
            else
            {
                string f = "";
                switch (field)
                {
                    case "物料名称":
                        f = "Ma_Name";
                        break;
                    case "助记码":
                        f = "Ma_zhujima";
                        break;
                    case "类别名称":
                        f = "Ma_TypeName";
                        break;
                    case "供应商":
                        f = "Ma_Supplier";
                        break;
                }
                var result = dt.AsEnumerable().
                Where(c => c[f].ToString().Contains(nodeText));

                //为防止无法检索到任何数据的情况下无法复制结果datatable给新的datatable 
                //故用中间量先进行检查  
                DataTable resultDT = dt.Clone();
                if (result.Count() > 0)
                {
                    resultDT = result.CopyToDataTable();
                }
                return resultDT;
            }
        }

        #endregion  ExtensionMethod
    }
}

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
    public class MaterialTypeManager
    {
        private readonly MaterialTypeService dal = new MaterialTypeService();

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetListToTable(string strWhere)
        {
            return dal.GetListToTable(strWhere);
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
        public bool Exists(int MT_ID)
        {
            return dal.Exists(MT_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(MaterialType model)
        {
            model.MT_Code = XYEEncoding.strCodeHex(model.MT_Code);
            model.MT_Name = XYEEncoding.strCodeHex(model.MT_Name);
            model.MT_ParentID = XYEEncoding.strCodeHex(model.MT_ParentID);
            
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(MaterialType model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int MT_ID)
        {

            return dal.Delete(MT_ID);
        }

        /// <summary>
        /// 批量删除数据数据
        /// </summary>
        public bool DeleteList(string MT_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(MT_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public MaterialType GetModel(int MT_ID)
        {

            return dal.GetModel(MT_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            CodingHelper ch = new CodingHelper();
            return ch.DataSetReCoding(dal.GetList(strWhere));
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
        public List<MaterialType> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<MaterialType> DataTableToList(DataTable dt)
        {
            List<MaterialType> modelList = new List<MaterialType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                MaterialType model;
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MT_Code)
        {
            return dal.Exists(MT_Code);
        }

        /// <summary>
		/// 根据code更新一条数据
		/// </summary>
		public bool UpdateByCode(MaterialType model)
        {
            model.MT_Name = XYEEncoding.strCodeHex(model.MT_Name);
            model.MT_Code = XYEEncoding.strCodeHex(model.MT_Code);
            model.MT_ParentID = XYEEncoding.strCodeHex(model.MT_ParentID);

            return dal.UpdateByCode(model);
        }

        /// <summary>
        /// 根据code假删除数据
        /// </summary>
        /// <param name="code">编号</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            return dal.DeleteFake(XYEEncoding.strCodeHex(code));
        }

        /// <summary>
        /// 假删除所有除了根节点之外的所有节点
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllFake()
        {
            return dal.DeleteAllFake();
        }
        #endregion  ExtensionMethod
    }
}

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
    public class RoleManager
    {
        private readonly RoleService dal = new RoleService();
        private CodingHelper ch = new CodingHelper();

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
        public bool Exists(int Role_ID)
        {
            return dal.Exists(Role_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Role model)
        {
            model.Role_Code = XYEEncoding.strCodeHex(model.Role_Code);
            model.Role_Modules = XYEEncoding.strCodeHex(model.Role_Modules);
            model.Role_Name = XYEEncoding.strCodeHex(model.Role_Name);
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Role model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Role_ID)
        {

            return dal.Delete(Role_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Role_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(Role_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Role GetModel(int Role_ID)
        {

            return dal.GetModel(Role_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return  ch.DataSetReCoding(dal.GetList(strWhere));
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
        public List<Role> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Role> DataTableToList(DataTable dt)
        {
            List<Role> modelList = new List<Role>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Role model;
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Role_Code)
        {
            return dal.Exists(Role_Code);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Role GetModel(string Role_Code)
        {
            return dal.GetModel(Role_Code);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateByCode(Role model)
        {
            return dal.UpdateByCode(model);
        }

        /// <summary>
        /// 删除一条数据 
        /// </summary>
        public bool Delete(string Role_Code)
        {
            return dal.Delete(Role_Code);
        }

        #endregion  ExtensionMethod

    }
}

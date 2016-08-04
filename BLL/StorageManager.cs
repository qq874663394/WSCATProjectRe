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
    public class StorageManager
    {
        private readonly StorageService dal = new StorageService();

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
        public bool Exists(int St_ID)
        {
            return dal.Exists(St_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Storage model)
        {
            model.St_Address = XYEEncoding.strCodeHex(model.St_Address);
            model.St_Code = XYEEncoding.strCodeHex(model.St_Code);
            model.St_EmpName = XYEEncoding.strCodeHex(model.St_EmpName);
            model.St_Name = XYEEncoding.strCodeHex(model.St_Name);
            model.St_Phone = XYEEncoding.strCodeHex(model.St_Phone);
            model.St_Remark = XYEEncoding.strCodeHex(model.St_Remark);

            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Storage model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int St_ID)
        {

            return dal.Delete(St_ID);
        }
        /// <summary>
        /// 删除一条数据 
        /// </summary>
        public bool DeleteList(string St_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(St_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Storage GetModel(int St_ID)
        {

            return dal.GetModel(St_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            CodingHelper c = new CodingHelper();
            return c.DataSetReCoding(dal.GetList(strWhere));
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
        public List<Storage> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Storage> DataTableToList(DataTable dt)
        {
            List<Storage> modelList = new List<Storage>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Storage model;
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
            CodingHelper c = new CodingHelper();
            
            return c.DataSetReCoding(GetList(""));
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
        public bool UpdateByCode(Storage model)
        {
            model.St_Address = XYEEncoding.strCodeHex(model.St_Address);
            model.St_Code = XYEEncoding.strCodeHex(model.St_Code);
            model.St_EmpName = XYEEncoding.strCodeHex(model.St_EmpName);
            model.St_Name = XYEEncoding.strCodeHex(model.St_Name);
            model.St_Phone = XYEEncoding.strCodeHex(model.St_Phone);
            model.St_Remark = XYEEncoding.strCodeHex(model.St_Remark);
            return dal.UpdateByCode(model);
        }

        /// <summary>
        /// 根据编号做假删除 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            return dal.DeleteFake(XYEEncoding.strCodeHex(code));
        }

        #endregion  ExtensionMethod
    }
}

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
    public class UserManager
    {
        private readonly UserService dal = new UserService();

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
        public bool Exists(int User_ID)
        {
            return dal.Exists(User_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(User model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(User model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int User_ID)
        {

            return dal.Delete(User_ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string User_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(User_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public User GetModel(int User_ID)
        {

            return dal.GetModel(User_ID);
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
        public List<User> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<User> DataTableToList(DataTable dt)
        {
            List<Model.User> modelList = new List<User>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                User model;
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
        public bool Exists(string User_Name)
        {
            return dal.Exists(XYEEncoding.strCodeHex(User_Name));
        }

        /// <summary>
        /// 根据code更新一条数据
        /// </summary>
        public bool UpdateByCode(User model)
        {
            return dal.UpdateByCode(model);
        }

        /// <summary>
        /// 根据用户名和密码获得实体
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public User GetModel(string name,string password)
        {
            return dal.GetModel(XYEEncoding.strCodeHex(name),
                XYEEncoding.strCodeHex(password));
        }

        /// <summary>
        /// 根据user_role做内链接
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable GetUserAndRoleModel(string name, string password)
        {
            CodingHelper ch = new CodingHelper();
            //查询后解密返回
            return ch.DataTableReCoding(dal.GetUserAndRoleModel(XYEEncoding.strCodeHex(name),
                XYEEncoding.strCodeHex(password)));
              
        }

        #endregion  ExtensionMethod
    }
}

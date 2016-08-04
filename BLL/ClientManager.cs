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
    public class ClientManager
    {
        private readonly ClientService dal = new ClientService();
        CodingHelper ch = new CodingHelper();

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
        public bool Exists(int Cli_ID)
        {
            return dal.Exists(Cli_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Client model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Client model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Cli_ID)
        {

            return dal.Delete(Cli_ID);
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Cli_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(Cli_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Client GetModel(int Cli_ID)
        {

            return dal.GetModel(Cli_ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
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
        public List<Client> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Client> DataTableToList(DataTable dt)
        {
            List<Client> modelList = new List<Client>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Client model;
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

        //分页获取数据列表
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        
        #region  ExtensionMethod

        /// <summary>
        /// 用事务新增客户和折扣
        /// </summary>
        public bool AddClientAndDiscount(Client client, Discount discount)
        {
            return dal.AddClientAndDiscount(client, discount);
        }

        /// <summary>
        /// 根据code更新客户数据列表
        /// </summary>
        public bool UpdateByCode(Client client)
        {
            return dal.UpdateByCode(client);
        }

        /// <summary>
        /// 根据点击的节点用linq的lambda表达式检索数据 
        /// </summary>
        /// <param name="dt">所有数据列表</param>
        /// <param name="nodeText">查询的文本</param>
        /// /// <param name="field">查询的数据列</param>
        /// <returns></returns>
        public DataTable searchClientByNodeClick(DataTable dt, string nodeText, string field)
        {
            if(nodeText == "所有节点")
            {
                return dt;
            }
            else
            {
                string f = "";
                switch(field)
                {
                    case "客户名称":
                        f = "Cli_Name";
                        break;
                    case "单位名称":
                        f = "Cli_Company";
                        break;
                    case "联系人":
                        f = "Cli_LinkMan";
                        break;
                    case "手机号":
                        f = "Cli_Phone";
                        break;
                    case "地区":
                        f = "Cli_area";
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
        
        /// <summary>
        /// 根据code做假删除
        /// </summary>
        /// <param name="code">编号</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            return dal.DeleteFake(XYEEncoding.strCodeHex(code));
        }

        /// <summary>
        /// 获取简略的客户信息,包含编号/名称/电话/手机/地址/联系人/公司名称/备注
        /// </summary>
        /// <returns></returns>
        public DataSet GetListInSimple()
        {
            return ch.DataSetReCoding(dal.GetListInSimple());
        }

        #endregion  ExtensionMethod
    }
}

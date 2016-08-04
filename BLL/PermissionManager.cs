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
    public class PermissionManager
    {
        private readonly PermissionService dal = new PermissionService();
        private CodingHelper ch = new CodingHelper();

        /// <summary>
        /// 取得最大ID
        /// </summary>
        /// <returns></returns>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Per_Code)
        {
            return dal.Exists(XYEEncoding.strCodeHex(Per_Code));
        }

        /// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Permission model)
        {
            return dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Permission model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 获得数据列表 
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return ch.DataSetReCoding(dal.GetList(strWhere));
        }

        /// <summary>
        /// 根据code做假删除 
        /// </summary>
        /// <param name="code">要删除的code</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            return dal.DeleteFake(code);
        }

        /// <summary>
        /// 根据点击的节点用linq的lambda表达式检索数据 
        /// </summary>
        /// <param name="dt">所有数据列表</param>
        /// <param name="nodeText">查询的文本</param>
        /// /// <param name="field">查询的数据列</param>
        /// <returns></returns>
        public DataTable searchClientByNodeClick(DataTable dt, string nodeText)
        {
            if (nodeText == "全部")
            {
                return dt;
            }
            else
            {
                var result = dt.AsEnumerable().
                    Where(c => c["Per_ModuleName"].ToString().Equals(nodeText));
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
        /// 根据datatable里rowstatus为更改的行来更新数据库
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public bool UpdateBatch(DataTable ds)
        {
            return dal.UpdateBatch(ds);
        }

        /// <summary>
        /// 批量插入权限信息到数据库中 
        /// </summary>
        /// <param name="pList">要新增的实体列表</param>
        /// <returns></returns> 
        public int AddBatch(List<Permission> pList)
        {
            foreach(var p in pList)
            {
                p.Per_Code = XYEEncoding.strCodeHex(p.Per_Code);
                p.Per_ModuleName = XYEEncoding.strCodeHex(p.Per_ModuleName);
                p.Per_RoleCode = XYEEncoding.strCodeHex(p.Per_RoleCode);
                p.Per_Type = XYEEncoding.strCodeHex(p.Per_Type);
            }
            return dal.AddBatch(pList);
        }
    }
}

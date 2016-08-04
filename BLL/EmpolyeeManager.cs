using DAL;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class EmpolyeeManager
    {
        EmpolyeeService es = new EmpolyeeService();
        #region 添加人员信息
        /// <summary>
        /// 添加人员信息
        /// </summary>
        /// <param name="empolyee">参数实体类</param>
        /// <returns></returns>
        public int InsEmpolyee(Empolyee empolyee)
        {
            return es.InsEmpolyee(empolyee);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="code">客户编码</param>
        /// <returns></returns>
        public int FalseDelClear(string code)
        {
            return es.FalseDelClear(code);
        }
        #endregion

        #region 全部删除
        /// <summary>
        /// 全部删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            return es.FalseALLDelClear();
        }
        #endregion

        #region 根据工号修改信息
        /// <summary>
        /// 根据工号修改信息
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int UpdateEmpolyee(Empolyee emp)
        {
            return es.UpdateEmpolyee(emp);
        }
        #endregion

        #region 根据工号查询信息
        /// <summary>
        /// 根据工号查询信息
        /// </summary>
        /// <param name="Emp_Code">工号</param>
        /// <returns></returns>
        public Empolyee SelEmpolyeeByCode(string Emp_Code)
        {
            return es.SelEmpolyeeByCode(Emp_Code);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <param name="isflag">是否显示禁用：true显示所有禁用状态的信息，false仅显示未禁用状态的信息</param>
        /// <returns></returns>
        public DataTable SelEmpolyee(bool isflag)
        {
            return es.SelEmpolyee(isflag);
        }

        /// <summary>
        /// 是否存在该用户记录
        /// </summary>
        public bool ExistsUser(string Emp_Name)
        {
            return es.ExistsUser(Emp_Name);
        }
        /// <summary>
        /// 是否登录成功
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable GetUserAndRoleModel(string name, string password)
        {
            return es.GetUserAndRoleModel(name, password);
        }
        #endregion

        /// <summary>
        /// 查询员工信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet SelEmp2(string strWhere)
        {
            return es.SelEmp2(strWhere);
        }
    }
}
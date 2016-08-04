using DAL;
using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BankAccountManager
    {
        BankAccountService bas = new BankAccountService();
        #region 添加信息
        /// <summary>
        /// 添信息
        /// </summary>
        /// <param name="tba">参数实体类</param>
        /// <returns></returns>
        public int InsBankAccount(BankAccount tba)
        {
            return bas.InsBankAccount(tba);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="Ba_Code">编号</param>
        /// <returns></returns>
        public int FalseDelClear(string Ba_Code)
        {
            return bas.FalseDelClear(Ba_Code);
        }
        #endregion

        #region 全部删除
        /// <summary>
        /// 全部删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            return bas.FalseALLDelClear();
        }
        #endregion

        #region 根据编号修改信息
        /// <summary>
        /// 根据编号修改信息
        /// </summary>
        /// <param name="BA">编号</param>
        /// <returns></returns>
        public int UpdateBA(BankAccount BA)
        {
            return bas.UpdateBA(BA);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <param name="isDisplayEnable">参数：默认为true 显示所有,false显示未禁用</param>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public BankAccount SelBankAccountByCode(string Ba_Code)
        {
            return bas.SelBankAccountByCode(Ba_Code);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <param name="isDisplayEnable">参数：默认为true 显示所有,false显示未禁用</param>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelBankAccount(bool isDisplayEnable)
        {
            return bas.SelBankAccount(isDisplayEnable);
        }
        #endregion
        /// <summary>
        /// 查询收款账号和名称
        /// </summary>
        /// <returns></returns>

        public DataTable SelBankAccount2()
        {
            return bas.SelBankAccount2();
        }
    }
}

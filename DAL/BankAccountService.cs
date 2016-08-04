using HelperUtility.Encrypt;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BankAccountService
    {
        CodingHelper ch = new CodingHelper();

        #region 添加信息
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="ba">参数实体类</param>
        /// <returns></returns>
        public int InsBankAccount(BankAccount ba)
        {
            string sql = @"insert into T_BankAccount(
                            Ba_Code,
                            Ba_OpenBank,
                            Ba_Account,
                            Ba_CardHolder,
                            Ba_Remark,
                            Ba_AvailablePrice,
                            Ba_Enable,
                            Ba_Clear)
                            values (
                            @Ba_Code,
                            @Ba_OpenBank,
                            @Ba_Account,
                            @Ba_CardHolder,
                            @Ba_Remark,
                            @Ba_AvailablePrice,
                            @Ba_Enable,
                            @Ba_Clear)";
            SqlParameter[] sps =
                {
                new SqlParameter("@Ba_Code",XYEEncoding.strCodeHex(ba.Ba_Code)),
                new SqlParameter("@Ba_OpenBank",XYEEncoding.strCodeHex(ba.Ba_OpenBank)),
                new SqlParameter("@Ba_Account",XYEEncoding.strCodeHex(ba.Ba_Account)),
                new SqlParameter("@Ba_CardHolder",XYEEncoding.strCodeHex(ba.Ba_CardHolder)),
                new SqlParameter("@Ba_Remark",XYEEncoding.strCodeHex(ba.Ba_Remark)),
                new SqlParameter("@Ba_AvailablePrice",XYEEncoding.strCodeHex(ba.Ba_AvailablePrice)),
                new SqlParameter("@Ba_Enable",ba.Ba_Enable),
                new SqlParameter("@Ba_Clear",ba.Ba_Clear)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
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
            string sql = string.Format("update T_BankAccount set Ba_Clear=0 where Ba_Code='{0}'", Ba_Code);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 全部删除
        /// <summary>
        /// 全部删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            string sql = string.Format("update T_BankAccount set Ba_Clear=0 where Ba_Clear=1");
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据编号修改信息
        /// <summary>
        /// 根据编号修改信息
        /// </summary>
        /// <param name="BA"></param>
        /// <returns></returns>
        public int UpdateBA(BankAccount BA)
        {
            string sql = @"update T_BankAccount 
            set Ba_OpenBank=@Ba_OpenBank,
            Ba_Account=@Ba_Account,
            Ba_CardHolder=@Ba_CardHolder,
            Ba_Remark=@Ba_Remark,
            Ba_AvailablePrice=@Ba_AvailablePrice,
            Ba_Enable=@Ba_Enable where Ba_Code=@Ba_Code";
            SqlParameter[] sps =
            {
                new SqlParameter("@Ba_OpenBank",XYEEncoding.strCodeHex(BA.Ba_OpenBank)),
                new SqlParameter("@Ba_Account",XYEEncoding.strCodeHex(BA.Ba_Account)),
                new SqlParameter("@Ba_CardHolder",XYEEncoding.strCodeHex(BA.Ba_CardHolder)),
                new SqlParameter("@Ba_Remark",XYEEncoding.strCodeHex(BA.Ba_Remark)),
                new SqlParameter("@Ba_AvailablePrice",XYEEncoding.strCodeHex(BA.Ba_AvailablePrice)),
                new SqlParameter("@Ba_Enable",BA.Ba_Enable),
                new SqlParameter("@Ba_Code",XYEEncoding.strCodeHex(BA.Ba_Code))
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 查询信息
        /// <summary>
        /// 根据编号查询信息 单条
        /// </summary>
        /// <param name="Ba_Code">编号</param>
        /// <returns></returns>
        public BankAccount SelBankAccountByCode(string Ba_Code)
        {
            string sql = string.Format("select top 1 * from T_BankAccount where Ba_Code='{0}'", XYEEncoding.strCodeHex(Ba_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                BankAccount BankAccount = new BankAccount()
                {
                    Ba_ID = Convert.ToInt32(read["Ba_ID"]),
                    Ba_Code = read["Ba_Code"].ToString(),
                    Ba_OpenBank = read["Ba_OpenBank"].ToString(),
                    Ba_Account = read["Ba_Account"].ToString(),
                    Ba_CardHolder = read["Ba_CardHolder"].ToString(),
                    Ba_Remark = read["Ba_Remark"].ToString(),
                    Ba_AvailablePrice = read["Ba_Remark"].ToString(),
                    Ba_Enable = Convert.ToInt32(read["Ba_Enable"])
                };
                return BankAccount;
            }
            return null;
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
            string sql = @"select 
            Ba_ID as ID,
            Ba_Code as 编码,
            Ba_OpenBank as 开户行,
            Ba_Account as 银行账号,
            Ba_CardHolder as 持卡人,
            Ba_Remark as 备注,
            Ba_AvailablePrice as 可用金额,
            (case 
            when Ba_Enable = 1 then '2A50591F3727'
            else '3635591F3727' end)
            as 是否禁用 from T_BankAccount where Ba_Clear=1";
            if (isDisplayEnable == false)
            {
                sql += " and Ba_Enable=1";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_BankAccount");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        #endregion

        /// <summary>
        /// 查询收款账号和名称
        /// </summary>
        /// <returns></returns>

        public DataTable SelBankAccount2()
        {
            string sql = @"select      
            Ba_Code as 编号,
            Ba_OpenBank as 账户名称
            from T_BankAccount   where Ba_Clear=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_BankAccount");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
    }
}

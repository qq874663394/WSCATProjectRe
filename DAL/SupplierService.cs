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
    public class SupplierService
    {
        CodingHelper ch = new CodingHelper();
        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="supplier">模型</param>
        /// <returns>受影响行数</returns>
        public int InsSupplier(Supplier supplier)
        {
            string sql = @"INSERT INTO T_Supplier(Su_Name
                           , Su_Phone
                           , Su_Address
                           , Su_fax
                           , Su_Email
                           , Su_Bankaccounts
                           , Su_Bank
                           , Su_ProCode
                           , Su_Credit
                           , Su_Money
                           , Su_Surplus
                           , Su_Reckoning
                           , Su_Empname
                           , Su_EmpPhone
                           , Su_Remark
                           , Su_Enable
                           , Su_Clear
                           , Su_Code
                           , Su_Area) 
VALUES(@Su_Name
                           , @Su_Phone
                           , @Su_Address
                           , @Su_fax
                           , @Su_Email
                           , @Su_Bankaccounts
                           , @Su_Bank
                           , @Su_ProCode
                           , @Su_Credit
                           , @Su_Money
                           , @Su_Surplus
                           , @Su_Reckoning
                           , @Su_Empname
                           , @Su_EmpPhone
                           , @Su_Remark
                           , @Su_Enable
                           , @Su_Clear
                           , @Su_Code
                           , @Su_Area)";
            SqlParameter[] sps =
            {
                    new SqlParameter("@Su_Name",XYEEncoding.strCodeHex(supplier.Su_Name)),
                    new SqlParameter("@Su_Phone",XYEEncoding.strCodeHex(supplier.Su_Phone)),
                    new SqlParameter("@Su_Address",XYEEncoding.strCodeHex(supplier.Su_Address)),
                    new SqlParameter("@Su_fax",XYEEncoding.strCodeHex(supplier.Su_fax)),
                    new SqlParameter("@Su_Email",XYEEncoding.strCodeHex(supplier.Su_Email)),
                    new SqlParameter("@Su_Bankaccounts",XYEEncoding.strCodeHex(supplier.Su_Bankaccounts)),
                    new SqlParameter("@Su_Bank",XYEEncoding.strCodeHex(supplier.Su_Bank)),
                    new SqlParameter("@Su_ProCode",XYEEncoding.strCodeHex(supplier.Su_ProCode)),
                    new SqlParameter("@Su_Credit",XYEEncoding.strCodeHex(supplier.Su_Credit)),
                    new SqlParameter("@Su_Money",supplier.Su_Money),
                    new SqlParameter("@Su_Surplus",supplier.Su_Surplus),
                    new SqlParameter("@Su_Reckoning",XYEEncoding.strCodeHex(supplier.Su_Reckoning)),
                    new SqlParameter("@Su_Empname",XYEEncoding.strCodeHex(supplier.Su_Empname)),
                    new SqlParameter("@Su_EmpPhone",XYEEncoding.strCodeHex(supplier.Su_EmpPhone)),
                    new SqlParameter("@Su_Remark",XYEEncoding.strCodeHex(supplier.Su_Remark)),
                    new SqlParameter("@Su_Enable",supplier.Su_Enable),
                    new SqlParameter("@Su_Clear",supplier.Su_Clear),
                    new SqlParameter("@Su_Code",XYEEncoding.strCodeHex(supplier.Su_Code)),
                    new SqlParameter("@Su_Area",XYEEncoding.strCodeHex(supplier.Su_Area))
                };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="Su_Code">编号</param>
        /// <returns></returns>
        public int FalseDelClear(string Su_Code)
        {
            string sql = string.Format("update T_Supplier set Su_Clear=0 where Su_Code='{0}'", XYEEncoding.strCodeHex(Su_Code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 全部假删除
        /// <summary>
        /// 全部假删除
        /// </summary>
        /// <returns></returns>
        public int FalseALLDelClear()
        {
            string sql = string.Format("update T_Supplier set Su_Clear=0 where Su_Clear=1");
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据编码修改信息
        /// <summary>
        /// 根据编号修改信息
        /// </summary>
        /// <param name="supplier">模型载体</param>
        /// <returns>受影响行数</returns>
        public int UpdateSupplier(Supplier supplier)
        {
            string sql = string.Format(@"UPDATE T_Supplier
                                 SET Su_Name = @Su_Name
                                  ,Su_Phone = @Su_Phone
                                  ,Su_Address = @Su_Address
                                  ,Su_fax = @Su_fax
                                  ,Su_Email = @Su_Email
                                  ,Su_Bankaccounts = @Su_Bankaccounts
                                  ,Su_Bank = @Su_Bank
                                  ,Su_ProCode = @Su_ProCode
                                  ,Su_Credit = @Su_Credit
                                  ,Su_Money = @Su_Money
                                  ,Su_Surplus = @Su_Surplus
                                  ,Su_Reckoning = @Su_Reckoning
                                  ,Su_Empname = @Su_Empname
                                  ,Su_EmpPhone = @Su_EmpPhone
                                  ,Su_Remark = @Su_Remark
                                  ,Su_Enable = @Su_Enable
                                  ,Su_Clear = @Su_Clear
                                  ,Su_Area=@Su_Area
                                 WHERE Su_Code=@Su_Code");
            SqlParameter[] sps =
            {
                new SqlParameter("@Su_Name",XYEEncoding.strCodeHex(supplier.Su_Name)),
                    new SqlParameter("@Su_Phone",XYEEncoding.strCodeHex(supplier.Su_Phone)),
                    new SqlParameter("@Su_Address",XYEEncoding.strCodeHex(supplier.Su_Address)),
                    new SqlParameter("@Su_fax",XYEEncoding.strCodeHex(supplier.Su_fax)),
                    new SqlParameter("@Su_Email",XYEEncoding.strCodeHex(supplier.Su_Email)),
                    new SqlParameter("@Su_Bankaccounts",XYEEncoding.strCodeHex(supplier.Su_Bankaccounts)),
                    new SqlParameter("@Su_Bank",XYEEncoding.strCodeHex(supplier.Su_Bank)),
                    new SqlParameter("@Su_ProCode",XYEEncoding.strCodeHex(supplier.Su_ProCode)),
                    new SqlParameter("@Su_Credit",XYEEncoding.strCodeHex(supplier.Su_Credit)),
                    new SqlParameter("@Su_Money",supplier.Su_Money),
                    new SqlParameter("@Su_Surplus",supplier.Su_Surplus),
                    new SqlParameter("@Su_Reckoning",XYEEncoding.strCodeHex(supplier.Su_Reckoning)),
                    new SqlParameter("@Su_Empname",XYEEncoding.strCodeHex(supplier.Su_Empname)),
                    new SqlParameter("@Su_EmpPhone",XYEEncoding.strCodeHex(supplier.Su_EmpPhone)),
                    new SqlParameter("@Su_Remark",XYEEncoding.strCodeHex(supplier.Su_Remark)),
                    new SqlParameter("@Su_Enable",supplier.Su_Enable),
                    new SqlParameter("@Su_Clear",supplier.Su_Clear),
                    new SqlParameter("@Su_Code",XYEEncoding.strCodeHex(supplier.Su_Code)),
                    new SqlParameter("@Su_Area",XYEEncoding.strCodeHex(supplier.Su_Area))
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <returns></returns>
        public List<Supplier> SelSupplierByCode(string Su_Code)
        {
            List<Supplier> list = new List<Supplier>();
            string sql = string.Format("select * from T_Supplier where Su_Code={0} and Su_Enable=1 and Su_Clear=1", XYEEncoding.strCodeHex(Su_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Supplier supplier = new Supplier()
                {
                    Su_ID = Convert.ToInt32(read["Su_ID"]),
                    Su_Name = XYEEncoding.strHexDecode(read["Su_Name"].ToString()),
                    Su_Phone = XYEEncoding.strHexDecode(read["Su_Phone"].ToString()),
                    Su_Address = XYEEncoding.strHexDecode(read["Su_Address"].ToString()),
                    Su_fax = XYEEncoding.strHexDecode(read["Su_fax"].ToString()),
                    Su_Email = XYEEncoding.strHexDecode(read["Su_email"].ToString()),
                    Su_Bankaccounts = XYEEncoding.strHexDecode(read["Su_Bankaccounts"].ToString()),
                    Su_Bank = XYEEncoding.strHexDecode(read["Su_Bank"].ToString()),
                    Su_ProCode = XYEEncoding.strHexDecode(read["Su_ProCode"].ToString()),
                    Su_Credit = XYEEncoding.strHexDecode(read["Su_Credit"].ToString()),
                    Su_Money = read["Su_Money"].ToString(),
                    Su_Surplus = read["Su_Surplus"].ToString(),
                    Su_Reckoning = XYEEncoding.strHexDecode(read["Su_Reckoning"].ToString()),
                    Su_Empname = XYEEncoding.strHexDecode(read["Su_Empname"].ToString()),
                    Su_EmpPhone = XYEEncoding.strHexDecode(read["Su_EmpPhone"].ToString()),
                    Su_Remark = XYEEncoding.strHexDecode(read["Su_Remark"].ToString()),
                    Su_Enable = Convert.ToInt32(read["Su_Enable"].ToString()),
                    Su_Clear = Convert.ToInt32(read["Su_Clear"].ToString()),
                    Su_Code = XYEEncoding.strHexDecode(read["Su_Code"].ToString()),
                    Su_Area = XYEEncoding.strHexDecode(read["Su_Area"].ToString()),
                    Su_EnableStr = Convert.ToInt32(read["Su_Enable"].ToString()) == 1 ? "未禁用" : "已禁用"
                };
                list.Add(supplier);
            }
            return list;
        }
        #endregion

        #region 更新时查询信息
        /// <summary>
        /// 更新时查询信息
        /// </summary>
        /// <returns></returns>
        public Supplier SelUpdateSupplierByCode(string Su_Code)
        {
            string sql = string.Format("select * from T_Supplier where Su_Code='{0}' and Su_Enable=1 and Su_Clear=1", XYEEncoding.strCodeHex(Su_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Supplier supplier = new Supplier()
                {
                    Su_ID = Convert.ToInt32(read["Su_ID"]),
                    Su_Name = XYEEncoding.strHexDecode(read["Su_Name"].ToString()),
                    Su_Phone = XYEEncoding.strHexDecode(read["Su_Phone"].ToString()),
                    Su_Address = XYEEncoding.strHexDecode(read["Su_Address"].ToString()),
                    Su_fax = XYEEncoding.strHexDecode(read["Su_fax"].ToString()),
                    Su_Email = XYEEncoding.strHexDecode(read["Su_email"].ToString()),
                    Su_Bankaccounts = XYEEncoding.strHexDecode(read["Su_Bankaccounts"].ToString()),
                    Su_Bank = XYEEncoding.strHexDecode(read["Su_Bank"].ToString()),
                    Su_ProCode = XYEEncoding.strHexDecode(read["Su_ProCode"].ToString()),
                    Su_Credit = XYEEncoding.strHexDecode(read["Su_Credit"].ToString()),
                    Su_Money = read["Su_Money"].ToString(),
                    Su_Surplus = read["Su_Surplus"].ToString(),
                    Su_Reckoning = XYEEncoding.strHexDecode(read["Su_Reckoning"].ToString()),
                    Su_Empname = XYEEncoding.strHexDecode(read["Su_Empname"].ToString()),
                    Su_EmpPhone = XYEEncoding.strHexDecode(read["Su_EmpPhone"].ToString()),
                    Su_Remark = XYEEncoding.strHexDecode(read["Su_Remark"].ToString()),
                    Su_Enable = Convert.ToInt32(read["Su_Enable"].ToString()),
                    Su_Clear = Convert.ToInt32(read["Su_Clear"].ToString()),
                    Su_Code = XYEEncoding.strHexDecode(read["Su_Code"].ToString()),
                    Su_Area = XYEEncoding.strHexDecode(read["Su_Area"].ToString()),
                    Su_EnableStr = Convert.ToInt32(read["Su_Enable"].ToString()) == 1 ? "未禁用" : "已禁用"
                };
                return supplier;
            }
            return null;
        }
        #endregion

        #region 根据城市编号查询信息
        /// <summary>
        /// 根据城市编号查询信息
        /// </summary>
        /// <returns></returns>
        public List<Supplier> SelSupplierByCityCode(string Su_CityName)
        {
            List<Supplier> list = new List<Supplier>();
            string sql = string.Format("select * from T_Supplier where Su_Area like '%{0}%' and Su_Enable=1 and Su_Clear=1", XYEEncoding.strCodeHex(Su_CityName));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Supplier supplier = new Supplier();
                supplier.Su_ID = Convert.ToInt32(read["Su_ID"]);
                supplier.Su_Name = XYEEncoding.strHexDecode(read["Su_Name"].ToString());
                supplier.Su_Phone = XYEEncoding.strHexDecode(read["Su_Phone"].ToString());
                supplier.Su_Address = XYEEncoding.strHexDecode(read["Su_Address"].ToString());
                supplier.Su_fax = XYEEncoding.strHexDecode(read["Su_fax"].ToString());
                supplier.Su_Email = XYEEncoding.strHexDecode(read["Su_email"].ToString());
                supplier.Su_Bankaccounts = XYEEncoding.strHexDecode(read["Su_Bankaccounts"].ToString());
                supplier.Su_Bank = XYEEncoding.strHexDecode(read["Su_Bank"].ToString());
                supplier.Su_ProCode = XYEEncoding.strHexDecode(read["Su_ProCode"].ToString());
                supplier.Su_Credit = XYEEncoding.strHexDecode(read["Su_Credit"].ToString());
                supplier.Su_Money = read["Su_Money"].ToString();
                supplier.Su_Surplus = read["Su_Surplus"].ToString();
                supplier.Su_Reckoning = XYEEncoding.strHexDecode(read["Su_Reckoning"].ToString());
                supplier.Su_Empname = XYEEncoding.strHexDecode(read["Su_Empname"].ToString());
                supplier.Su_EmpPhone = XYEEncoding.strHexDecode(read["Su_EmpPhone"].ToString());
                supplier.Su_Remark = XYEEncoding.strHexDecode(read["Su_Remark"].ToString());
                supplier.Su_Enable = Convert.ToInt32(read["Su_Enable"].ToString());
                supplier.Su_Clear = Convert.ToInt32(read["Su_Clear"].ToString());
                supplier.Su_Code = XYEEncoding.strHexDecode(read["Su_Code"].ToString());
                supplier.Su_Area = XYEEncoding.strHexDecode(read["Su_Area"].ToString());
                supplier.Su_EnableStr = Convert.ToInt32(read["Su_Enable"].ToString()) == 1 ? "未禁用" : "已禁用";
                list.Add(supplier);
            };
            return list;
        }
        #endregion

        #region 自定义where查询
        /// <summary>
        /// 自定义where查询
        /// </summary>
        /// <returns></returns>
        public List<Supplier> SelSupplierByWhere(string SQLWhere)
        {
            List<Supplier> list = new List<Supplier>();
            string sql = string.Format("select * from T_Supplier ");
            if (!string.IsNullOrWhiteSpace(SQLWhere))
            {
                sql = string.Format("{0} where {1} and Su_Enable=1 and Su_Clear=1", sql, SQLWhere);
            }
            else
            {
                sql += SQLWhere + " where Su_Enable=1 and Su_Clear=1";
            }
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Supplier supplier = new Supplier()
                {
                    Su_ID = Convert.ToInt32(read["Su_ID"]),
                    Su_Name = XYEEncoding.strHexDecode(read["Su_Name"].ToString()),
                    Su_Phone = XYEEncoding.strHexDecode(read["Su_Phone"].ToString()),
                    Su_Address = XYEEncoding.strHexDecode(read["Su_Address"].ToString()),
                    Su_fax = XYEEncoding.strHexDecode(read["Su_fax"].ToString()),
                    Su_Email = XYEEncoding.strHexDecode(read["Su_email"].ToString()),
                    Su_Bankaccounts = XYEEncoding.strHexDecode(read["Su_Bankaccounts"].ToString()),
                    Su_Bank = XYEEncoding.strHexDecode(read["Su_Bank"].ToString()),
                    Su_ProCode = XYEEncoding.strHexDecode(read["Su_ProCode"].ToString()),
                    Su_Credit = XYEEncoding.strHexDecode(read["Su_Credit"].ToString()),
                    Su_Money = read["Su_Money"].ToString(),
                    Su_Surplus = read["Su_Surplus"].ToString(),
                    Su_Reckoning = XYEEncoding.strHexDecode(read["Su_Reckoning"].ToString()),
                    Su_Empname = XYEEncoding.strHexDecode(read["Su_Empname"].ToString()),
                    Su_EmpPhone = XYEEncoding.strHexDecode(read["Su_EmpPhone"].ToString()),
                    Su_Remark = XYEEncoding.strHexDecode(read["Su_Remark"].ToString()),
                    Su_Enable = Convert.ToInt32(read["Su_Enable"].ToString()),
                    Su_Clear = Convert.ToInt32(read["Su_Clear"].ToString()),
                    Su_Code = XYEEncoding.strHexDecode(read["Su_Code"].ToString()),
                    Su_EnableStr = Convert.ToInt32(read["Su_Enable"].ToString()) == 1 ? "未禁用" : "已禁用"
                };
                list.Add(supplier);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <param name="isDisEC">isDisEC：true仅显示启用,false显示启用和未删除</param>
        /// <returns></returns>
        public List<Supplier> SelSupplier(bool isDisEC)
        {
            List<Supplier> list = new List<Supplier>();
            string sql = "select * from T_Supplier";
            if (isDisEC == true)
            {
                sql += " where Su_Clear=1";
            }
            else
            {
                sql += " where Su_Enable=1 and Su_Clear=1";
            }

            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Supplier supplier = new Supplier()
                {
                    Su_ID = Convert.ToInt32(read["Su_ID"]),
                    Su_Name = XYEEncoding.strHexDecode(read["Su_Name"].ToString()),
                    Su_Phone = XYEEncoding.strHexDecode(read["Su_Phone"].ToString()),
                    Su_Address = XYEEncoding.strHexDecode(read["Su_Address"].ToString()),
                    Su_fax = XYEEncoding.strHexDecode(read["Su_fax"].ToString()),
                    Su_Email = XYEEncoding.strHexDecode(read["Su_email"].ToString()),
                    Su_Bankaccounts = XYEEncoding.strHexDecode(read["Su_Bankaccounts"].ToString()),
                    Su_Bank = XYEEncoding.strHexDecode(read["Su_Bank"].ToString()),
                    Su_ProCode = XYEEncoding.strHexDecode(read["Su_ProCode"].ToString()),
                    Su_Credit = XYEEncoding.strHexDecode(read["Su_Credit"].ToString()),
                    Su_Money = read["Su_Money"].ToString(),
                    Su_Surplus = read["Su_Surplus"].ToString(),
                    Su_Reckoning = XYEEncoding.strHexDecode(read["Su_Reckoning"].ToString()),
                    Su_Empname = XYEEncoding.strHexDecode(read["Su_Empname"].ToString()),
                    Su_EmpPhone = XYEEncoding.strHexDecode(read["Su_EmpPhone"].ToString()),
                    Su_Remark = XYEEncoding.strHexDecode(read["Su_Remark"].ToString()),
                    Su_Enable = Convert.ToInt32(read["Su_Enable"].ToString()),
                    Su_Clear = Convert.ToInt32(read["Su_Clear"].ToString()),
                    Su_Code = XYEEncoding.strHexDecode(read["Su_Code"].ToString()),
                    Su_Area = XYEEncoding.strHexDecode(read["Su_Area"].ToString()),
                    Su_EnableStr = Convert.ToInt32(read["Su_Enable"].ToString()) == 1 ? "未禁用" : "已禁用"
                };
                list.Add(supplier);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelSupplierTable()
        {
            string sql = @"select 
Su_Code as 编码,
Su_Name as 单位名称,
Su_Address as 通讯地址,
Su_EmpName as 联系人,
Su_EmpPhone as 联系手机,
Su_fax as 传真,
Su_Email as 邮箱,
Su_Credit as 信用等级,
Su_Money as 账款额度,
Su_Surplus as 剩余额度,
Su_Reckoning as 月结日,
Su_Area as 城市,
Su_Remark as 备注,
(case 
when Su_Enable=1 then '2A50591F3727' 
else '3635591F3727' end)
as 是否禁用
from T_Supplier where Su_Clear=1 and Su_Enable=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Supplier");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        #endregion

        /// <summary>
        /// 查询部分供应商信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelSupplierTable2()
        {
            string sql = @" select Su_Code as 编码, Su_Name as 供应商名称 , b.Buy_AmountPay as 应付金额, b.Buy_BCode 采购单单号,b.Buy_AccountName as 付款账户  from T_Supplier s,T_BuyPayment b where Su_Clear=1 and Su_Enable=1 and s.Su_Code=b.Buy_SuCode";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Supplier");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
    }
}
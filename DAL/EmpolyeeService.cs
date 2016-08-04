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
    public class EmpolyeeService
    {
        DepartmentService department = new DepartmentService();
        #region 添加人员信息
        /// <summary>
        /// 添加人员信息
        /// </summary>
        /// <param name="empolyee">参数实体类</param>
        /// <returns></returns>
        public int InsEmpolyee(Empolyee empolyee)
        {
            string sql = @"INSERT INTO T_Empolyee
           (Emp_Code
           ,Emp_Name
           ,Emp_Password
           ,Emp_UserRole
           ,Emp_Area
           ,Emp_zhiwen
           ,Emp_CardCode
           ,Emp_Depid
           ,Emp_Sex
           ,Emp_Card
           ,Emp_State
           ,Emp_Phone
           ,Emp_Bank
           ,Emp_OpenBank
           ,Emp_Birthday
           ,Emp_Email
           ,Emp_Education
           ,Emp_School
           ,Emp_Entry
           ,Emp_Enable
           ,Emp_Clear
           )
     VALUES
           (@Emp_Code
           ,@Emp_Name
           ,@Emp_Password
           ,@Emp_UserRole
           ,@Emp_Area
           ,@Emp_zhiwen
           ,@Emp_CardCode
           ,@Emp_Depid
           ,@Emp_Sex
           ,@Emp_Card
           ,@Emp_State
           ,@Emp_Phone
           ,@Emp_Bank
           ,@Emp_OpenBank
           ,@Emp_Birthday
           ,@Emp_Email
           ,@Emp_Education
           ,@Emp_School
           ,@Emp_Entry
           ,@Emp_Enable
           ,@Emp_Clear
           )";
            SqlParameter[] sps =
            {
                new SqlParameter("@Emp_Code",XYEEncoding.strCodeHex(empolyee.Emp_Code)),
                new SqlParameter("@Emp_Name",XYEEncoding.strCodeHex(empolyee.Emp_Name)),
                new SqlParameter("@Emp_Password",XYEEncoding.strCodeHex(empolyee.Emp_Password)),
                new SqlParameter("@Emp_UserRole",XYEEncoding.strCodeHex(empolyee.Emp_UserRole)),
                new SqlParameter("@Emp_Area",XYEEncoding.strCodeHex(empolyee.Emp_Area)),
                new SqlParameter("@Emp_zhiwen",empolyee.Emp_zhiwen),
                new SqlParameter("@Emp_CardCode",XYEEncoding.strCodeHex(empolyee.Emp_CardCode)),
                new SqlParameter("@Emp_Depid",XYEEncoding.strCodeHex(empolyee.Emp_Depid)),
                new SqlParameter("@Emp_Sex",XYEEncoding.strCodeHex(empolyee.Emp_Sex)),
                new SqlParameter("@Emp_Card",XYEEncoding.strCodeHex(empolyee.Emp_Card)),
                new SqlParameter("@Emp_State",empolyee.Emp_State),
                new SqlParameter("@Emp_Phone",XYEEncoding.strCodeHex(empolyee.Emp_Phone)),
                new SqlParameter("@Emp_Bank",XYEEncoding.strCodeHex(empolyee.Emp_Bank)),
                new SqlParameter("@Emp_OpenBank",XYEEncoding.strCodeHex(empolyee.Emp_OpenBank)),
                new SqlParameter("@Emp_Birthday",empolyee.Emp_Birthday),
                new SqlParameter("@Emp_Email",XYEEncoding.strCodeHex(empolyee.Emp_Email)),
                new SqlParameter("@Emp_Education",XYEEncoding.strCodeHex(empolyee.Emp_Education)),
                new SqlParameter("@Emp_School",XYEEncoding.strCodeHex(empolyee.Emp_School)),
                new SqlParameter("@Emp_Entry",empolyee.Emp_Entry),
                new SqlParameter("@Emp_Enable",empolyee.Emp_Enable),
                new SqlParameter("@Emp_Clear",empolyee.Emp_Clear)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
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
            string sql = string.Format("update T_Empolyee set Emp_Clear=0 where Emp_Clear=1 and Emp_Code='{0}'", code);
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
            string sql = string.Format("update T_Empolyee set Emp_Clear=0 where Emp_Clear=1");
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据工号修改信息
        /// <summary>
        /// 根据工号修改信息
        /// </summary>
        /// <param name="empolyee"></param>
        /// <returns></returns>
        public int UpdateEmpolyee(Empolyee empolyee)
        {
            string sql = @"update T_Empolyee set 
             Emp_Name=@Emp_Name
            ,Emp_Password=@Emp_Password
            ,Emp_UserRole=@Emp_UserRole
            ,Emp_Area=@Emp_Area
            ,Emp_zhiwen=@Emp_zhiwen
            ,Emp_CardCode=@Emp_CardCode
            ,Emp_Depid=@Emp_Depid
            ,Emp_Sex=@Emp_Sex
            ,Emp_Card=@Emp_Card
            ,Emp_State=@Emp_State
            ,Emp_Phone=@Emp_Phone
            ,Emp_Bank=@Emp_Bank
            ,Emp_OpenBank=@Emp_OpenBank
            ,Emp_Birthday=@Emp_Birthday
            ,Emp_Email=@Emp_Email
            ,Emp_Education=@Emp_Education
            ,Emp_School=@Emp_School
            ,Emp_Entry=@Emp_Entry
            ,Emp_Enable=@Emp_Enable
            ,Emp_Clear=@Emp_Clear
             where Emp_Code=@Emp_Code";
            SqlParameter[] sps =
            {
                new SqlParameter("@Emp_Code",XYEEncoding.strCodeHex(empolyee.Emp_Code)),
                new SqlParameter("@Emp_Name",XYEEncoding.strCodeHex(empolyee.Emp_Name)),
                new SqlParameter("@Emp_Password",XYEEncoding.strCodeHex(empolyee.Emp_Password)),
                new SqlParameter("@Emp_UserRole",XYEEncoding.strCodeHex(empolyee.Emp_UserRole)),
                new SqlParameter("@Emp_Area",XYEEncoding.strCodeHex(empolyee.Emp_Area)),
                new SqlParameter("@Emp_zhiwen",empolyee.Emp_zhiwen),
                new SqlParameter("@Emp_CardCode",XYEEncoding.strCodeHex(empolyee.Emp_CardCode)),
                new SqlParameter("@Emp_Depid",XYEEncoding.strCodeHex(empolyee.Emp_Depid)),
                new SqlParameter("@Emp_Sex",XYEEncoding.strCodeHex(empolyee.Emp_Sex)),
                new SqlParameter("@Emp_Card",XYEEncoding.strCodeHex(empolyee.Emp_Card)),
                new SqlParameter("@Emp_State",empolyee.Emp_State),
                new SqlParameter("@Emp_Phone",XYEEncoding.strCodeHex(empolyee.Emp_Phone)),
                new SqlParameter("@Emp_Bank",XYEEncoding.strCodeHex(empolyee.Emp_Bank)),
                new SqlParameter("@Emp_OpenBank",XYEEncoding.strCodeHex(empolyee.Emp_OpenBank)),
                new SqlParameter("@Emp_Birthday",empolyee.Emp_Birthday),
                new SqlParameter("@Emp_Email",XYEEncoding.strCodeHex(empolyee.Emp_Email)),
                new SqlParameter("@Emp_Education",XYEEncoding.strCodeHex(empolyee.Emp_Education)),
                new SqlParameter("@Emp_School",XYEEncoding.strCodeHex(empolyee.Emp_School)),
                new SqlParameter("@Emp_Entry",empolyee.Emp_Entry),
                new SqlParameter("@Emp_Enable",empolyee.Emp_Enable),
                new SqlParameter("@Emp_Clear",empolyee.Emp_Clear),

            };
            return DbHelperSQL.ExecuteSql(sql, sps);
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
            string sql = string.Format("select * from T_Empolyee where Emp_Code='{0}' and Emp_Clear=1", Emp_Code);
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Empolyee emp = new Empolyee();
                emp.Emp_ID = Convert.ToInt32(read["Emp_ID"]);
                emp.Emp_Name = XYEEncoding.strHexDecode(read["Emp_Name"].ToString());
                emp.Emp_Code = XYEEncoding.strHexDecode(read["Emp_Code"].ToString());
                emp.Emp_Card = XYEEncoding.strHexDecode(read["Emp_Card"].ToString());
                emp.Emp_Area = XYEEncoding.strHexDecode(read["Emp_Area"].ToString());
                emp.Emp_Bank = XYEEncoding.strHexDecode(read["Emp_Bank"].ToString());
                emp.Emp_Birthday = Convert.ToDateTime(read["Emp_Birthday"]);
                emp.Emp_CardCode = XYEEncoding.strHexDecode(read["Emp_CardCode"].ToString());
                emp.Emp_Clear = Convert.ToInt32(read["Emp_Clear"]);
                emp.Emp_Depid = XYEEncoding.strHexDecode(read["Emp_Depid"].ToString());
                emp.Emp_Education = XYEEncoding.strHexDecode(read["Emp_Education"].ToString());
                emp.Emp_Email = XYEEncoding.strHexDecode(read["Emp_Email"].ToString());
                emp.Emp_Enable = Convert.ToInt32(read["Emp_Enable"]);
                emp.Emp_Entry = Convert.ToDateTime(read["Emp_Entry"]);
                emp.Emp_OpenBank = XYEEncoding.strHexDecode(read["Emp_OpenBank"].ToString());
                emp.Emp_Password = XYEEncoding.strHexDecode(read["Emp_Password"].ToString());
                emp.Emp_Phone = XYEEncoding.strHexDecode(read["Emp_Phone"].ToString());
                emp.Emp_School = XYEEncoding.strHexDecode(read["Emp_School"].ToString());
                emp.Emp_Sex = XYEEncoding.strHexDecode(read["Emp_Sex"].ToString());
                emp.Emp_State = Convert.ToInt32(read["Emp_State"]);
                emp.Emp_UserRole = XYEEncoding.strHexDecode(read["Emp_UserRole"].ToString());
                emp.Emp_zhiwen = XYEEncoding.strHexDecode(read["Emp_zhiwen"].ToString());
                return emp;
            }
            return null;
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
            CodingHelper ch = new CodingHelper();
            string sql = @"select Emp_Code as 员工工号,
            Emp_Name as 姓名,
            r.Role_Name as 角色,
            Emp_Area as 地址,
            Emp_CardCode as 卡号,
            dep.Dt_Name as 所属部门,
            Emp_Sex as 性别,
            Emp_Card as 身份证号,
            Emp_Phone as 联系电话,
            Emp_Bank as 银行卡号,
            Emp_OpenBank as 开户行,
            Emp_Birthday 出生年月,
            Emp_Email as 邮箱,
            Emp_Education as 最高学历,
            Emp_School as 毕业院校,
            Emp_Entry as 入职时间,
            Emp_State as 就职状态,
            Emp_Enable as 禁用状态  
            from T_Empolyee emp,
            T_Role r,
            T_Department dep 
            where Emp_Clear=1 
            and emp.Emp_Depid=dep.Dt_Code 
            and emp.Emp_UserRole=r.Role_Code";
            if (isflag == false)
            {
                sql += " and Emp_Enable=1";
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "T_Empolyee");
            return ch.DataTableReCoding(ds.Tables[0]);
        }
        #endregion

        public List<Empolyee> SelEmpList()
        {
            List<Empolyee> list = new List<Empolyee>();
            string sql = @"select Emp_Code,
            Emp_Name,
            r.Role_Name,
            Emp_Area,
            Emp_CardCode,
            dep.Dt_Name,
            Emp_Sex,
            Emp_Card,
            Emp_Phone,
            Emp_Bank,
            Emp_OpenBank,
            Emp_Birthday,
            Emp_Email,
            Emp_Education,
            Emp_School,
            Emp_Entry,
            Emp_State,
            Emp_Enable  
            from T_Empolyee emp,
            T_Role r,
            T_Department dep 
            where Emp_Clear=1 
            and emp.Emp_Depid=dep.Dt_Code 
            and emp.Emp_UserRole=r.Role_Code";
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Empolyee emp = new Empolyee()
                {
                    Emp_CardCode = XYEEncoding.strHexDecode(read["Emp_CardCode"].ToString()),
                    Emp_Area = XYEEncoding.strHexDecode(read["Emp_Area"].ToString()),
                    Emp_Code = XYEEncoding.strHexDecode(read["Emp_Code"].ToString()),
                    Emp_Sex = XYEEncoding.strHexDecode(read["Emp_Sex"].ToString()),
                    Emp_Card = XYEEncoding.strHexDecode(read["Emp_Card"].ToString()),
                    Emp_Phone = XYEEncoding.strHexDecode(read["Emp_Phone"].ToString()),
                    Emp_Bank = XYEEncoding.strHexDecode(read["Emp_Bank"].ToString()),
                    Emp_OpenBank = XYEEncoding.strHexDecode(read["Emp_OpenBank"].ToString()),
                    Emp_Birthday = Convert.ToDateTime(read["Emp_Birthday"].ToString()),
                    Emp_Email = XYEEncoding.strHexDecode(read["Emp_Email"].ToString()),
                    Emp_Education = XYEEncoding.strHexDecode(read["Emp_Education"].ToString()),
                    Emp_School = XYEEncoding.strHexDecode(read["Emp_School"].ToString()),
                    Emp_Entry = Convert.ToDateTime(read["Emp_Entry"].ToString()),
                    Emp_State = Convert.ToInt32(read["Emp_State"].ToString()),
                    Emp_Enable = Convert.ToInt32(read["Emp_Enable"].ToString()),
                    Roles = new RoleService().GetModel(read["Emp_UserRole"] == null ? "" : read["Emp_UserRole"].ToString()),
                    Departments = new DepartmentService().SelDepartmentByCode(read["Emp_Depid"] == null ? "" : read["Emp_Depid"].ToString())
                };
                list.Add(emp);
            }
            return list;
        }

        /// <summary>
        /// 是否存在该用户记录
        /// </summary>
        public bool ExistsUser(string Emp_Name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Empolyee");
            strSql.Append(" where Emp_Name=@Emp_Name");
            SqlParameter[] parameters = {
                    new SqlParameter("@Emp_Name", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Emp_Name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否登录成功
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable GetUserAndRoleModel(string name, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select top(1) Emp_UserRole,Emp_Name,Emp_Password from T_Empolyee ");
            strSql.Append(" where Emp_Name=@Emp_Name and Emp_Password=@Emp_Password ");
            SqlParameter[] parameters = {
                    new SqlParameter("@User_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@User_Password", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = name;
            parameters[1].Value = password;

            Empolyee model = new Empolyee();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 查询员工信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet SelEmp2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Emp_Code as 员工工号,Emp_Name as 姓名  from T_Empolyee   ");
            strSql.Append(" where Emp_Clear=1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
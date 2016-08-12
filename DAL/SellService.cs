using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;

namespace DAL
{
    public class SellService
    {
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Sell_ID", "T_Sell");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Sell_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Sell");
            strSql.Append(" where Sell_ID=@Sell_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Sell model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Sell(");
            strSql.Append("Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,");
            strSql.Append("Sell_IsPay,Sell_IsPutSto,Sell_PayMathod,Sell_GetDate,Sell_Logistics,Sell_LogCode,Sell_LogPhone,Sell_Clear,Sell_OddMoney,Sell_AccountCode,Sell_InMoney,Sell_LastMoney,");
            strSql.Append("Sell_Address,Sell_ClientName,Sell_CliPhone,Sell_LinkMan,Sell_Salesman,Sell_OddStatus,Sell_jiajiState,Sell_zuiwanshijian,Sell_fukuanfangshi)");
            strSql.Append(" values (");
            strSql.Append("@Sell_Code,@Sell_Type,@Sell_Date,@Sell_TransportType,@Sell_Review,@Sell_ChangeDate,@Sell_Operation,@Sell_Auditman,@Sell_Remark,@Sell_Satetyone,@Sell_Satetytwo,");
            strSql.Append("@Sell_IsPay,@Sell_IsPutSto,@Sell_PayMathod,@Sell_GetDate,@Sell_Logistics,@Sell_LogCode,@Sell_LogPhone,@Sell_Clear,@Sell_OddMoney,@Sell_AccountCode,@Sell_InMoney,@Sell_LastMoney,");
            strSql.Append("@Sell_Address,@Sell_ClientName,@Sell_CliPhone,@Sell_LinkMan,@Sell_Salesman,@Sell_OddStatus,Sell_jiajiState,Sell_zuiwanshijian,Sell_fukuanfangshi)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Date", SqlDbType.DateTime),
                    new SqlParameter("@Sell_TransportType", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Review", SqlDbType.Int,4),
                    new SqlParameter("@Sell_ChangeDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Operation", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Auditman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_IsPay", SqlDbType.Int,4),
                    new SqlParameter("@Sell_IsPutSto", SqlDbType.Int,4),
                    new SqlParameter("@Sell_PayMathod", SqlDbType.Int,4),
                    new SqlParameter("@Sell_GetDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Logistics", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LogCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LogPhone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Sell_OddMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_AccountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_InMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LastMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_ClientName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_CliPhone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Salesman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_OddStatus", SqlDbType.Int,4),
                    new SqlParameter("@Sell_jiajiState", SqlDbType.Int,4),
                    new SqlParameter("@Sell_zuiwanshijian", SqlDbType.DateTime),
                    new SqlParameter("@Sell_fukuanfangshi", SqlDbType.NVarChar,512) };
            parameters[0].Value = model.Sell_Code;
            parameters[1].Value = model.Sell_Type;
            parameters[2].Value = model.Sell_Date;
            parameters[3].Value = model.Sell_TransportType;
            parameters[4].Value = model.Sell_Review;
            parameters[5].Value = model.Sell_ChangeDate;
            parameters[6].Value = model.Sell_Operation;
            parameters[7].Value = model.Sell_Auditman;
            parameters[8].Value = model.Sell_Remark;
            parameters[9].Value = model.Sell_Satetyone;
            parameters[10].Value = model.Sell_Satetytwo;
            parameters[11].Value = model.Sell_IsPay;
            parameters[12].Value = model.Sell_IsPutSto;
            parameters[13].Value = model.Sell_PayMathod;
            parameters[14].Value = model.Sell_GetDate;
            parameters[15].Value = model.Sell_Logistics;
            parameters[16].Value = model.Sell_LogCode;
            parameters[17].Value = model.Sell_LogPhone;
            parameters[18].Value = model.Sell_Clear;
            parameters[19].Value = model.Sell_OddMoney;
            parameters[20].Value = model.Sell_AccountCode;
            parameters[21].Value = model.Sell_InMoney;
            parameters[22].Value = model.Sell_LastMoney;
            parameters[23].Value = model.Sell_Address;
            parameters[24].Value = model.Sell_ClientName;
            parameters[25].Value = model.Sell_CliPhone;
            parameters[26].Value = model.Sell_LinkMan;
            parameters[27].Value = model.Sell_Salesman;
            parameters[28].Value = model.Sell_OddStatus;
            parameters[29].Value = model.Sell_jiajiState;
            parameters[30].Value = model.Sell_zuiwanshijian;
            parameters[31].Value = model.Sell_fukuanfangshi;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Sell model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Sell set ");
            strSql.Append("Sell_Type=@Sell_Type,");
            strSql.Append("Sell_Date=@Sell_Date,");
            strSql.Append("Sell_TransportType=@Sell_TransportType,");
            strSql.Append("Sell_Review=@Sell_Review,");
            strSql.Append("Sell_ChangeDate=@Sell_ChangeDate,");
            strSql.Append("Sell_Operation=@Sell_Operation,");
            strSql.Append("Sell_Auditman=@Sell_Auditman,");
            strSql.Append("Sell_Remark=@Sell_Remark,");
            strSql.Append("Sell_Satetyone=@Sell_Satetyone,");
            strSql.Append("Sell_Satetytwo=@Sell_Satetytwo,");
            strSql.Append("Sell_IsPay=@Sell_IsPay,");
            strSql.Append("Sell_IsPutSto=@Sell_IsPutSto,");
            strSql.Append("Sell_PayMathod=@Sell_PayMathod,");
            strSql.Append("Sell_GetDate=@Sell_GetDate,");
            strSql.Append("Sell_Logistics=@Sell_Logistics,");
            strSql.Append("Sell_LogCode=@Sell_LogCode,");
            strSql.Append("Sell_LogPhone=@Sell_LogPhone,");
            strSql.Append("Sell_Clear=@Sell_Clear,");
            strSql.Append("Sell_OddMoney=@Sell_OddMoney,");
            strSql.Append("Sell_AccountCode=@Sell_AccountCode,");
            strSql.Append("Sell_InMoney=@Sell_InMoney,");
            strSql.Append("Sell_LastMoney=@Sell_LastMoney,");
            strSql.Append("Sell_Address=@Sell_Address");
            strSql.Append("Sell_ClientName=@Sell_ClientName");
            strSql.Append("Sell_CliPhone=@Sell_CliPhone");
            strSql.Append("Sell_LinkMan=@Sell_LinkMan");
            strSql.Append("Sell_Salesman=@Sell_Salesman");
            strSql.Append("Sell_OddStatus=@Sell_OddStatus");
            strSql.Append("Sell_jiajiState=@Sell_jiajiState");
            strSql.Append("Sell_zuiwanshijian=@Sell_zuiwanshijian");
            strSql.Append("Sell_fukuanfangshi=@Sell_fukuanfangshi");
            strSql.Append(" where Sell_Code=@Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Date", SqlDbType.DateTime),
                    new SqlParameter("@Sell_TransportType", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Review", SqlDbType.Int,4),
                    new SqlParameter("@Sell_ChangeDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Operation", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Auditman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_IsPay", SqlDbType.Int,4),
                    new SqlParameter("@Sell_IsPutSto", SqlDbType.Int,4),
                    new SqlParameter("@Sell_PayMathod", SqlDbType.Int,4),
                    new SqlParameter("@Sell_GetDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Logistics", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LogCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LogPhone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Sell_OddMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_AccountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_InMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LastMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_ClientName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_CliPhone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Salesman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_OddStatus", SqlDbType.Int,4),
                    new SqlParameter("@Sell_jiajiState", SqlDbType.Int,4),
                    new SqlParameter("@Sell_zuiwanshijian", SqlDbType.DateTime),
                    new SqlParameter("@Sell_fukuanfangshi", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.Sell_Type;
            parameters[1].Value = model.Sell_Date;
            parameters[2].Value = model.Sell_TransportType;
            parameters[3].Value = model.Sell_Review;
            parameters[4].Value = model.Sell_ChangeDate;
            parameters[5].Value = model.Sell_Operation;
            parameters[6].Value = model.Sell_Auditman;
            parameters[7].Value = model.Sell_Remark;
            parameters[8].Value = model.Sell_Satetyone;
            parameters[9].Value = model.Sell_Satetytwo;
            parameters[10].Value = model.Sell_IsPay;
            parameters[11].Value = model.Sell_IsPutSto;
            parameters[12].Value = model.Sell_PayMathod;
            parameters[13].Value = model.Sell_GetDate;
            parameters[14].Value = model.Sell_Logistics;
            parameters[15].Value = model.Sell_LogCode;
            parameters[16].Value = model.Sell_LogPhone;
            parameters[17].Value = model.Sell_Clear;
            parameters[18].Value = model.Sell_OddMoney;
            parameters[19].Value = model.Sell_AccountCode;
            parameters[20].Value = model.Sell_InMoney;
            parameters[21].Value = model.Sell_LastMoney;
            parameters[22].Value = model.Sell_Address;
            parameters[19].Value = model.Sell_ClientName;
            parameters[20].Value = model.Sell_CliPhone;
            parameters[21].Value = model.Sell_LinkMan;
            parameters[22].Value = model.Sell_Salesman;
            parameters[23].Value = model.Sell_OddStatus;
            parameters[24].Value = model.Sell_jiajiState;
            parameters[25].Value = model.Sell_zuiwanshijian;
            parameters[26].Value = model.Sell_fukuanfangshi;
            parameters[27].Value = model.Sell_Code;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Sell_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Sell ");
            strSql.Append(" where Sell_ID=@Sell_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据如果
        /// </summary>
        public bool DeleteList(string Sell_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Sell ");
            strSql.Append(" where Sell_ID in (" + Sell_IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Sell GetModel(string Sell_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,");
            strSql.Append("Sell_IsPay,Sell_IsPutSto,Sell_PayMathod,Sell_GetDate,Sell_Logistics,Sell_LogCode,Sell_LogPhone,Sell_OddMoney,Sell_AccountCode,Sell_InMoney,Sell_LastMoney,Sell_Address");
            strSql.Append("Sell_ClientName,Sell_CliPhone,Sell_LinkMan,Sell_Salesman,Sell_OddStatus,Sell_jiajiState,Sell_zuiwanshijian,Sell_fukuanfangshi from T_Sell");
            strSql.Append(" where Sell_Code=@Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Sell_Code;

            Sell model = new Sell();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Sell DataRowToModel(DataRow row)
        {
            Sell model = new Sell();
            if (row != null)
            {
                if (row["Sell_ID"] != null && row["Sell_ID"].ToString() != "")
                {
                    model.Sell_ID = int.Parse(row["Sell_ID"].ToString());
                }
                if (row["Sell_Code"] != null)
                {
                    model.Sell_Code = row["Sell_Code"].ToString();
                }
                if (row["Sell_Type"] != null)
                {
                    model.Sell_Type = row["Sell_Type"].ToString();
                }
                if (row["Sell_Date"] != null && row["Sell_Date"].ToString() != "")
                {
                    model.Sell_Date = DateTime.Parse(row["Sell_Date"].ToString());
                }
                if (row["Sell_TransportType"] != null)
                {
                    model.Sell_TransportType = row["Sell_TransportType"].ToString();
                }
                if (row["Sell_Review"] != null && row["Sell_Review"].ToString() != "")
                {
                    model.Sell_Review = int.Parse(row["Sell_Review"].ToString());
                }
                if (row["Sell_ChangeDate"] != null && row["Sell_ChangeDate"].ToString() != "")
                {
                    model.Sell_ChangeDate = DateTime.Parse(row["Sell_ChangeDate"].ToString());
                }
                if (row["Sell_Operation"] != null)
                {
                    model.Sell_Operation = row["Sell_Operation"].ToString();
                }
                if (row["Sell_Auditman"] != null)
                {
                    model.Sell_Auditman = row["Sell_Auditman"].ToString();
                }
                if (row["Sell_Remark"] != null)
                {
                    model.Sell_Remark = row["Sell_Remark"].ToString();
                }
                if (row["Sell_Satetyone"] != null)
                {
                    model.Sell_Satetyone = row["Sell_Satetyone"].ToString();
                }
                if (row["Sell_Satetytwo"] != null)
                {
                    model.Sell_Satetytwo = row["Sell_Satetytwo"].ToString();
                }
                if (row["Sell_IsPay"] != null && row["Sell_IsPay"].ToString() != "")
                {
                    model.Sell_IsPay = int.Parse(row["Sell_IsPay"].ToString());
                }
                if (row["Sell_IsPutSto"] != null && row["Sell_IsPutSto"].ToString() != "")
                {
                    model.Sell_IsPutSto = int.Parse(row["Sell_IsPutSto"].ToString());
                }
                if (row["Sell_PayMathod"] != null && row["Sell_PayMathod"].ToString() != "")
                {
                    model.Sell_PayMathod = int.Parse(row["Sell_PayMathod"].ToString());
                }
                if (row["Sell_GetDate"] != null && row["Sell_GetDate"].ToString() != "")
                {
                    model.Sell_GetDate = DateTime.Parse(row["Sell_GetDate"].ToString());
                }
                if (row["Sell_Logistics"] != null)
                {
                    model.Sell_Logistics = row["Sell_Logistics"].ToString();
                }
                if (row["Sell_LogCode"] != null)
                {
                    model.Sell_LogCode = row["Sell_LogCode"].ToString();
                }
                if (row["Sell_LogPhone"] != null)
                {
                    model.Sell_LogPhone = row["Sell_LogPhone"].ToString();
                }
                if (row["Sell_Clear"] != null && row["Sell_Clear"].ToString() != "")
                {
                    model.Sell_Clear = int.Parse(row["Sell_Clear"].ToString());
                }
                if (row["Sell_OddMoney"] != null)
                {
                    model.Sell_OddMoney = row["Sell_OddMoney"].ToString();
                }
                if (row["Sell_AccountCode"] != null)
                {
                    model.Sell_AccountCode = row["Sell_AccountCode"].ToString();
                }
                if (row["Sell_InMoney"] != null)
                {
                    model.Sell_InMoney = row["Sell_InMoney"].ToString();
                }
                if (row["Sell_LastMoney"] != null)
                {
                    model.Sell_LastMoney = row["Sell_LastMoney"].ToString();
                }
                if (row["Sell_Address"] != null)
                {
                    model.Sell_Address = row["Sell_Address"].ToString();
                }
                if (row["Sell_ClientName"] != null)
                {
                    model.Sell_ClientName = row["Sell_ClientName"].ToString();
                }
                if (row["Sell_CliPhone"] != null)
                {
                    model.Sell_CliPhone = row["Sell_CliPhone"].ToString();
                }
                if (row["Sell_LinkMan"] != null)
                {
                    model.Sell_LinkMan = row["Sell_LinkMan"].ToString();
                }
                if (row["Sell_Salesman"] != null)
                {
                    model.Sell_Salesman = row["Sell_Salesman"].ToString();
                }
                if (row["Sell_OddStatus"] != null)
                {
                    model.Sell_OddStatus = int.Parse(row["Sell_OddStatus"].ToString());
                }
                if (row["Sell_jiajiState"] != null)
                {
                    model.Sell_jiajiState = int.Parse(row["Sell_jiajiState"].ToString());
                }
                if (row["Sell_zuiwanshijian"] != null && row["Sell_zuiwanshijian"].ToString() != "")
                {
                    model.Sell_zuiwanshijian = DateTime.Parse(row["Sell_zuiwanshijian"].ToString());
                }
                if (row["Sell_fukuanfangshi"] != null)
                {
                    model.Sell_fukuanfangshi = row["Sell_fukuanfangshi"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo, ");
            strSql.Append("Sell_IsPay,Sell_IsPutSto,Sell_PayMathod,Sell_GetDate,Sell_Logistics,Sell_LogCode,Sell_LogPhone,Sell_Clear,Sell_OddMoney,Sell_AccountCode,Sell_InMoney,Sell_LastMoney,");
            strSql.Append("Sell_Address,Sell_ClientName,Sell_CliPhone,Sell_LinkMan,Sell_Salesman,Sell_OddStatus,Sell_jiajiState,Sell_zuiwanshijian,Sell_fukuanfangshi FROM T_Sell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,");
            strSql.Append("Sell_IsPay,Sell_IsPutSto,Sell_PayMathod,Sell_GetDate,Sell_Logistics,Sell_LogCode,Sell_LogPhone,Sell_Clear,Sell_OddMoney,Sell_AccountCode,Sell_InMoney,Sell_LastMoney,");
            strSql.Append("Sell_Address,Sell_ClientName,Sell_CliPhone,Sell_LinkMan,Sell_Salesman,Sell_OddStatus,Sell_jiajiState,Sell_zuiwanshijian,Sell_fukuanfangshi FROM T_Sell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_Sell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Sell_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_Sell T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		// <summary>
		// 分页获取数据列表
		// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_Sell";
			parameters[1].Value = "Sell_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod

        #region  ExtensionMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Sell_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Sell");
            strSql.Append(" where Sell_Code=@Sell_Code and Sell_Clear = @Sell_Clear");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4)
            };
            parameters[0].Value = Sell_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Sell_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Sell ");
            strSql.Append(" where Sell_Code=@Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = Sell_Code;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据code做假删除
        /// </summary>
        /// <param name="Sell_Code"></param>
        /// <returns></returns>
        public bool DeleteFake(string Sell_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Sell  ");
            strSql.Append("set Sell_Clear = 0 ");
            strSql.Append("where Sell_Code = @Sell_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = Sell_Code;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public DataSet GetListSellInDetail()
        //{

        //}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        //public Sell GetModel(int Sell_ID)
        //{

        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select  top 1 Sell_ID,Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,Sell_Clear from T_Sell ");
        //    strSql.Append(" where Sell_ID=@Sell_ID");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@Sell_ID", SqlDbType.Int,4)
        //    };
        //    parameters[0].Value = Sell_ID;

        //    Sell model = new Sell();
        //    DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        return DataRowToModel(ds.Tables[0].Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public void SaveSellOdd(Sell sell, List<SellDetail> sdl, SellProcess sp, bool inStock)
        {
            StringBuilder strSql = new StringBuilder();
            Hashtable hashtable = new Hashtable();
            //销售主表操作
            strSql.Append("insert into T_Sell(");
            strSql.Append("Sell_Code,Sell_Type,Sell_Date,Sell_TransportType,Sell_Review,Sell_ChangeDate,Sell_Operation,Sell_Auditman,Sell_Remark,Sell_Satetyone,Sell_Satetytwo,");
            strSql.Append("Sell_IsPay,Sell_IsPutSto,Sell_PayMathod,Sell_GetDate,Sell_Logistics,Sell_LogCode,Sell_LogPhone,Sell_Clear,Sell_OddMoney,Sell_AccountCode,Sell_InMoney,Sell_LastMoney,Sell_Address,Sell_ClientName,Sell_CliPhone,Sell_Salesman,Sell_LinkMan,Sell_OddStatus,Sell_jiajiState,Sell_zuiwanshijian,Sell_fukuanfangshi)");
            strSql.Append(" values (");
            strSql.Append("@Sell_Code,@Sell_Type,@Sell_Date,@Sell_TransportType,@Sell_Review,@Sell_ChangeDate,@Sell_Operation,@Sell_Auditman,@Sell_Remark,@Sell_Satetyone,@Sell_Satetytwo,");
            strSql.Append("@Sell_IsPay,@Sell_IsPutSto,@Sell_PayMathod,@Sell_GetDate,@Sell_Logistics,@Sell_LogCode,@Sell_LogPhone,@Sell_Clear,@Sell_OddMoney,@Sell_AccountCode,@Sell_InMoney,@Sell_LastMoney,@Sell_Address,@Sell_ClientName,@Sell_CliPhone,@Sell_Salesman,@Sell_LinkMan,@Sell_OddStatus,@Sell_jiajiState,@Sell_zuiwanshijian,@Sell_fukuanfangshi)");

            SqlParameter[] parameters = {
                    new SqlParameter("@Sell_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Type", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Date", SqlDbType.DateTime),
                    new SqlParameter("@Sell_TransportType", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Review", SqlDbType.Int,4),
                    new SqlParameter("@Sell_ChangeDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Operation", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Auditman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetyone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Satetytwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_IsPay", SqlDbType.Int,4),
                    new SqlParameter("@Sell_IsPutSto", SqlDbType.Int,4),
                    new SqlParameter("@Sell_PayMathod", SqlDbType.Int,4),
                    new SqlParameter("@Sell_GetDate", SqlDbType.DateTime),
                    new SqlParameter("@Sell_Logistics", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LogCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LogPhone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Sell_OddMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_AccountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_InMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LastMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_ClientName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_CliPhone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_Salesman", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Sell_OddStatus", SqlDbType.Int,4),
                    new SqlParameter("@Sell_jiajiState", SqlDbType.Int,4),
                    new SqlParameter("@Sell_zuiwanshijian", SqlDbType.DateTime),
                    new SqlParameter("@Sell_fukuanfangshi", SqlDbType.NVarChar,512)};
            parameters[0].Value = sell.Sell_Code;
            parameters[1].Value = sell.Sell_Type;
            parameters[2].Value = sell.Sell_Date;
            parameters[3].Value = sell.Sell_TransportType;
            parameters[4].Value = sell.Sell_Review;
            parameters[5].Value = sell.Sell_ChangeDate;
            parameters[6].Value = sell.Sell_Operation;
            parameters[7].Value = sell.Sell_Auditman;
            parameters[8].Value = sell.Sell_Remark;
            parameters[9].Value = sell.Sell_Satetyone;
            parameters[10].Value = sell.Sell_Satetytwo;
            parameters[11].Value = sell.Sell_IsPay;
            parameters[12].Value = sell.Sell_IsPutSto;
            parameters[13].Value = sell.Sell_PayMathod;
            parameters[14].Value = sell.Sell_GetDate;
            parameters[15].Value = sell.Sell_Logistics;
            parameters[16].Value = sell.Sell_LogCode;
            parameters[17].Value = sell.Sell_LogPhone;
            parameters[18].Value = sell.Sell_Clear;
            parameters[19].Value = sell.Sell_OddMoney;
            parameters[20].Value = sell.Sell_AccountCode;
            parameters[21].Value = sell.Sell_InMoney;
            parameters[22].Value = sell.Sell_LastMoney;
            parameters[23].Value = sell.Sell_Address;
            parameters[24].Value = sell.Sell_ClientName;
            parameters[25].Value = sell.Sell_CliPhone;
            parameters[26].Value = sell.Sell_Salesman;
            parameters[27].Value = sell.Sell_LinkMan;
            parameters[28].Value = sell.Sell_OddStatus;
            parameters[29].Value = sell.Sell_jiajiState;
            parameters[30].Value = sell.Sell_zuiwanshijian;
            parameters[31].Value = sell.Sell_fukuanfangshi;

            //添加到列表中
            hashtable.Add(strSql.ToString(), parameters);
            //销售明细表操作
            foreach (var sd in sdl)
            {
                strSql = new StringBuilder();
                strSql.Append("insert into T_SellDetail(");
                strSql.Append("Sell_Code,Sell_StockCode,Sell_StockName,Sell_LineCode,Sell_MaID,Sell_MaName,Sell_Model,Sell_Unit,Sell_CurNumber,");
                strSql.Append("Sell_ReNumber,Sell_LostNumber,Sell_DiscountAPrice,Sell_Discount,Sell_DiscountBPrice,Sell_Money,Sell_Clear,Sell_Safetyone,Sell_Safetytwo,Sell_Remark)");
                strSql.Append(" values (");
                strSql.Append("@Sell_Code,@Sell_StockCode,@Sell_StockName,@Sell_LineCode,@Sell_MaID,@Sell_MaName,@Sell_Model,@Sell_Unit,@Sell_CurNumber,");
                strSql.Append("@Sell_ReNumber,@Sell_LostNumber,@Sell_DiscountAPrice,@Sell_Discount,@Sell_DiscountBPrice,@Sell_Money,@Sell_Clear,@Sell_Safetyone,@Sell_Safetytwo,@Sell_Remark)");

                SqlParameter[] parametersDetail = {
                new SqlParameter("@Sell_Code", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_StockCode", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_StockName", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_LineCode", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_MaID", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_MaName", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Model", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Unit", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_CurNumber", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_ReNumber", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_LostNumber", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_DiscountAPrice", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Discount", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_DiscountBPrice", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Money", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Clear", SqlDbType.Int, 4),
                    new SqlParameter("@Sell_Safetyone", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Safetytwo", SqlDbType.NVarChar, 512),
                    new SqlParameter("@Sell_Remark", SqlDbType.NVarChar, 1024)};
                parameters[0].Value = sd.Sell_Code;
                parameters[1].Value = sd.Sell_StockCode;
                parameters[2].Value = sd.Sell_StockName;
                parameters[3].Value = sd.Sell_LineCode;
                parameters[4].Value = sd.Sell_MaID;
                parameters[5].Value = sd.Sell_MaName;
                parameters[6].Value = sd.Sell_Model;
                parameters[7].Value = sd.Sell_Unit;
                parameters[8].Value = sd.Sell_CurNumber;
                parameters[9].Value = sd.Sell_ReNumber;
                parameters[10].Value = sd.Sell_LostNumber;
                parameters[11].Value = sd.Sell_DiscountAPrice;
                parameters[12].Value = sd.Sell_Discount;
                parameters[13].Value = sd.Sell_DiscountBPrice;
                parameters[14].Value = sd.Sell_Money;
                parameters[15].Value = sd.Sell_Clear;
                parameters[16].Value = sd.Sell_Safetyone;
                parameters[17].Value = sd.Sell_Safetytwo;
                parameters[18].Value = sd.Sell_Remark;
                //添加到列表中
                hashtable.Add(strSql.ToString(), parametersDetail);
            }
            //操作过程表操作
            strSql = new StringBuilder();
            strSql.Append("insert into T_SellProcess(");
            strSql.Append("SP_Code,SP_SellLineno,SP_Datetime,SP_Opt,SP_Ope,SP_Remark,SP_Clear )");

            strSql.Append(" values (");
            strSql.Append("@SP_Code,@SP_SellLineno,@SP_Datetime,@SP_Opt,@SP_Ope,@SP_Remark,@SP_Clear)");

            SqlParameter[] parametersProcess = {
                    new SqlParameter("@SP_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_SellLineno", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_Datetime", SqlDbType.DateTime),
                    new SqlParameter("@SP_Opt", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_Ope", SqlDbType.Int,4),
                    new SqlParameter("@SP_Remark", SqlDbType.NVarChar,512),
                    new SqlParameter("@SP_Clear", SqlDbType.NVarChar,512)};
            parameters[0].Value = sp.Sp_Code;
            parameters[1].Value = sp.Sp_SellLineno;
            parameters[2].Value = sp.Sp_Datetime;
            parameters[3].Value = sp.Sp_Opt;
            parameters[4].Value = sp.Sp_Ope;
            parameters[5].Value = sp.Sp_Remark;
            parameters[6].Value = sp.Sp_Clear;
            //添加到列表中
            hashtable.Add(strSql.ToString(), parametersProcess);

            if (inStock)
            {
                //入库单生成
            }

            DbHelperSQL.ExecuteSqlTran(hashtable);

        }

        #endregion  ExtensionMethod
    }
}

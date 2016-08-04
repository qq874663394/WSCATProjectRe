using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using HelperUtility.Encrypt;
using System.Data;

namespace DAL
{
    public partial class ProfessionService
    {
        #region 增加信息
        /// <summary>
        /// 增加信息
        /// </summary>
        /// <param name="profession">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsProfession(Profession profession)
        {
            string sql = "insert into T_Profession(ST_Code,ST_Name,ST_ParentId,ST_Enable,ST_Clear,) values(@ST_Code,@ST_Name,@ST_ParentId,@ST_Enable,@ST_Clear,)";
            SqlParameter[] sps =
            {
                new SqlParameter("@ST_Name",XYEEncoding.strCodeHex(profession.ST_Name)),
                new SqlParameter("@ST_Code",XYEEncoding.strCodeHex(profession.ST_Code)),
                new SqlParameter("@ST_ParentId",XYEEncoding.strCodeHex(profession.ST_ParentId)),
                new SqlParameter("@ST_Enable",profession.ST_Enable),
                new SqlParameter("@ST_Clear",profession.ST_Clear)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="ST_Code">编码</param>
        /// <returns></returns>
        public int FalseDelClear(string ST_Code)
        {
            string sql = string.Format("update T_Profession set ST_Clear=0 where ST_ID={0} and ST_Clear=1", ST_Code);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 禁用
        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="ST_Code">编码</param>
        /// <returns></returns>
        public int FalseDelEnable(string ST_Code)
        {
            string sql = string.Format("update T_Profession set ST_Enable=0 where ST_ID={0} and ST_Clear=1 and ST_Enable=1", ST_Code);
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据编号更新信息
        /// <summary>
        /// 根据编号更新信息
        /// </summary>
        /// <param name="profession">模型载体</param>
        /// <returns>受影响行数</returns>
        public int UpdateProfession(Profession profession)
        {
            string sql = "update T_Profession set ST_Name=@ST_Name,ST_ParentId=@ST_ParentId,ST_Enable=@ST_Enable,ST_Clear=@ST_Clear where ST_Code=@ST_Code and ST_Enable=1 and ST_Clear=1";
            SqlParameter[] sps = {
                new SqlParameter("@ST_Name",XYEEncoding.strCodeHex(profession.ST_Name)),
                new SqlParameter("@ST_ParentId",XYEEncoding.strCodeHex(profession.ST_ParentId)),
                new SqlParameter("@ST_Enable",profession.ST_Enable),
                new SqlParameter("@ST_Clear",profession.ST_Clear),
                new SqlParameter("@ST_Code",XYEEncoding.strCodeHex(profession.ST_Code))
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<Profession> SelProfessionByCode(string ST_Code)
        {
            List<Profession> list = new List<Profession>();
            string sql = string.Format("select * from T_Profession where ST_Code={0} and ST_Enable=1 and ST_Clear=1", XYEEncoding.strCodeHex(ST_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                Profession profession = new Profession()
                {
                    ST_ID = Convert.ToInt32(read["ST_ID"]),
                    ST_Name = XYEEncoding.strHexDecode(read["ST_Name"].ToString()),
                    ST_Code = XYEEncoding.strHexDecode(read["ST_Code"].ToString()),
                    ST_ParentId = XYEEncoding.strHexDecode(read["ST_ParentId"].ToString()),
                    ST_Enable = Convert.ToInt32(read["ST_Enable"]),
                    ST_Clear = Convert.ToInt32(read["ST_Clear"]),
                };
                list.Add(profession);
            }
            return list;
        }
        #endregion

        #region 根据类别名称查询编码
        /// <summary>
        /// 根据类别名称查询编码
        /// </summary>
        /// <param name="ST_Name"></param>
        /// <returns></returns>
        public string SelProfessionByName(string ST_Name)
        {
            string sql = string.Format("select ST_Code from T_Profession where ST_Name='{0}' and ST_Enable=1 and ST_Clear=1", XYEEncoding.strCodeHex(ST_Name));
            return DbHelperSQL.GetSingle(sql).ToString();
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelProfession()
        {
            string sql = "select * from T_Profession where ST_Clear=1 and ST_Enable=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_Profession");
            return ds1.Tables[0];
        }
        #endregion

        public DataSet GetList(string strWhere)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("select ST_ID,ST_Code,ST_Name,ST_ParentId,ST_Enable,ST_Clear ");
            strsql.Append(" from T_Profession ");
            if (strWhere != "")
            {
                strsql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strsql.ToString());
        }
    }
}

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
    public class CityService
    {
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("City_ID", "T_City");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int City_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_City");
            strSql.Append(" where City_ID=@City_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = City_ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(City model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_City(");
            strSql.Append("City_Name,City_ParentId,City_Enable,City_Clear,City_Code)");
            strSql.Append(" values (");
            strSql.Append("@City_Name,@City_ParentId,@City_Enable,@City_Clear,@City_Code)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_ParentId", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_Enable", SqlDbType.Int,4),
                    new SqlParameter("@City_Clear", SqlDbType.Int,4),
                    new SqlParameter("@City_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.City_Name;
            parameters[1].Value = model.City_ParentId;
            parameters[2].Value = model.City_Enable;
            parameters[3].Value = model.City_Clear;
            parameters[4].Value = model.City_Code;

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
        public bool Update(City model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_City set ");
            strSql.Append("City_Name=@City_Name,");
            strSql.Append("City_ParentId=@City_ParentId,");
            strSql.Append("City_Enable=@City_Enable,");
            strSql.Append("City_Clear=@City_Clear,");
            strSql.Append("City_Code=@City_Code");
            strSql.Append(" where City_ID=@City_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_ParentId", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_Enable", SqlDbType.Int,4),
                    new SqlParameter("@City_Clear", SqlDbType.Int,4),
                    new SqlParameter("@City_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_ID", SqlDbType.Int,4)};
            parameters[0].Value = model.City_Name;
            parameters[1].Value = model.City_ParentId;
            parameters[2].Value = model.City_Enable;
            parameters[3].Value = model.City_Clear;
            parameters[4].Value = model.City_Code;
            parameters[5].Value = model.City_ID;

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
        public bool Delete(int City_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_City ");
            strSql.Append(" where City_ID=@City_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = City_ID;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string City_IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_City ");
            strSql.Append(" where City_ID in (" + City_IDlist + ")  ");
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
        public City GetModel(int City_ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 City_ID,City_Name,City_ParentId,City_Enable,City_Clear,City_Code from T_City ");
            strSql.Append(" where City_ID=@City_ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_ID", SqlDbType.Int,4)
            };
            parameters[0].Value = City_ID;

            City model = new City();
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
        public City DataRowToModel(DataRow row)
        {
            City model = new City();
            if (row != null)
            {
                if (row["City_ID"] != null && row["City_ID"].ToString() != "")
                {
                    model.City_ID = int.Parse(row["City_ID"].ToString());
                }
                if (row["City_Name"] != null)
                {
                    model.City_Name = row["City_Name"].ToString();
                }
                if (row["City_ParentId"] != null)
                {
                    model.City_ParentId = row["City_ParentId"].ToString();
                }
                if (row["City_Enable"] != null && row["City_Enable"].ToString() != "")
                {
                    model.City_Enable = int.Parse(row["City_ParentId"].ToString());
                }
                if (row["City_Clear"] != null && row["City_Clear"].ToString() != "")
                {
                    model.City_Clear = int.Parse(row["City_ParentId"].ToString());
                }
                if (row["City_Code"] != null)
                {
                    model.City_Code = row["City_Code"].ToString();
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
            strSql.Append("select City_ID,City_Name,City_ParentId,City_Enable,City_Clear,City_Code ");
            strSql.Append(" FROM T_City ");
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
            strSql.Append(" City_ID,City_Name,City_ParentId,City_Enable,City_Clear,City_Code ");
            strSql.Append(" FROM T_City ");
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
            strSql.Append("select count(1) FROM T_City ");
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
                strSql.Append("order by T.City_ID desc");
            }
            strSql.Append(")AS Row, T.*  from T_City T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		// 分页获取数据列表
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
			parameters[0].Value = "T_City";
			parameters[1].Value = "City_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod

        #region ExtensionMethod

        /// <summary>
        /// 根据code更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateByCode(City model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_City set ");
            strSql.Append("City_Name=@City_Name,");
            strSql.Append("City_ParentId=@City_ParentId,");
            strSql.Append("City_Enable=@City_Enable,");
            strSql.Append("City_Clear=@City_Clear");
            strSql.Append(" where City_Code=@City_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_ParentId", SqlDbType.NVarChar,512),
                    new SqlParameter("@City_Enable", SqlDbType.Int,4),
                    new SqlParameter("@City_Clear", SqlDbType.Int,4),
                    new SqlParameter("@City_Code", SqlDbType.NVarChar,512)};
            parameters[0].Value = model.City_Name;
            parameters[1].Value = model.City_ParentId;
            parameters[2].Value = model.City_Enable;
            parameters[3].Value = model.City_Clear;
            parameters[4].Value = model.City_Code;

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
        /// 根据code删除一条数据
        /// </summary>
        public bool DeleteByCode(string City_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_City set City_Clear=0");
            strSql.Append(" where City_Code=@City_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@City_Code", SqlDbType.NVarChar,512)
            };
            parameters[0].Value = City_Code;

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
        #endregion

        #region 新增信息
        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="city">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsCity(City city)
        {
            string sql = @"INSERT INTO T_City VALUES
                           (@City_Code
                           ,@City_Name
                           ,@City_ParentId
                           ,@City_Enable
                           ,@City_Clear)";
            SqlParameter[] sps =
            {
                new SqlParameter("@City_Code",XYEEncoding.strCodeHex(city.City_Code)),
                new SqlParameter("@City_Name",XYEEncoding.strCodeHex(city.City_Name)),
                new SqlParameter("@City_ParentId",XYEEncoding.strCodeHex(city.City_ParentId)),
                new SqlParameter("@City_Enable",city.City_Enable),
                new SqlParameter("@City_Clear",city.City_Clear)
            };
            return DbHelperSQL.ExecuteSql(sql, sps);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="City_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int UpdateClearCity(string City_Code)
        {
            string sql = string.Format("update T_City set City_Clear=0 where City_Code='{0}' and City_Clear=1 and City_Enable=1", XYEEncoding.strCodeHex(City_Code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 假删除全部
        /// <summary>
        /// 假删除全部
        /// </summary>
        /// <returns>受影响行数</returns>
        public int UpdateAllClearCity()
        {
            string sql = string.Format("update T_City set City_Clear=0 where City_Clear=1 and City_Enable=1 and City_ParentId<>'D4'");
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 禁用
        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="City_Code">编号</param>
        /// <returns>受影响行数</returns>
        public int UpdateEnableCity(string City_Code)
        {
            string sql = string.Format("update T_City set City_Clear=0 where City_Code='{0}' and City_Clear=1 and City_Enable=1", XYEEncoding.strCodeHex(City_Code));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 改名称
        /// <summary>
        /// 改名称
        /// </summary>
        /// <param name="City_Name">名称</param>
        /// <param name="City_Code">编号</param>
        /// <param name="FCity_Name">之前的名称</param>
        /// <returns>受影响行数</returns>
        public int UpdateNameCity(string City_Name, string City_Code, string FCity_Name)
        {
            string sql = string.Format("update T_City set City_Name='{0}' where City_Code='{1}' and City_Name='{2}' and City_Clear=1 and City_Enable=1", XYEEncoding.strCodeHex(City_Name), XYEEncoding.strCodeHex(City_Code), XYEEncoding.strCodeHex(FCity_Name));
            return DbHelperSQL.ExecuteSql(sql);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <param name="City_Code">编号</param>
        /// <returns>List集合</returns>
        public List<City> SelCityByCode(string City_Code)
        {
            List<City> list = new List<City>();
            string sql = string.Format("select * from T_City where City_Code='{0}' and City_Clear=1 and City_Enable=1", XYEEncoding.strCodeHex(City_Code));
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                City city = new City()
                {
                    City_ID = Convert.ToInt32(read["City_ID"]),
                    City_Name = XYEEncoding.strHexDecode(read["City_Name"].ToString()),
                    City_Code = XYEEncoding.strHexDecode(read["City_Code"].ToString()),
                    City_ParentId = XYEEncoding.strHexDecode(read["City_ParentId"].ToString()),
                    City_Clear = Convert.ToInt32(read["City_Clear"].ToString()),
                    City_Enable = Convert.ToInt32(read["City_Enable"].ToString())
                };
                list.Add(city);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<City> SelCity()
        {
            List<City> list = new List<City>();
            string sql = "select * from T_City where City_Clear=1 and City_Enable=1";
            SqlDataReader read = DbHelperSQL.ExecuteReader(sql);
            while (read.Read())
            {
                City city = new City()
                {
                    City_ID = Convert.ToInt32(read["City_ID"]),
                    City_Name = XYEEncoding.strHexDecode(read["City_Name"].ToString()),
                    City_Code = XYEEncoding.strHexDecode(read["City_Code"].ToString()),
                    City_ParentId = XYEEncoding.strHexDecode(read["City_ParentId"].ToString()),
                    City_Clear = Convert.ToInt32(read["City_Clear"].ToString()),
                    City_Enable = Convert.ToInt32(read["City_Enable"].ToString())
                };
                list.Add(city);
            }
            return list;
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelCityTable()
        {
            string sql = "select * from T_City where City_Clear=1 and City_Enable=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_City");
            return ds1.Tables[0];
        }
        #endregion
    }
}

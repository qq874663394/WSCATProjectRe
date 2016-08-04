using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using HelperUtility.Encrypt;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CityManager
    {
        private readonly CityService dal = new CityService();

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
        public bool Exists(int City_ID)
        {
            return dal.Exists(City_ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(City model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(City model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int City_ID)
        {

            return dal.Delete(City_ID);
        }
        /// <summary>
        /// 删除一条数据 
        /// </summary>
        public bool DeleteList(string City_IDlist)
        {
            return dal.DeleteList(HelperUtility.Validate.RegexValidate.SafeLongFilter(City_IDlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public City GetModel(int City_ID)
        {

            return dal.GetModel(City_ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
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
        public List<City> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<City> DataTableToList(DataTable dt)
        {
            List<City> modelList = new List<City>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                City model;
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
        // 分页获取数据列表
                //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod

        #region ExtensionMethod
        
        /// <summary>
        /// 根据code更新数据 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateByCode(City model)
        {
            model.City_Name = XYEEncoding.strCodeHex(model.City_Name);
            model.City_Code = XYEEncoding.strCodeHex(model.City_Code);
            model.City_ParentId = XYEEncoding.strCodeHex(model.City_ParentId);
            return dal.UpdateByCode(model);
        }

        /// <summary>
        /// 根据code删除数据
        /// </summary>
        /// <param name="City_Code"></param>
        /// <returns></returns>
        public bool DeleteByCode(string City_Code)
        {
            return dal.DeleteByCode(XYEEncoding.strCodeHex(City_Code));
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
            //string sql = "select * from T_City where City_Clear=1 and City_Enable=1";
            string sql = "select * from T_City";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DbHelperSQL.connectionString);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "T_City");
            return ds1.Tables[0];
        }
        #endregion

    }
}

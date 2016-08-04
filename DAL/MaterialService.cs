using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Model;
using DAL;

namespace DAL
{
	/// <summary>
	/// 数据访问类:Material
	/// </summary>
	public partial class MaterialService
    {
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Ma_ID", "T_Material"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Ma_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Material");
			strSql.Append(" where Ma_ID=@Ma_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ma_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Ma_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Material model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Material(");
			strSql.Append("Ma_PicName,Ma_Name,Ma_Model,Ma_RFID,Ma_Barcode,Ma_Code,Ma_TypeID,Ma_TypeName,Ma_Price,Ma_PriceA,Ma_PriceB,Ma_PriceC,Ma_PriceD,Ma_PriceE,Ma_CreateDate,Ma_Supplier,Ma_SupID,Ma_zhujima,Ma_Unit,Ma_InPrice,Ma_InDate,Ma_Remark,Ma_Enable,Ma_Clear,Ma_Safeyone,Ma_Safetytwo)");
			strSql.Append(" values (");
			strSql.Append("@Ma_PicName,@Ma_Name,@Ma_Model,@Ma_RFID,@Ma_Barcode,@Ma_Code,@Ma_TypeID,@Ma_TypeName,@Ma_Price,@Ma_PriceA,@Ma_PriceB,@Ma_PriceC,@Ma_PriceD,@Ma_PriceE,@Ma_CreateDate,@Ma_Supplier,@Ma_SupID,@Ma_zhujima,@Ma_Unit,@Ma_InPrice,@Ma_InDate,@Ma_Remark,@Ma_Enable,@Ma_Clear,@Ma_Safeyone,@Ma_Safetytwo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Ma_PicName", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Model", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_RFID", SqlDbType.NVarChar,1024),
					new SqlParameter("@Ma_Barcode", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_TypeID", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_TypeName", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Price", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceA", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceB", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceC", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceD", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceE", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Ma_Supplier", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_SupID", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_zhujima", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Unit", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_InPrice", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_InDate", SqlDbType.DateTime),
					new SqlParameter("@Ma_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@Ma_Enable", SqlDbType.Int,4),
					new SqlParameter("@Ma_Clear", SqlDbType.Int,4),
					new SqlParameter("@Ma_Safeyone", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Safetytwo", SqlDbType.NVarChar,512)};
			parameters[0].Value = model.Ma_PicName;
			parameters[1].Value = model.Ma_Name;
			parameters[2].Value = model.Ma_Model;
			parameters[3].Value = model.Ma_RFID;
			parameters[4].Value = model.Ma_Barcode;
			parameters[5].Value = model.Ma_Code;
			parameters[6].Value = model.Ma_TypeID;
			parameters[7].Value = model.Ma_TypeName;
			parameters[8].Value = model.Ma_Price;
			parameters[9].Value = model.Ma_PriceA;
			parameters[10].Value = model.Ma_PriceB;
			parameters[11].Value = model.Ma_PriceC;
			parameters[12].Value = model.Ma_PriceD;
			parameters[13].Value = model.Ma_PriceE;
			parameters[14].Value = model.Ma_CreateDate;
			parameters[15].Value = model.Ma_Supplier;
			parameters[16].Value = model.Ma_SupID;
			parameters[17].Value = model.Ma_zhujima;
			parameters[18].Value = model.Ma_Unit;
			parameters[19].Value = model.Ma_InPrice;
			parameters[20].Value = model.Ma_InDate;
			parameters[21].Value = model.Ma_Remark;
			parameters[22].Value = model.Ma_Enable;
			parameters[23].Value = model.Ma_Clear;
			parameters[24].Value = model.Ma_Safeyone;
			parameters[25].Value = model.Ma_Safetytwo;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Material model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Material set ");
			strSql.Append("Ma_PicName=@Ma_PicName,");
			strSql.Append("Ma_Name=@Ma_Name,");
			strSql.Append("Ma_Model=@Ma_Model,");
			strSql.Append("Ma_RFID=@Ma_RFID,");
			strSql.Append("Ma_Barcode=@Ma_Barcode,");
			strSql.Append("Ma_Code=@Ma_Code,");
			strSql.Append("Ma_TypeID=@Ma_TypeID,");
			strSql.Append("Ma_TypeName=@Ma_TypeName,");
			strSql.Append("Ma_Price=@Ma_Price,");
			strSql.Append("Ma_PriceA=@Ma_PriceA,");
			strSql.Append("Ma_PriceB=@Ma_PriceB,");
			strSql.Append("Ma_PriceC=@Ma_PriceC,");
			strSql.Append("Ma_PriceD=@Ma_PriceD,");
			strSql.Append("Ma_PriceE=@Ma_PriceE,");
			strSql.Append("Ma_CreateDate=@Ma_CreateDate,");
			strSql.Append("Ma_Supplier=@Ma_Supplier,");
			strSql.Append("Ma_SupID=@Ma_SupID,");
			strSql.Append("Ma_zhujima=@Ma_zhujima,");
			strSql.Append("Ma_Unit=@Ma_Unit,");
			strSql.Append("Ma_InPrice=@Ma_InPrice,");
			strSql.Append("Ma_InDate=@Ma_InDate,");
			strSql.Append("Ma_Remark=@Ma_Remark,");
			strSql.Append("Ma_Enable=@Ma_Enable,");
			strSql.Append("Ma_Clear=@Ma_Clear,");
			strSql.Append("Ma_Safeyone=@Ma_Safeyone,");
			strSql.Append("Ma_Safetytwo=@Ma_Safetytwo");
			strSql.Append(" where Ma_ID=@Ma_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ma_PicName", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Model", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_RFID", SqlDbType.NVarChar,1024),
					new SqlParameter("@Ma_Barcode", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_TypeID", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_TypeName", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Price", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceA", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceB", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceC", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceD", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_PriceE", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Ma_Supplier", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_SupID", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_zhujima", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Unit", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_InPrice", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_InDate", SqlDbType.DateTime),
					new SqlParameter("@Ma_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@Ma_Enable", SqlDbType.Int,4),
					new SqlParameter("@Ma_Clear", SqlDbType.Int,4),
					new SqlParameter("@Ma_Safeyone", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_Safetytwo", SqlDbType.NVarChar,512),
					new SqlParameter("@Ma_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Ma_PicName;
			parameters[1].Value = model.Ma_Name;
			parameters[2].Value = model.Ma_Model;
			parameters[3].Value = model.Ma_RFID;
			parameters[4].Value = model.Ma_Barcode;
			parameters[5].Value = model.Ma_Code;
			parameters[6].Value = model.Ma_TypeID;
			parameters[7].Value = model.Ma_TypeName;
			parameters[8].Value = model.Ma_Price;
			parameters[9].Value = model.Ma_PriceA;
			parameters[10].Value = model.Ma_PriceB;
			parameters[11].Value = model.Ma_PriceC;
			parameters[12].Value = model.Ma_PriceD;
			parameters[13].Value = model.Ma_PriceE;
			parameters[14].Value = model.Ma_CreateDate;
			parameters[15].Value = model.Ma_Supplier;
			parameters[16].Value = model.Ma_SupID;
			parameters[17].Value = model.Ma_zhujima;
			parameters[18].Value = model.Ma_Unit;
			parameters[19].Value = model.Ma_InPrice;
			parameters[20].Value = model.Ma_InDate;
			parameters[21].Value = model.Ma_Remark;
			parameters[22].Value = model.Ma_Enable;
			parameters[23].Value = model.Ma_Clear;
			parameters[24].Value = model.Ma_Safeyone;
			parameters[25].Value = model.Ma_Safetytwo;
			parameters[26].Value = model.Ma_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int Ma_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Material ");
			strSql.Append(" where Ma_ID=@Ma_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ma_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Ma_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Ma_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Material ");
			strSql.Append(" where Ma_ID in ("+Ma_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Material GetModel(int Ma_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Ma_ID,Ma_PicName,Ma_Name,Ma_Model,Ma_RFID,Ma_Barcode,Ma_Code,Ma_TypeID,Ma_TypeName,Ma_Price,Ma_PriceA,Ma_PriceB,Ma_PriceC,Ma_PriceD,Ma_PriceE,Ma_CreateDate,Ma_Supplier,Ma_SupID,Ma_zhujima,Ma_Unit,Ma_InPrice,Ma_InDate,Ma_Remark,Ma_Enable,Ma_Clear,Ma_Safeyone,Ma_Safetytwo from T_Material ");
			strSql.Append(" where Ma_ID=@Ma_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Ma_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Ma_ID;

			Material model=new Material();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Material DataRowToModel(DataRow row)
		{
			Material model=new Material();
			if (row != null)
			{
				if(row["Ma_ID"]!=null && row["Ma_ID"].ToString()!="")
				{
					model.Ma_ID=int.Parse(row["Ma_ID"].ToString());
				}
				if(row["Ma_PicName"]!=null)
				{
					model.Ma_PicName=row["Ma_PicName"].ToString();
				}
				if(row["Ma_Name"]!=null)
				{
					model.Ma_Name=row["Ma_Name"].ToString();
				}
				if(row["Ma_Model"]!=null)
				{
					model.Ma_Model=row["Ma_Model"].ToString();
				}
				if(row["Ma_RFID"]!=null)
				{
					model.Ma_RFID=row["Ma_RFID"].ToString();
				}
				if(row["Ma_Barcode"]!=null)
				{
					model.Ma_Barcode=row["Ma_Barcode"].ToString();
				}
				if(row["Ma_Code"]!=null)
				{
					model.Ma_Code=row["Ma_Code"].ToString();
				}
				if(row["Ma_TypeID"]!=null)
				{
					model.Ma_TypeID=row["Ma_TypeID"].ToString();
				}
				if(row["Ma_TypeName"]!=null)
				{
					model.Ma_TypeName=row["Ma_TypeName"].ToString();
				}
				if(row["Ma_Price"]!=null)
				{
					model.Ma_Price=row["Ma_Price"].ToString();
				}
				if(row["Ma_PriceA"]!=null)
				{
					model.Ma_PriceA=row["Ma_PriceA"].ToString();
				}
				if(row["Ma_PriceB"]!=null)
				{
					model.Ma_PriceB=row["Ma_PriceB"].ToString();
				}
				if(row["Ma_PriceC"]!=null)
				{
					model.Ma_PriceC=row["Ma_PriceC"].ToString();
				}
				if(row["Ma_PriceD"]!=null)
				{
					model.Ma_PriceD=row["Ma_PriceD"].ToString();
				}
				if(row["Ma_PriceE"]!=null)
				{
					model.Ma_PriceE=row["Ma_PriceE"].ToString();
				}
				if(row["Ma_CreateDate"]!=null && row["Ma_CreateDate"].ToString()!="")
				{
					model.Ma_CreateDate=DateTime.Parse(row["Ma_CreateDate"].ToString());
				}
				if(row["Ma_Supplier"]!=null)
				{
					model.Ma_Supplier=row["Ma_Supplier"].ToString();
				}
				if(row["Ma_SupID"]!=null)
				{
					model.Ma_SupID=row["Ma_SupID"].ToString();
				}
				if(row["Ma_zhujima"] !=null)
				{
					model.Ma_zhujima = row["Ma_zhujima"].ToString();
				}
				if(row["Ma_Unit"]!=null)
				{
					model.Ma_Unit=row["Ma_Unit"].ToString();
				}
				if(row["Ma_InPrice"]!=null)
				{
					model.Ma_InPrice=row["Ma_InPrice"].ToString();
				}
				if(row["Ma_InDate"]!=null && row["Ma_InDate"].ToString()!="")
				{
					model.Ma_InDate=DateTime.Parse(row["Ma_InDate"].ToString());
				}
				if(row["Ma_Remark"]!=null)
				{
					model.Ma_Remark=row["Ma_Remark"].ToString();
				}
				if(row["Ma_Enable"]!=null && row["Ma_Enable"].ToString()!="")
				{
					model.Ma_Enable=int.Parse(row["Ma_Enable"].ToString());
				}
				if(row["Ma_Clear"]!=null && row["Ma_Clear"].ToString()!="")
				{
					model.Ma_Clear=int.Parse(row["Ma_Clear"].ToString());
				}
				if(row["Ma_Safeyone"]!=null)
				{
					model.Ma_Safeyone=row["Ma_Safeyone"].ToString();
				}
				if(row["Ma_Safetytwo"]!=null)
				{
					model.Ma_Safetytwo=row["Ma_Safetytwo"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Ma_ID,Ma_PicName,Ma_Name,Ma_Model,Ma_RFID,Ma_Barcode,Ma_Code,Ma_TypeID,Ma_TypeName,Ma_Price,Ma_PriceA,Ma_PriceB,Ma_PriceC,Ma_PriceD,Ma_PriceE,Ma_CreateDate,Ma_Supplier,Ma_SupID,Ma_zhujima,Ma_Unit,Ma_InPrice,Ma_InDate,Ma_Remark,Ma_Enable,Ma_Clear,Ma_Safeyone,Ma_Safetytwo ");
			strSql.Append(" FROM T_Material where Ma_Clear = 1 and Ma_Enable = 1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Ma_ID,Ma_PicName,Ma_Name,Ma_Model,Ma_RFID,Ma_Barcode,Ma_Code,Ma_TypeID,Ma_TypeName,Ma_Price,Ma_PriceA,Ma_PriceB,Ma_PriceC,Ma_PriceD,Ma_PriceE,Ma_CreateDate,Ma_Supplier,Ma_SupID,Ma_zhujima,Ma_Unit,Ma_InPrice,Ma_InDate,Ma_Remark,Ma_Enable,Ma_Clear,Ma_Safeyone,Ma_Safetytwo ");
			strSql.Append(" FROM T_Material where Ma_Clear = 1 and Ma_Enable = 1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_Material where Ma_Clear = 1 and Ma_Enable = 1");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Ma_ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Material T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
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
			parameters[0].Value = "T_Material";
			parameters[1].Value = "Ma_ID";
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
        public bool Exists(string Ma_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Material");
            strSql.Append(" where Ma_Code=@Ma_Code and Ma_Clear = 1 and Ma_Enable = 1");
            SqlParameter[] parameters = {
                    new SqlParameter("@Ma_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Ma_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteFake(string Ma_Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Material set");
            strSql.Append(" Ma_Clear = 0");
            strSql.Append(" where Ma_Code = @Ma_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Ma_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Ma_Code;

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

        #endregion  ExtensionMethod
    }
}


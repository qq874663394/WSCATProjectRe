using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DAL;
using Model;
using System.Collections.Generic;
using System.Collections;

namespace DAL
{
	/// <summary>
	/// 数据访问类:Client
	/// </summary>
	public partial class ClientService
	{
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Cli_ID", "T_Client"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Cli_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Client");
			strSql.Append(" where Cli_ID=@Cli_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Cli_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Cli_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Client model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Client(");
			strSql.Append("Cli_Code,Cli_zhiwen,Cli_Name,Cli_PicName,Cli_Phone,Cli_PhoneTwo,Cli_faxes,Cli_CityCode,Cli_area,Cli_Address,Cli_LinkMan,Cli_Company,Cli_TypeCode,Cli_TypeName,Cli_DiscountCode,Cli_Bankaccounts,Cli_OpenBank,Cli_Olddata,Cli_Oldreturn,Cli_Newoutdata,Cli_Newintodata,Cli_Createdata,Cli_Limit,Cli_RemainLimit,Cli_ClearLimitdate,Cli_ShouldMoney,Cli_GetMoney,Cli_PreMoney,Cli_Remark,Cli_safetone,Cli_safettwo,Cli_Enable)");
			strSql.Append(" values (");
			strSql.Append("@Cli_Code,@Cli_zhiwen,@Cli_Name,@Cli_PicName,@Cli_Phone,@Cli_PhoneTwo,@Cli_faxes,@Cli_CityCode,@Cli_area,@Cli_Address,@Cli_LinkMan,@Cli_Company,@Cli_TypeCode,@Cli_TypeName,@Cli_DiscountCode,@Cli_Bankaccounts,@Cli_OpenBank,@Cli_Olddata,@Cli_Oldreturn,@Cli_Newoutdata,@Cli_Newintodata,@Cli_Createdata,@Cli_Limit,@Cli_RemainLimit,@Cli_ClearLimitdate,@Cli_ShouldMoney,@Cli_GetMoney,@Cli_PreMoney,@Cli_Remark,@Cli_safetone,@Cli_safettwo,@Cli_Enable)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Cli_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_zhiwen", SqlDbType.NVarChar,-1),
					new SqlParameter("@Cli_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_PicName", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Phone", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_PhoneTwo", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_faxes", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_CityCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_area", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Address", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Company", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_DiscountCode", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Bankaccounts", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_OpenBank", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Olddata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Oldreturn", SqlDbType.DateTime),
					new SqlParameter("@Cli_Newoutdata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Newintodata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Createdata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Limit", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_RemainLimit", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_ClearLimitdate", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_ShouldMoney", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_GetMoney", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_PreMoney", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@Cli_safetone", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_safettwo", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Enable", SqlDbType.Int,4)};
			parameters[0].Value = model.Cli_Code;
			parameters[1].Value = model.Cli_zhiwen;
			parameters[2].Value = model.Cli_Name;
			parameters[3].Value = model.Cli_PicName;
			parameters[4].Value = model.Cli_Phone;
			parameters[5].Value = model.Cli_PhoneTwo;
			parameters[6].Value = model.Cli_faxes;
            parameters[7].Value = model.Cli_Citycode;
            parameters[8].Value = model.Cli_area;
			parameters[9].Value = model.Cli_Address;
			parameters[10].Value = model.Cli_LinkMan;
            parameters[11].Value = model.Cli_Company;
            parameters[12].Value = model.Cli_TypeCode;
            parameters[13].Value = model.Cli_typename;
            parameters[14].Value = model.Cli_DiscountCode;
			parameters[15].Value = model.Cli_Bankaccounts;
			parameters[16].Value = model.Cli_OpenBank;
			parameters[17].Value = model.Cli_Olddata;
			parameters[18].Value = model.Cli_Oldreturn;
			parameters[19].Value = model.Cli_Newoutdata;
			parameters[20].Value = model.Cli_Newintodata;
			parameters[21].Value = model.Cli_Createdata;
			parameters[22].Value = model.Cli_Limit;
			parameters[23].Value = model.Cli_RemainLimit;
			parameters[24].Value = model.Cli_ClearLimitdate;
			parameters[25].Value = model.Cli_ShouldMoney;
			parameters[26].Value = model.Cli_GetMoney;
			parameters[27].Value = model.Cli_PreMoney;
			parameters[28].Value = model.Cli_Remark;
			parameters[29].Value = model.Cli_safetone;
			parameters[30].Value = model.Cli_safettwo;
			parameters[31].Value = model.Cli_Enable;

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
		public bool Update(Client model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Client set ");
			strSql.Append("Cli_Code=@Cli_Code,");
			strSql.Append("Cli_zhiwen=@Cli_zhiwen,");
			strSql.Append("Cli_Name=@Cli_Name,");
			strSql.Append("Cli_PicName=@Cli_PicName,");
			strSql.Append("Cli_Phone=@Cli_Phone,");
			strSql.Append("Cli_PhoneTwo=@Cli_PhoneTwo,");
			strSql.Append("Cli_faxes=@Cli_faxes,");
            strSql.Append("Cli_CityCode=@Cli_CityCode,");
            strSql.Append("Cli_area=@Cli_area,");
			strSql.Append("Cli_Address=@Cli_Address,");
			strSql.Append("Cli_LinkMan=@Cli_LinkMan,");
			strSql.Append("Cli_TypeCode=@Cli_TypeCode,");
            strSql.Append("Cli_TypeName=@Cli_TypeName,");
            strSql.Append("Cli_Company=@Cli_Company,");
            strSql.Append("Cli_DiscountCode=@Cli_DiscountCode,");
			strSql.Append("Cli_Bankaccounts=@Cli_Bankaccounts,");
			strSql.Append("Cli_OpenBank=@Cli_OpenBank,");
			strSql.Append("Cli_Olddata=@Cli_Olddata,");
			strSql.Append("Cli_Oldreturn=@Cli_Oldreturn,");
			strSql.Append("Cli_Newoutdata=@Cli_Newoutdata,");
			strSql.Append("Cli_Newintodata=@Cli_Newintodata,");
			strSql.Append("Cli_Createdata=@Cli_Createdata,");
			strSql.Append("Cli_Limit=@Cli_Limit,");
			strSql.Append("Cli_RemainLimit=@Cli_RemainLimit,");
			strSql.Append("Cli_ClearLimitdate=@Cli_ClearLimitdate,");
			strSql.Append("Cli_ShouldMoney=@Cli_ShouldMoney,");
			strSql.Append("Cli_GetMoney=@Cli_GetMoney,");
			strSql.Append("Cli_PreMoney=@Cli_PreMoney,");
			strSql.Append("Cli_Remark=@Cli_Remark,");
			strSql.Append("Cli_safetone=@Cli_safetone,");
			strSql.Append("Cli_safettwo=@Cli_safettwo,");
			strSql.Append("Cli_Enable=@Cli_Enable");
			strSql.Append(" where Cli_ID=@Cli_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Cli_Code", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_zhiwen", SqlDbType.NVarChar,-1),
					new SqlParameter("@Cli_Name", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_PicName", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Phone", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_PhoneTwo", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_faxes", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_CityCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_area", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Address", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Company", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_DiscountCode", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Bankaccounts", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_OpenBank", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Olddata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Oldreturn", SqlDbType.DateTime),
					new SqlParameter("@Cli_Newoutdata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Newintodata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Createdata", SqlDbType.DateTime),
					new SqlParameter("@Cli_Limit", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_RemainLimit", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_ClearLimitdate", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_ShouldMoney", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_GetMoney", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_PreMoney", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Remark", SqlDbType.NVarChar,1024),
					new SqlParameter("@Cli_safetone", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_safettwo", SqlDbType.NVarChar,512),
					new SqlParameter("@Cli_Enable", SqlDbType.Int,4),
					new SqlParameter("@Cli_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Cli_Code;
			parameters[1].Value = model.Cli_zhiwen;
			parameters[2].Value = model.Cli_Name;
			parameters[3].Value = model.Cli_PicName;
			parameters[4].Value = model.Cli_Phone;
			parameters[5].Value = model.Cli_PhoneTwo;
			parameters[6].Value = model.Cli_faxes;
            parameters[7].Value = model.Cli_Citycode;
            parameters[8].Value = model.Cli_area;
			parameters[9].Value = model.Cli_Address;
			parameters[10].Value = model.Cli_LinkMan;
            parameters[11].Value = model.Cli_Company;
            parameters[12].Value = model.Cli_TypeCode;
            parameters[13].Value = model.Cli_typename;
            parameters[14].Value = model.Cli_DiscountCode;
			parameters[15].Value = model.Cli_Bankaccounts;
			parameters[16].Value = model.Cli_OpenBank;
			parameters[17].Value = model.Cli_Olddata;
			parameters[18].Value = model.Cli_Oldreturn;
			parameters[19].Value = model.Cli_Newoutdata;
			parameters[20].Value = model.Cli_Newintodata;
			parameters[21].Value = model.Cli_Createdata;
			parameters[22].Value = model.Cli_Limit;
			parameters[23].Value = model.Cli_RemainLimit;
			parameters[24].Value = model.Cli_ClearLimitdate;
			parameters[25].Value = model.Cli_ShouldMoney;
			parameters[26].Value = model.Cli_GetMoney;
			parameters[27].Value = model.Cli_PreMoney;
			parameters[28].Value = model.Cli_Remark;
			parameters[29].Value = model.Cli_safetone;
			parameters[30].Value = model.Cli_safettwo;
			parameters[31].Value = model.Cli_Enable;
			parameters[32].Value = model.Cli_ID;

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
		public bool Delete(int Cli_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Client ");
			strSql.Append(" where Cli_ID=@Cli_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Cli_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Cli_ID;

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
		public bool DeleteList(string Cli_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Client ");
			strSql.Append(" where Cli_ID in ("+Cli_IDlist + ")  ");
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
		public Client GetModel(int Cli_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Cli_ID,Cli_Code,Cli_zhiwen,Cli_Name,Cli_PicName,Cli_Phone,Cli_PhoneTwo,Cli_faxes,Cli_CityCode,Cli_TypeName,Cli_area,Cli_Address,Cli_LinkMan,Cli_Company,Cli_TypeCode,Cli_DiscountCode,Cli_Bankaccounts,Cli_OpenBank,Cli_Olddata,Cli_Oldreturn,Cli_Newoutdata,Cli_Newintodata,Cli_Createdata,Cli_Limit,Cli_RemainLimit,Cli_ClearLimitdate,Cli_ShouldMoney,Cli_GetMoney,Cli_PreMoney,Cli_Remark,Cli_safetone,Cli_safettwo,Cli_Enable from T_Client ");
			strSql.Append(" where Cli_ID=@Cli_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Cli_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Cli_ID;

			Client model=new Client();
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
		public Client DataRowToModel(DataRow row)
		{
			Client model=new Client();
			if (row != null)
			{
				if(row["Cli_ID"]!=null && row["Cli_ID"].ToString()!="")
				{
					model.Cli_ID=int.Parse(row["Cli_ID"].ToString());
				}
				if(row["Cli_Code"]!=null)
				{
					model.Cli_Code=row["Cli_Code"].ToString();
				}
				if(row["Cli_zhiwen"]!=null)
				{
					model.Cli_zhiwen=row["Cli_zhiwen"].ToString();
				}
				if(row["Cli_Name"]!=null)
				{
					model.Cli_Name=row["Cli_Name"].ToString();
				}
				if(row["Cli_PicName"]!=null)
				{
					model.Cli_PicName=row["Cli_PicName"].ToString();
				}
				if(row["Cli_Phone"]!=null)
				{
					model.Cli_Phone=row["Cli_Phone"].ToString();
				}
				if(row["Cli_PhoneTwo"]!=null)
				{
					model.Cli_PhoneTwo=row["Cli_PhoneTwo"].ToString();
				}
				if(row["Cli_faxes"]!=null)
				{
					model.Cli_faxes=row["Cli_faxes"].ToString();
				}
                if (row["Cli_CityCode"] != null)
                {
                    model.Cli_faxes = row["Cli_CityCode"].ToString();
                }
                if (row["Cli_area"]!=null)
				{
					model.Cli_area=row["Cli_area"].ToString();
				}
				if(row["Cli_Address"]!=null)
				{
					model.Cli_Address=row["Cli_Address"].ToString();
				}
				if(row["Cli_LinkMan"]!=null)
				{
					model.Cli_LinkMan=row["Cli_LinkMan"].ToString();
				}
                if (row["Cli_Company"] != null)
                {
                    model.Cli_Company = row["Cli_Company"].ToString();
                }
                if (row["Cli_TypeCode"]!=null)
				{
					model.Cli_TypeCode=row["Cli_TypeCode"].ToString();
				}
                if (row["Cli_TypeName"] != null)
                {
                    model.Cli_TypeCode = row["Cli_TypeName"].ToString();
                }
                if (row["Cli_DiscountCode"]!=null)
				{
					model.Cli_DiscountCode=row["Cli_DiscountCode"].ToString();
				}
				if(row["Cli_Bankaccounts"]!=null)
				{
					model.Cli_Bankaccounts=row["Cli_Bankaccounts"].ToString();
				}
				if(row["Cli_OpenBank"]!=null)
				{
					model.Cli_OpenBank=row["Cli_OpenBank"].ToString();
				}
				if(row["Cli_Olddata"]!=null && row["Cli_Olddata"].ToString()!="")
				{
					model.Cli_Olddata=DateTime.Parse(row["Cli_Olddata"].ToString());
				}
				if(row["Cli_Oldreturn"]!=null && row["Cli_Oldreturn"].ToString()!="")
				{
					model.Cli_Oldreturn=DateTime.Parse(row["Cli_Oldreturn"].ToString());
				}
				if(row["Cli_Newoutdata"]!=null && row["Cli_Newoutdata"].ToString()!="")
				{
					model.Cli_Newoutdata=DateTime.Parse(row["Cli_Newoutdata"].ToString());
				}
				if(row["Cli_Newintodata"]!=null && row["Cli_Newintodata"].ToString()!="")
				{
					model.Cli_Newintodata=DateTime.Parse(row["Cli_Newintodata"].ToString());
				}
				if(row["Cli_Createdata"]!=null && row["Cli_Createdata"].ToString()!="")
				{
					model.Cli_Createdata=DateTime.Parse(row["Cli_Createdata"].ToString());
				}
				if(row["Cli_Limit"]!=null)
				{
					model.Cli_Limit=row["Cli_Limit"].ToString();
				}
				if(row["Cli_RemainLimit"]!=null)
				{
					model.Cli_RemainLimit=row["Cli_RemainLimit"].ToString();
				}
				if(row["Cli_ClearLimitdate"]!=null && row["Cli_ClearLimitdate"].ToString()!="")
				{
					model.Cli_ClearLimitdate=row["Cli_ClearLimitdate"].ToString();
				}
				if(row["Cli_ShouldMoney"]!=null)
				{
					model.Cli_ShouldMoney=row["Cli_ShouldMoney"].ToString();
				}
				if(row["Cli_GetMoney"]!=null)
				{
					model.Cli_GetMoney=row["Cli_GetMoney"].ToString();
				}
				if(row["Cli_PreMoney"]!=null)
				{
					model.Cli_PreMoney=row["Cli_PreMoney"].ToString();
				}
				if(row["Cli_Remark"]!=null)
				{
					model.Cli_Remark=row["Cli_Remark"].ToString();
				}
				if(row["Cli_safetone"]!=null)
				{
					model.Cli_safetone=row["Cli_safetone"].ToString();
				}
				if(row["Cli_safettwo"]!=null)
				{
					model.Cli_safettwo=row["Cli_safettwo"].ToString();
				}
				if(row["Cli_Enable"]!=null && row["Cli_Enable"].ToString()!="")
				{
					model.Cli_Enable=int.Parse(row["Cli_Enable"].ToString());
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
			strSql.Append("select Cli_ID,Cli_Code,Cli_zhiwen,Cli_Name,Cli_PicName,Cli_Phone,Cli_PhoneTwo,Cli_faxes,Cli_CityCode,Cli_area,Cli_Address,Cli_LinkMan,Cli_Company,Cli_TypeCode,Cli_TypeName,Cli_DiscountCode,Cli_Bankaccounts,Cli_OpenBank,Cli_Olddata,Cli_Oldreturn,Cli_Newoutdata,Cli_Newintodata,Cli_Createdata,Cli_Limit,Cli_RemainLimit,Cli_ClearLimitdate,Cli_ShouldMoney,Cli_GetMoney,Cli_PreMoney,Cli_Remark,Cli_safetone,Cli_safettwo,Cli_Enable ");
			strSql.Append(" FROM T_Client where Cli_Enable = 1");
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
			strSql.Append(" Cli_ID,Cli_Code,Cli_zhiwen,Cli_Name,Cli_PicName,Cli_Phone,Cli_PhoneTwo,Cli_faxes,Cli_CityCode,Cli_area,Cli_Address,Cli_LinkMan,Cli_Company,Cli_TypeCode,Cli_TypeName,Cli_DiscountCode,Cli_Bankaccounts,Cli_OpenBank,Cli_Olddata,Cli_Oldreturn,Cli_Newoutdata,Cli_Newintodata,Cli_Createdata,Cli_Limit,Cli_RemainLimit,Cli_ClearLimitdate,Cli_ShouldMoney,Cli_GetMoney,Cli_PreMoney,Cli_Remark,Cli_safetone,Cli_safettwo,Cli_Enable ");
			strSql.Append(" FROM T_Client where Cli_Enable = 1");
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
			strSql.Append("select count(1) FROM T_Client ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
				strSql.Append("order by T.Cli_ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_Client T ");
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
			parameters[0].Value = "T_Client";
			parameters[1].Value = "Cli_ID";
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
        /// 判断该客户编号判断是否存在
        /// </summary>
        /// <param name="Cli_Code"></param>
        /// <returns></returns>
        public bool Exists(string Cli_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Client");
            strSql.Append(" where Cli_Code=@Cli_Code and Cli_Enable = 1");
            SqlParameter[] parameters = {
                    new SqlParameter("@Cli_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Cli_Code;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据客户编号做真删除
        /// </summary>
        /// <param name="Cli_Code"></param>
        /// <returns></returns>
        public bool Delete(string Cli_Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Client ");
            strSql.Append(" where Cli_Code=@Cli_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Cli_Code", SqlDbType.VarChar,512)
            };
            parameters[0].Value = Cli_Code;

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

        public bool AddClientAndDiscount(Client client,Discount discount)
        {
            Hashtable sqlhash = new Hashtable();
            StringBuilder strsql = new StringBuilder();

            strsql.Append("insert into T_Discount(");
            strsql.Append("Dis_Name,Dis_ClientCode,Dis_CreateDate,Dis_ClearDate,Dis_Discount,Dis_Enable,Dis_Clear,Dis_Remark,Dis_Code");
            strsql.Append(") values (");
            strsql.Append("@Dis_Name,@Dis_ClientCode,@Dis_CreateDate,@Dis_ClearDate,@Dis_Discount,@Dis_Enable,@Dis_Clear,@Dis_Remark,@Dis_Code)");
            SqlParameter[] disParameters = {
                    new SqlParameter("@Dis_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Dis_ClientCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Dis_CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@Dis_ClearDate", SqlDbType.DateTime),
                    new SqlParameter("@Dis_Discount", SqlDbType.NVarChar,512),
                    new SqlParameter("@Dis_Enable", SqlDbType.Int,4),
                    new SqlParameter("@Dis_Clear", SqlDbType.Int,4),
                    new SqlParameter("@Dis_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@Dis_Code", SqlDbType.NVarChar,512),};
            disParameters[0].Value = discount.Dis_Name;
            disParameters[1].Value = discount.Dis_ClientCode;
            disParameters[2].Value = discount.Dis_CreateDate;
            disParameters[3].Value = discount.Dis_ClearDate;
            disParameters[4].Value = discount.Dis_Discount;
            disParameters[5].Value = discount.Dis_Enable;
            disParameters[6].Value = discount.Dis_Clear;
            disParameters[7].Value = discount.Dis_Remark;
            disParameters[8].Value = discount.Dis_Code;

            sqlhash.Add(strsql.ToString(), disParameters);

            strsql = new StringBuilder();

            strsql.Append("insert into T_Client(");
            strsql.Append("Cli_Code,Cli_zhiwen,Cli_Name,Cli_PicName,Cli_Phone,Cli_PhoneTwo,Cli_faxes,Cli_CityCode,Cli_area,Cli_Address,Cli_LinkMan,Cli_Company,Cli_TypeCode,Cli_TypeName,Cli_DiscountCode,Cli_Bankaccounts,Cli_OpenBank,Cli_Olddata,Cli_Oldreturn,Cli_Newoutdata,Cli_Newintodata,Cli_Createdata,Cli_Limit,Cli_RemainLimit,Cli_ClearLimitdate,Cli_ShouldMoney,Cli_GetMoney,Cli_PreMoney,Cli_Remark,Cli_safetone,Cli_safettwo,Cli_Enable)");
            strsql.Append(" values (");
            strsql.Append("@Cli_Code,@Cli_zhiwen,@Cli_Name,@Cli_PicName,@Cli_Phone,@Cli_PhoneTwo,@Cli_faxes,@Cli_CityCode,@Cli_area,@Cli_Address,@Cli_LinkMan,@Cli_Company,@Cli_TypeCode,@Cli_TypeName,@Cli_DiscountCode,@Cli_Bankaccounts,@Cli_OpenBank,@Cli_Olddata,@Cli_Oldreturn,@Cli_Newoutdata,@Cli_Newintodata,@Cli_Createdata,@Cli_Limit,@Cli_RemainLimit,@Cli_ClearLimitdate,@Cli_ShouldMoney,@Cli_GetMoney,@Cli_PreMoney,@Cli_Remark,@Cli_safetone,@Cli_safettwo,@Cli_Enable)");
            SqlParameter[] cliParameters = {
                    new SqlParameter("@Cli_Code", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_zhiwen", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Cli_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_PicName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Phone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_PhoneTwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_faxes", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_CityCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_area", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Company", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_DiscountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Bankaccounts", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_OpenBank", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Olddata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Oldreturn", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Newoutdata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Newintodata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Createdata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Limit", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_RemainLimit", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_ClearLimitdate", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_ShouldMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_GetMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_PreMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@Cli_safetone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_safettwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Enable", SqlDbType.Int,4)};
            cliParameters[0].Value = client.Cli_Code;
            cliParameters[1].Value = client.Cli_zhiwen;
            cliParameters[2].Value = client.Cli_Name;
            cliParameters[3].Value = client.Cli_PicName;
            cliParameters[4].Value = client.Cli_Phone;
            cliParameters[5].Value = client.Cli_PhoneTwo;
            cliParameters[6].Value = client.Cli_faxes;
            cliParameters[7].Value = client.Cli_Citycode;
            cliParameters[8].Value = client.Cli_area;
            cliParameters[9].Value = client.Cli_Address;
            cliParameters[10].Value = client.Cli_LinkMan;
            cliParameters[11].Value = client.Cli_Company;
            cliParameters[12].Value = client.Cli_TypeCode;
            cliParameters[13].Value = client.Cli_typename;
            cliParameters[14].Value = client.Cli_DiscountCode;
            cliParameters[15].Value = client.Cli_Bankaccounts;
            cliParameters[16].Value = client.Cli_OpenBank;
            cliParameters[17].Value = client.Cli_Olddata;
            cliParameters[18].Value = client.Cli_Oldreturn;
            cliParameters[19].Value = client.Cli_Newoutdata;
            cliParameters[20].Value = client.Cli_Newintodata;
            cliParameters[21].Value = client.Cli_Createdata;
            cliParameters[22].Value = client.Cli_Limit;
            cliParameters[23].Value = client.Cli_RemainLimit;
            cliParameters[24].Value = client.Cli_ClearLimitdate;
            cliParameters[25].Value = client.Cli_ShouldMoney;
            cliParameters[26].Value = client.Cli_GetMoney;
            cliParameters[27].Value = client.Cli_PreMoney;
            cliParameters[28].Value = client.Cli_Remark;
            cliParameters[29].Value = client.Cli_safetone;
            cliParameters[30].Value = client.Cli_safettwo;
            cliParameters[31].Value = client.Cli_Enable;

            sqlhash.Add(strsql.ToString(), cliParameters);

            try
            {
                DbHelperSQL.ExecuteSqlTran(sqlhash);
                return true;
            }
            catch (Exception)
            {
                throw ;
            }
        }

        /// <summary>
        /// 根据编码更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateByCode(Client model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Client set ");
            strSql.Append("Cli_zhiwen=@Cli_zhiwen,");
            strSql.Append("Cli_Name=@Cli_Name,");
            strSql.Append("Cli_PicName=@Cli_PicName,");
            strSql.Append("Cli_Phone=@Cli_Phone,");
            strSql.Append("Cli_PhoneTwo=@Cli_PhoneTwo,");
            strSql.Append("Cli_faxes=@Cli_faxes,");
            strSql.Append("Cli_CityCode=@Cli_CityCode,");
            strSql.Append("Cli_area=@Cli_area,");
            strSql.Append("Cli_Address=@Cli_Address,");
            strSql.Append("Cli_LinkMan=@Cli_LinkMan,");
            strSql.Append("Cli_TypeCode=@Cli_TypeCode,");
            strSql.Append("Cli_TypeName=@Cli_TypeName,");
            strSql.Append("Cli_Company=@Cli_Company,");
            strSql.Append("Cli_DiscountCode=@Cli_DiscountCode,");
            strSql.Append("Cli_Bankaccounts=@Cli_Bankaccounts,");
            strSql.Append("Cli_OpenBank=@Cli_OpenBank,");
            strSql.Append("Cli_Olddata=@Cli_Olddata,");
            strSql.Append("Cli_Oldreturn=@Cli_Oldreturn,");
            strSql.Append("Cli_Newoutdata=@Cli_Newoutdata,");
            strSql.Append("Cli_Newintodata=@Cli_Newintodata,");
            strSql.Append("Cli_Createdata=@Cli_Createdata,");
            strSql.Append("Cli_Limit=@Cli_Limit,");
            strSql.Append("Cli_RemainLimit=@Cli_RemainLimit,");
            strSql.Append("Cli_ClearLimitdate=@Cli_ClearLimitdate,");
            strSql.Append("Cli_ShouldMoney=@Cli_ShouldMoney,");
            strSql.Append("Cli_GetMoney=@Cli_GetMoney,");
            strSql.Append("Cli_PreMoney=@Cli_PreMoney,");
            strSql.Append("Cli_Remark=@Cli_Remark,");
            strSql.Append("Cli_safetone=@Cli_safetone,");
            strSql.Append("Cli_safettwo=@Cli_safettwo,");
            strSql.Append("Cli_Enable=@Cli_Enable");
            strSql.Append(" where Cli_Code=@Cli_Code");
            SqlParameter[] parameters = {
                    new SqlParameter("@Cli_zhiwen", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Cli_Name", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_PicName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Phone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_PhoneTwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_faxes", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_CityCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_area", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Address", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_LinkMan", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Company", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_TypeName", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_DiscountCode", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Bankaccounts", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_OpenBank", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Olddata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Oldreturn", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Newoutdata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Newintodata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Createdata", SqlDbType.DateTime),
                    new SqlParameter("@Cli_Limit", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_RemainLimit", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_ClearLimitdate", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_ShouldMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_GetMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_PreMoney", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Remark", SqlDbType.NVarChar,1024),
                    new SqlParameter("@Cli_safetone", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_safettwo", SqlDbType.NVarChar,512),
                    new SqlParameter("@Cli_Enable", SqlDbType.Int,4),
                    new SqlParameter("@Cli_Code", SqlDbType.NVarChar,512)};
            
            parameters[0].Value = model.Cli_zhiwen;
            parameters[1].Value = model.Cli_Name;
            parameters[2].Value = model.Cli_PicName;
            parameters[3].Value = model.Cli_Phone;
            parameters[4].Value = model.Cli_PhoneTwo;
            parameters[5].Value = model.Cli_faxes;
            parameters[6].Value = model.Cli_Citycode;
            parameters[7].Value = model.Cli_area;
            parameters[8].Value = model.Cli_Address;
            parameters[9].Value = model.Cli_LinkMan;
            parameters[10].Value = model.Cli_Company;
            parameters[11].Value = model.Cli_TypeCode;
            parameters[12].Value = model.Cli_typename;
            parameters[13].Value = model.Cli_DiscountCode;
            parameters[14].Value = model.Cli_Bankaccounts;
            parameters[15].Value = model.Cli_OpenBank;
            parameters[16].Value = model.Cli_Olddata;
            parameters[17].Value = model.Cli_Oldreturn;
            parameters[18].Value = model.Cli_Newoutdata;
            parameters[19].Value = model.Cli_Newintodata;
            parameters[20].Value = model.Cli_Createdata;
            parameters[21].Value = model.Cli_Limit;
            parameters[22].Value = model.Cli_RemainLimit;
            parameters[23].Value = model.Cli_ClearLimitdate;
            parameters[24].Value = model.Cli_ShouldMoney;
            parameters[25].Value = model.Cli_GetMoney;
            parameters[26].Value = model.Cli_PreMoney;
            parameters[27].Value = model.Cli_Remark;
            parameters[28].Value = model.Cli_safetone;
            parameters[29].Value = model.Cli_safettwo;
            parameters[30].Value = model.Cli_Enable;
            parameters[31].Value = model.Cli_Code;

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
        /// 根据code假删除
        /// </summary>
        /// <param name="code">编码</param>
        /// <returns></returns>
        public bool DeleteFake(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Client set ");
            strSql.Append("Cli_Enable=@Cli_Enable");
            strSql.Append(" where Cli_Code=@Cli_Code");

            SqlParameter[] parameter =
            {
                new SqlParameter("@Cli_Enable",SqlDbType.Int),
                new SqlParameter("@Cli_Code",SqlDbType.NVarChar,512)
            };

            parameter[0].Value = 0;
            parameter[1].Value = code;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameter);
            if(rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取简略的客户信息,包含编号/名称/电话/手机/地址/联系人/公司名称/备注
        /// </summary>
        /// <returns></returns>
        public DataSet GetListInSimple()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Cli_Code,Cli_Name,Cli_Phone,Cli_PhoneTwo,Cli_Address,Cli_LinkMan,Cli_Company,Cli_Remark from T_Client ");
            strSql.Append(" where Cli_Enable = 1 ");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }

        #endregion  ExtensionMethod
    }
}


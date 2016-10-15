using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TCReport.DTO.DBModel
{
	/// <summary>
	/// 类tc_report_instance。
	/// </summary>
	[Serializable]
	public partial class tc_report_instance
	{
		public tc_report_instance()
		{}
		#region Model
		private long _id;
		private string _name;
		private long _reportpropertyid;
		private long _reporttypeid;
		private long _createby;
		private long _createtime;
		private bool _isvalid;
		private DateTime _lastedittime;
		/// <summary>
		/// auto_increment
		/// </summary>
		public long ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long ReportPropertyID
		{
			set{ _reportpropertyid=value;}
			get{return _reportpropertyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long ReportTypeID
		{
			set{ _reporttypeid=value;}
			get{return _reporttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long CreateBy
		{
			set{ _createby=value;}
			get{return _createby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsValid
		{
			set{ _isvalid=value;}
			get{return _isvalid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastEditTime
		{
			set{ _lastedittime=value;}
			get{return _lastedittime;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tc_report_instance(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Name,ReportPropertyID,ReportTypeID,CreateBy,CreateTime,IsValid,LastEditTime ");
			strSql.Append(" FROM [tc_report_instance] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
					this.ReportPropertyID=ds.Tables[0].Rows[0]["ReportPropertyID"].ToString();
					this.ReportTypeID=ds.Tables[0].Rows[0]["ReportTypeID"].ToString();
					this.CreateBy=ds.Tables[0].Rows[0]["CreateBy"].ToString();
					this.CreateTime=ds.Tables[0].Rows[0]["CreateTime"].ToString();
				if(ds.Tables[0].Rows[0]["IsValid"]!=null && ds.Tables[0].Rows[0]["IsValid"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsValid"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsValid"].ToString().ToLower()=="true"))
					{
						this.IsValid=true;
					}
					else
					{
						this.IsValid=false;
					}
				}

				if(ds.Tables[0].Rows[0]["LastEditTime"]!=null && ds.Tables[0].Rows[0]["LastEditTime"].ToString()!="")
				{
					this.LastEditTime=DateTime.Parse(ds.Tables[0].Rows[0]["LastEditTime"].ToString());
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [tc_report_instance]");
			strSql.Append(" where ID=@ID ");

			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [tc_report_instance] (");
			strSql.Append("Name,ReportPropertyID,ReportTypeID,CreateBy,CreateTime,IsValid,LastEditTime)");
			strSql.Append(" values (");
			strSql.Append("@Name,@ReportPropertyID,@ReportTypeID,@CreateBy,@CreateTime,@IsValid,@LastEditTime)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Name", MySqlDbType.VarChar,500),
					new MySqlParameter("@ReportPropertyID", MySqlDbType.bigint,20),
					new MySqlParameter("@ReportTypeID", MySqlDbType.bigint,20),
					new MySqlParameter("@CreateBy", MySqlDbType.bigint,20),
					new MySqlParameter("@CreateTime", MySqlDbType.bigint,20),
					new MySqlParameter("@IsValid", MySqlDbType.Bit),
					new MySqlParameter("@LastEditTime", MySqlDbType.DateTime)};
			parameters[0].Value = Name;
			parameters[1].Value = ReportPropertyID;
			parameters[2].Value = ReportTypeID;
			parameters[3].Value = CreateBy;
			parameters[4].Value = CreateTime;
			parameters[5].Value = IsValid;
			parameters[6].Value = LastEditTime;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tc_report_instance] set ");
			strSql.Append("Name=@Name,");
			strSql.Append("ReportPropertyID=@ReportPropertyID,");
			strSql.Append("ReportTypeID=@ReportTypeID,");
			strSql.Append("CreateBy=@CreateBy,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("IsValid=@IsValid,");
			strSql.Append("LastEditTime=@LastEditTime");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Name", MySqlDbType.VarChar,500),
					new MySqlParameter("@ReportPropertyID", MySqlDbType.bigint,20),
					new MySqlParameter("@ReportTypeID", MySqlDbType.bigint,20),
					new MySqlParameter("@CreateBy", MySqlDbType.bigint,20),
					new MySqlParameter("@CreateTime", MySqlDbType.bigint,20),
					new MySqlParameter("@IsValid", MySqlDbType.Bit),
					new MySqlParameter("@LastEditTime", MySqlDbType.DateTime),
					new MySqlParameter("@ID", MySqlDbType.bigint,20)};
			parameters[0].Value = Name;
			parameters[1].Value = ReportPropertyID;
			parameters[2].Value = ReportTypeID;
			parameters[3].Value = CreateBy;
			parameters[4].Value = CreateTime;
			parameters[5].Value = IsValid;
			parameters[6].Value = LastEditTime;
			parameters[7].Value = ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [tc_report_instance] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public void GetModel(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Name,ReportPropertyID,ReportTypeID,CreateBy,CreateTime,IsValid,LastEditTime ");
			strSql.Append(" FROM [tc_report_instance] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=long.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ReportPropertyID"]!=null && ds.Tables[0].Rows[0]["ReportPropertyID"].ToString()!="")
				{
					this.ReportPropertyID=long.Parse(ds.Tables[0].Rows[0]["ReportPropertyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ReportTypeID"]!=null && ds.Tables[0].Rows[0]["ReportTypeID"].ToString()!="")
				{
					this.ReportTypeID=long.Parse(ds.Tables[0].Rows[0]["ReportTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateBy"]!=null && ds.Tables[0].Rows[0]["CreateBy"].ToString()!="")
				{
					this.CreateBy=long.Parse(ds.Tables[0].Rows[0]["CreateBy"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=long.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsValid"]!=null && ds.Tables[0].Rows[0]["IsValid"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsValid"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsValid"].ToString().ToLower()=="true"))
					{
						this.IsValid=true;
					}
					else
					{
						this.IsValid=false;
					}
				}
				if(ds.Tables[0].Rows[0]["LastEditTime"]!=null && ds.Tables[0].Rows[0]["LastEditTime"].ToString()!="")
				{
					this.LastEditTime=DateTime.Parse(ds.Tables[0].Rows[0]["LastEditTime"].ToString());
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [tc_report_instance] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}


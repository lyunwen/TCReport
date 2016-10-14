using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TCReport.DTO.DBModel
{
	/// <summary>
	/// 类tc_report_property。
	/// </summary>
	[Serializable]
	public partial class tc_report_property
	{
		public tc_report_property()
		{}
		#region Model
		private long _id;
		private string _name;
		private int _type;
		private string _regx;
		private DateTime _createtime;
		private DateTime _createby;
		private bool _isvalid= false;
		private long _reporttypeid;
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
		public int Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Regx
		{
			set{ _regx=value;}
			get{return _regx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateBy
		{
			set{ _createby=value;}
			get{return _createby;}
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
		public long ReportTypeID
		{
			set{ _reporttypeid=value;}
			get{return _reporttypeid;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tc_report_property(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Name,Type,Regx,CreateTime,CreateBy,IsValid,ReportTypeID ");
			strSql.Append(" FROM [tc_report_property] ");
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
				if(ds.Tables[0].Rows[0]["Type"]!=null && ds.Tables[0].Rows[0]["Type"].ToString()!="")
				{
					this.Type=int.Parse(ds.Tables[0].Rows[0]["Type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Regx"]!=null)
				{
					this.Regx=ds.Tables[0].Rows[0]["Regx"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateBy"]!=null && ds.Tables[0].Rows[0]["CreateBy"].ToString()!="")
				{
					this.CreateBy=DateTime.Parse(ds.Tables[0].Rows[0]["CreateBy"].ToString());
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

					this.ReportTypeID=ds.Tables[0].Rows[0]["ReportTypeID"].ToString();
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [tc_report_property]");
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
			strSql.Append("insert into [tc_report_property] (");
			strSql.Append("Name,Type,Regx,CreateTime,CreateBy,IsValid,ReportTypeID)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Type,@Regx,@CreateTime,@CreateBy,@IsValid,@ReportTypeID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Name", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.tinyint,4),
					new MySqlParameter("@Regx", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateBy", MySqlDbType.DateTime),
					new MySqlParameter("@IsValid", MySqlDbType.Bit),
					new MySqlParameter("@ReportTypeID", MySqlDbType.bigint,20)};
			parameters[0].Value = Name;
			parameters[1].Value = Type;
			parameters[2].Value = Regx;
			parameters[3].Value = CreateTime;
			parameters[4].Value = CreateBy;
			parameters[5].Value = IsValid;
			parameters[6].Value = ReportTypeID;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tc_report_property] set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Type=@Type,");
			strSql.Append("Regx=@Regx,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("CreateBy=@CreateBy,");
			strSql.Append("IsValid=@IsValid,");
			strSql.Append("ReportTypeID=@ReportTypeID");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Name", MySqlDbType.VarChar,50),
					new MySqlParameter("@Type", MySqlDbType.tinyint,4),
					new MySqlParameter("@Regx", MySqlDbType.VarChar,255),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateBy", MySqlDbType.DateTime),
					new MySqlParameter("@IsValid", MySqlDbType.Bit),
					new MySqlParameter("@ReportTypeID", MySqlDbType.bigint,20),
					new MySqlParameter("@ID", MySqlDbType.bigint,20)};
			parameters[0].Value = Name;
			parameters[1].Value = Type;
			parameters[2].Value = Regx;
			parameters[3].Value = CreateTime;
			parameters[4].Value = CreateBy;
			parameters[5].Value = IsValid;
			parameters[6].Value = ReportTypeID;
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
			strSql.Append("delete from [tc_report_property] ");
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
			strSql.Append("select ID,Name,Type,Regx,CreateTime,CreateBy,IsValid,ReportTypeID ");
			strSql.Append(" FROM [tc_report_property] ");
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
				if(ds.Tables[0].Rows[0]["Type"]!=null && ds.Tables[0].Rows[0]["Type"].ToString()!="")
				{
					this.Type=int.Parse(ds.Tables[0].Rows[0]["Type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Regx"]!=null )
				{
					this.Regx=ds.Tables[0].Rows[0]["Regx"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateBy"]!=null && ds.Tables[0].Rows[0]["CreateBy"].ToString()!="")
				{
					this.CreateBy=DateTime.Parse(ds.Tables[0].Rows[0]["CreateBy"].ToString());
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
				if(ds.Tables[0].Rows[0]["ReportTypeID"]!=null && ds.Tables[0].Rows[0]["ReportTypeID"].ToString()!="")
				{
					this.ReportTypeID=long.Parse(ds.Tables[0].Rows[0]["ReportTypeID"].ToString());
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
			strSql.Append(" FROM [tc_report_property] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}


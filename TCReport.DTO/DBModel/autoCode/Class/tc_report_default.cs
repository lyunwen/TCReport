using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TCReport.DTO.DBModel
{
	/// <summary>
	/// 类tc_report_default。
	/// </summary>
	[Serializable]
	public partial class tc_report_default
	{
		public tc_report_default()
		{}
		#region Model
		private long _id;
		private DateTime _createtime;
		private string _createby;
		private DateTime _begindate;
		private DateTime _enddate;
		private string _remark;
		private string _leaderremark;
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
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateBy
		{
			set{ _createby=value;}
			get{return _createby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BeginDate
		{
			set{ _begindate=value;}
			get{return _begindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LeaderRemark
		{
			set{ _leaderremark=value;}
			get{return _leaderremark;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tc_report_default(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CreateTime,CreateBy,BeginDate,EndDate,Remark,LeaderRemark ");
			strSql.Append(" FROM [tc_report_default] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateBy"]!=null)
				{
					this.CreateBy=ds.Tables[0].Rows[0]["CreateBy"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BeginDate"]!=null && ds.Tables[0].Rows[0]["BeginDate"].ToString()!="")
				{
					this.BeginDate=DateTime.Parse(ds.Tables[0].Rows[0]["BeginDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EndDate"]!=null && ds.Tables[0].Rows[0]["EndDate"].ToString()!="")
				{
					this.EndDate=DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LeaderRemark"]!=null)
				{
					this.LeaderRemark=ds.Tables[0].Rows[0]["LeaderRemark"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [tc_report_default]");
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
			strSql.Append("insert into [tc_report_default] (");
			strSql.Append("CreateTime,CreateBy,BeginDate,EndDate,Remark,LeaderRemark)");
			strSql.Append(" values (");
			strSql.Append("@CreateTime,@CreateBy,@BeginDate,@EndDate,@Remark,@LeaderRemark)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateBy", MySqlDbType.VarChar,255),
					new MySqlParameter("@BeginDate", MySqlDbType.date),
					new MySqlParameter("@EndDate", MySqlDbType.date),
					new MySqlParameter("@Remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@LeaderRemark", MySqlDbType.VarChar,500)};
			parameters[0].Value = CreateTime;
			parameters[1].Value = CreateBy;
			parameters[2].Value = BeginDate;
			parameters[3].Value = EndDate;
			parameters[4].Value = Remark;
			parameters[5].Value = LeaderRemark;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tc_report_default] set ");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("CreateBy=@CreateBy,");
			strSql.Append("BeginDate=@BeginDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("LeaderRemark=@LeaderRemark");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@CreateBy", MySqlDbType.VarChar,255),
					new MySqlParameter("@BeginDate", MySqlDbType.date),
					new MySqlParameter("@EndDate", MySqlDbType.date),
					new MySqlParameter("@Remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@LeaderRemark", MySqlDbType.VarChar,500),
					new MySqlParameter("@ID", MySqlDbType.bigint,20)};
			parameters[0].Value = CreateTime;
			parameters[1].Value = CreateBy;
			parameters[2].Value = BeginDate;
			parameters[3].Value = EndDate;
			parameters[4].Value = Remark;
			parameters[5].Value = LeaderRemark;
			parameters[6].Value = ID;

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
			strSql.Append("delete from [tc_report_default] ");
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
			strSql.Append("select ID,CreateTime,CreateBy,BeginDate,EndDate,Remark,LeaderRemark ");
			strSql.Append(" FROM [tc_report_default] ");
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
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateBy"]!=null )
				{
					this.CreateBy=ds.Tables[0].Rows[0]["CreateBy"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BeginDate"]!=null && ds.Tables[0].Rows[0]["BeginDate"].ToString()!="")
				{
					this.BeginDate=DateTime.Parse(ds.Tables[0].Rows[0]["BeginDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EndDate"]!=null && ds.Tables[0].Rows[0]["EndDate"].ToString()!="")
				{
					this.EndDate=DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LeaderRemark"]!=null )
				{
					this.LeaderRemark=ds.Tables[0].Rows[0]["LeaderRemark"].ToString();
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
			strSql.Append(" FROM [tc_report_default] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}


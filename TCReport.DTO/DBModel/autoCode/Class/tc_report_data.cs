using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TCReport.DTO.DBModel
{
	/// <summary>
	/// 类tc_report_data。
	/// </summary>
	[Serializable]
	public partial class tc_report_data
	{
		public tc_report_data()
		{}
		#region Model
		private long _id;
		private long _reportinstanceid;
		private long _reportpropertyid;
		private string _value;
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
		public long ReportInstanceID
		{
			set{ _reportinstanceid=value;}
			get{return _reportinstanceid;}
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
		public string Value
		{
			set{ _value=value;}
			get{return _value;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tc_report_data(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ReportInstanceID,ReportPropertyID,Value ");
			strSql.Append(" FROM [tc_report_data] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
					this.ReportInstanceID=ds.Tables[0].Rows[0]["ReportInstanceID"].ToString();
					this.ReportPropertyID=ds.Tables[0].Rows[0]["ReportPropertyID"].ToString();
				if(ds.Tables[0].Rows[0]["Value"]!=null)
				{
					this.Value=ds.Tables[0].Rows[0]["Value"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [tc_report_data]");
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
			strSql.Append("insert into [tc_report_data] (");
			strSql.Append("ReportInstanceID,ReportPropertyID,Value)");
			strSql.Append(" values (");
			strSql.Append("@ReportInstanceID,@ReportPropertyID,@Value)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ReportInstanceID", MySqlDbType.bigint,20),
					new MySqlParameter("@ReportPropertyID", MySqlDbType.bigint,20),
					new MySqlParameter("@Value", MySqlDbType.VarChar,2000)};
			parameters[0].Value = ReportInstanceID;
			parameters[1].Value = ReportPropertyID;
			parameters[2].Value = Value;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tc_report_data] set ");
			strSql.Append("ReportInstanceID=@ReportInstanceID,");
			strSql.Append("ReportPropertyID=@ReportPropertyID,");
			strSql.Append("Value=@Value");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ReportInstanceID", MySqlDbType.bigint,20),
					new MySqlParameter("@ReportPropertyID", MySqlDbType.bigint,20),
					new MySqlParameter("@Value", MySqlDbType.VarChar,2000),
					new MySqlParameter("@ID", MySqlDbType.bigint,20)};
			parameters[0].Value = ReportInstanceID;
			parameters[1].Value = ReportPropertyID;
			parameters[2].Value = Value;
			parameters[3].Value = ID;

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
			strSql.Append("delete from [tc_report_data] ");
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
			strSql.Append("select ID,ReportInstanceID,ReportPropertyID,Value ");
			strSql.Append(" FROM [tc_report_data] ");
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
				if(ds.Tables[0].Rows[0]["ReportInstanceID"]!=null && ds.Tables[0].Rows[0]["ReportInstanceID"].ToString()!="")
				{
					this.ReportInstanceID=long.Parse(ds.Tables[0].Rows[0]["ReportInstanceID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ReportPropertyID"]!=null && ds.Tables[0].Rows[0]["ReportPropertyID"].ToString()!="")
				{
					this.ReportPropertyID=long.Parse(ds.Tables[0].Rows[0]["ReportPropertyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Value"]!=null )
				{
					this.Value=ds.Tables[0].Rows[0]["Value"].ToString();
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
			strSql.Append(" FROM [tc_report_data] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}


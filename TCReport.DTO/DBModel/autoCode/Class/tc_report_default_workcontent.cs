using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TCReport.DTO.DBModel
{
	/// <summary>
	/// 类tc_report_default_workcontent。
	/// </summary>
	[Serializable]
	public partial class tc_report_default_workcontent
	{
		public tc_report_default_workcontent()
		{}
		#region Model
		private long _id;
		private long _report_defaultid;
		private string _content;
		private int _needday;
		private decimal _progress;
		private int _level;
		private int _state;
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
		public long Report_DefaultID
		{
			set{ _report_defaultid=value;}
			get{return _report_defaultid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NeedDay
		{
			set{ _needday=value;}
			get{return _needday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Progress
		{
			set{ _progress=value;}
			get{return _progress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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
		public tc_report_default_workcontent(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Report_DefaultID,Content,NeedDay,Progress,Level,State,Remark,LeaderRemark ");
			strSql.Append(" FROM [tc_report_default_workcontent] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
					this.Report_DefaultID=ds.Tables[0].Rows[0]["Report_DefaultID"].ToString();
				if(ds.Tables[0].Rows[0]["Content"]!=null)
				{
					this.Content=ds.Tables[0].Rows[0]["Content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NeedDay"]!=null && ds.Tables[0].Rows[0]["NeedDay"].ToString()!="")
				{
					this.NeedDay=int.Parse(ds.Tables[0].Rows[0]["NeedDay"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Progress"]!=null && ds.Tables[0].Rows[0]["Progress"].ToString()!="")
				{
					this.Progress=decimal.Parse(ds.Tables[0].Rows[0]["Progress"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Level"]!=null && ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					this.Level=int.Parse(ds.Tables[0].Rows[0]["Level"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					this.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
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
			strSql.Append("select count(1) from [tc_report_default_workcontent]");
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
			strSql.Append("insert into [tc_report_default_workcontent] (");
			strSql.Append("Report_DefaultID,Content,NeedDay,Progress,Level,State,Remark,LeaderRemark)");
			strSql.Append(" values (");
			strSql.Append("@Report_DefaultID,@Content,@NeedDay,@Progress,@Level,@State,@Remark,@LeaderRemark)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Report_DefaultID", MySqlDbType.bigint,20),
					new MySqlParameter("@Content", MySqlDbType.VarChar,255),
					new MySqlParameter("@NeedDay", MySqlDbType.tinyint,4),
					new MySqlParameter("@Progress", MySqlDbType.Decimal,3),
					new MySqlParameter("@Level", MySqlDbType.tinyint,4),
					new MySqlParameter("@State", MySqlDbType.tinyint,4),
					new MySqlParameter("@Remark", MySqlDbType.VarChar,2000),
					new MySqlParameter("@LeaderRemark", MySqlDbType.VarChar,2000)};
			parameters[0].Value = Report_DefaultID;
			parameters[1].Value = Content;
			parameters[2].Value = NeedDay;
			parameters[3].Value = Progress;
			parameters[4].Value = Level;
			parameters[5].Value = State;
			parameters[6].Value = Remark;
			parameters[7].Value = LeaderRemark;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [tc_report_default_workcontent] set ");
			strSql.Append("Report_DefaultID=@Report_DefaultID,");
			strSql.Append("Content=@Content,");
			strSql.Append("NeedDay=@NeedDay,");
			strSql.Append("Progress=@Progress,");
			strSql.Append("Level=@Level,");
			strSql.Append("State=@State,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("LeaderRemark=@LeaderRemark");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Report_DefaultID", MySqlDbType.bigint,20),
					new MySqlParameter("@Content", MySqlDbType.VarChar,255),
					new MySqlParameter("@NeedDay", MySqlDbType.tinyint,4),
					new MySqlParameter("@Progress", MySqlDbType.Decimal,3),
					new MySqlParameter("@Level", MySqlDbType.tinyint,4),
					new MySqlParameter("@State", MySqlDbType.tinyint,4),
					new MySqlParameter("@Remark", MySqlDbType.VarChar,2000),
					new MySqlParameter("@LeaderRemark", MySqlDbType.VarChar,2000),
					new MySqlParameter("@ID", MySqlDbType.bigint,20)};
			parameters[0].Value = Report_DefaultID;
			parameters[1].Value = Content;
			parameters[2].Value = NeedDay;
			parameters[3].Value = Progress;
			parameters[4].Value = Level;
			parameters[5].Value = State;
			parameters[6].Value = Remark;
			parameters[7].Value = LeaderRemark;
			parameters[8].Value = ID;

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
			strSql.Append("delete from [tc_report_default_workcontent] ");
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
			strSql.Append("select ID,Report_DefaultID,Content,NeedDay,Progress,Level,State,Remark,LeaderRemark ");
			strSql.Append(" FROM [tc_report_default_workcontent] ");
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
				if(ds.Tables[0].Rows[0]["Report_DefaultID"]!=null && ds.Tables[0].Rows[0]["Report_DefaultID"].ToString()!="")
				{
					this.Report_DefaultID=long.Parse(ds.Tables[0].Rows[0]["Report_DefaultID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Content"]!=null )
				{
					this.Content=ds.Tables[0].Rows[0]["Content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NeedDay"]!=null && ds.Tables[0].Rows[0]["NeedDay"].ToString()!="")
				{
					this.NeedDay=int.Parse(ds.Tables[0].Rows[0]["NeedDay"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Progress"]!=null && ds.Tables[0].Rows[0]["Progress"].ToString()!="")
				{
					this.Progress=decimal.Parse(ds.Tables[0].Rows[0]["Progress"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Level"]!=null && ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					this.Level=int.Parse(ds.Tables[0].Rows[0]["Level"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					this.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
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
			strSql.Append(" FROM [tc_report_default_workcontent] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}


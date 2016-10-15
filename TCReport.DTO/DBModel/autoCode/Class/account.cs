using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace TCReport.DTO.DBModel
{
	/// <summary>
	/// 类account。
	/// </summary>
	[Serializable]
	public partial class account
	{
		public account()
		{}
		#region Model
		private long _id;
		private long _role;
		private string _password;
		private bool _passwordverify= false;
		private string _username;
		private bool _usernameverify= false;
		private string _mobile;
		private bool _mobileverify= false;
		private string _wechatopenid;
		private bool _wechatopenidverify= false;
		private string _email;
		private bool _emailverify= false;
		private DateTime? _createtime;
		private string _resgiteridentify= "default";
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
		public long Role
		{
			set{ _role=value;}
			get{return _role;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PasswordVerify
		{
			set{ _passwordverify=value;}
			get{return _passwordverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool UserNameVerify
		{
			set{ _usernameverify=value;}
			get{return _usernameverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool MobileVerify
		{
			set{ _mobileverify=value;}
			get{return _mobileverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WechatOpenId
		{
			set{ _wechatopenid=value;}
			get{return _wechatopenid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool WechatOpenIdVerify
		{
			set{ _wechatopenidverify=value;}
			get{return _wechatopenidverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool EmailVerify
		{
			set{ _emailverify=value;}
			get{return _emailverify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ResgiterIdentify
		{
			set{ _resgiteridentify=value;}
			get{return _resgiteridentify;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public account(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Role,Password,PasswordVerify,UserName,UserNameVerify,Mobile,MobileVerify,WechatOpenId,WechatOpenIdVerify,Email,EmailVerify,CreateTime,ResgiterIdentify ");
			strSql.Append(" FROM [account] ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.bigint)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					this.ID=ds.Tables[0].Rows[0]["ID"].ToString();
					this.Role=ds.Tables[0].Rows[0]["Role"].ToString();
				if(ds.Tables[0].Rows[0]["Password"]!=null)
				{
					this.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PasswordVerify"]!=null && ds.Tables[0].Rows[0]["PasswordVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["PasswordVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["PasswordVerify"].ToString().ToLower()=="true"))
					{
						this.PasswordVerify=true;
					}
					else
					{
						this.PasswordVerify=false;
					}
				}

				if(ds.Tables[0].Rows[0]["UserName"]!=null)
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserNameVerify"]!=null && ds.Tables[0].Rows[0]["UserNameVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["UserNameVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["UserNameVerify"].ToString().ToLower()=="true"))
					{
						this.UserNameVerify=true;
					}
					else
					{
						this.UserNameVerify=false;
					}
				}

				if(ds.Tables[0].Rows[0]["Mobile"]!=null)
				{
					this.Mobile=ds.Tables[0].Rows[0]["Mobile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MobileVerify"]!=null && ds.Tables[0].Rows[0]["MobileVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["MobileVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["MobileVerify"].ToString().ToLower()=="true"))
					{
						this.MobileVerify=true;
					}
					else
					{
						this.MobileVerify=false;
					}
				}

				if(ds.Tables[0].Rows[0]["WechatOpenId"]!=null)
				{
					this.WechatOpenId=ds.Tables[0].Rows[0]["WechatOpenId"].ToString();
				}
				if(ds.Tables[0].Rows[0]["WechatOpenIdVerify"]!=null && ds.Tables[0].Rows[0]["WechatOpenIdVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["WechatOpenIdVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["WechatOpenIdVerify"].ToString().ToLower()=="true"))
					{
						this.WechatOpenIdVerify=true;
					}
					else
					{
						this.WechatOpenIdVerify=false;
					}
				}

				if(ds.Tables[0].Rows[0]["Email"]!=null)
				{
					this.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["EmailVerify"]!=null && ds.Tables[0].Rows[0]["EmailVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["EmailVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["EmailVerify"].ToString().ToLower()=="true"))
					{
						this.EmailVerify=true;
					}
					else
					{
						this.EmailVerify=false;
					}
				}

				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ResgiterIdentify"]!=null)
				{
					this.ResgiterIdentify=ds.Tables[0].Rows[0]["ResgiterIdentify"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [account]");
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
			strSql.Append("insert into [account] (");
			strSql.Append("Role,Password,PasswordVerify,UserName,UserNameVerify,Mobile,MobileVerify,WechatOpenId,WechatOpenIdVerify,Email,EmailVerify,CreateTime,ResgiterIdentify)");
			strSql.Append(" values (");
			strSql.Append("@Role,@Password,@PasswordVerify,@UserName,@UserNameVerify,@Mobile,@MobileVerify,@WechatOpenId,@WechatOpenIdVerify,@Email,@EmailVerify,@CreateTime,@ResgiterIdentify)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Role", MySqlDbType.bigint,20),
					new MySqlParameter("@Password", MySqlDbType.VarChar,50),
					new MySqlParameter("@PasswordVerify", MySqlDbType.Bit),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserNameVerify", MySqlDbType.Bit),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@MobileVerify", MySqlDbType.Bit),
					new MySqlParameter("@WechatOpenId", MySqlDbType.VarChar,50),
					new MySqlParameter("@WechatOpenIdVerify", MySqlDbType.Bit),
					new MySqlParameter("@Email", MySqlDbType.VarChar,50),
					new MySqlParameter("@EmailVerify", MySqlDbType.Bit),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@ResgiterIdentify", MySqlDbType.VarChar,50)};
			parameters[0].Value = Role;
			parameters[1].Value = Password;
			parameters[2].Value = PasswordVerify;
			parameters[3].Value = UserName;
			parameters[4].Value = UserNameVerify;
			parameters[5].Value = Mobile;
			parameters[6].Value = MobileVerify;
			parameters[7].Value = WechatOpenId;
			parameters[8].Value = WechatOpenIdVerify;
			parameters[9].Value = Email;
			parameters[10].Value = EmailVerify;
			parameters[11].Value = CreateTime;
			parameters[12].Value = ResgiterIdentify;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [account] set ");
			strSql.Append("Role=@Role,");
			strSql.Append("Password=@Password,");
			strSql.Append("PasswordVerify=@PasswordVerify,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserNameVerify=@UserNameVerify,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("MobileVerify=@MobileVerify,");
			strSql.Append("WechatOpenId=@WechatOpenId,");
			strSql.Append("WechatOpenIdVerify=@WechatOpenIdVerify,");
			strSql.Append("Email=@Email,");
			strSql.Append("EmailVerify=@EmailVerify,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("ResgiterIdentify=@ResgiterIdentify");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Role", MySqlDbType.bigint,20),
					new MySqlParameter("@Password", MySqlDbType.VarChar,50),
					new MySqlParameter("@PasswordVerify", MySqlDbType.Bit),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
					new MySqlParameter("@UserNameVerify", MySqlDbType.Bit),
					new MySqlParameter("@Mobile", MySqlDbType.VarChar,20),
					new MySqlParameter("@MobileVerify", MySqlDbType.Bit),
					new MySqlParameter("@WechatOpenId", MySqlDbType.VarChar,50),
					new MySqlParameter("@WechatOpenIdVerify", MySqlDbType.Bit),
					new MySqlParameter("@Email", MySqlDbType.VarChar,50),
					new MySqlParameter("@EmailVerify", MySqlDbType.Bit),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@ResgiterIdentify", MySqlDbType.VarChar,50),
					new MySqlParameter("@ID", MySqlDbType.bigint,20)};
			parameters[0].Value = Role;
			parameters[1].Value = Password;
			parameters[2].Value = PasswordVerify;
			parameters[3].Value = UserName;
			parameters[4].Value = UserNameVerify;
			parameters[5].Value = Mobile;
			parameters[6].Value = MobileVerify;
			parameters[7].Value = WechatOpenId;
			parameters[8].Value = WechatOpenIdVerify;
			parameters[9].Value = Email;
			parameters[10].Value = EmailVerify;
			parameters[11].Value = CreateTime;
			parameters[12].Value = ResgiterIdentify;
			parameters[13].Value = ID;

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
			strSql.Append("delete from [account] ");
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
			strSql.Append("select ID,Role,Password,PasswordVerify,UserName,UserNameVerify,Mobile,MobileVerify,WechatOpenId,WechatOpenIdVerify,Email,EmailVerify,CreateTime,ResgiterIdentify ");
			strSql.Append(" FROM [account] ");
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
				if(ds.Tables[0].Rows[0]["Role"]!=null && ds.Tables[0].Rows[0]["Role"].ToString()!="")
				{
					this.Role=long.Parse(ds.Tables[0].Rows[0]["Role"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Password"]!=null )
				{
					this.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PasswordVerify"]!=null && ds.Tables[0].Rows[0]["PasswordVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["PasswordVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["PasswordVerify"].ToString().ToLower()=="true"))
					{
						this.PasswordVerify=true;
					}
					else
					{
						this.PasswordVerify=false;
					}
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null )
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserNameVerify"]!=null && ds.Tables[0].Rows[0]["UserNameVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["UserNameVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["UserNameVerify"].ToString().ToLower()=="true"))
					{
						this.UserNameVerify=true;
					}
					else
					{
						this.UserNameVerify=false;
					}
				}
				if(ds.Tables[0].Rows[0]["Mobile"]!=null )
				{
					this.Mobile=ds.Tables[0].Rows[0]["Mobile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MobileVerify"]!=null && ds.Tables[0].Rows[0]["MobileVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["MobileVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["MobileVerify"].ToString().ToLower()=="true"))
					{
						this.MobileVerify=true;
					}
					else
					{
						this.MobileVerify=false;
					}
				}
				if(ds.Tables[0].Rows[0]["WechatOpenId"]!=null )
				{
					this.WechatOpenId=ds.Tables[0].Rows[0]["WechatOpenId"].ToString();
				}
				if(ds.Tables[0].Rows[0]["WechatOpenIdVerify"]!=null && ds.Tables[0].Rows[0]["WechatOpenIdVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["WechatOpenIdVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["WechatOpenIdVerify"].ToString().ToLower()=="true"))
					{
						this.WechatOpenIdVerify=true;
					}
					else
					{
						this.WechatOpenIdVerify=false;
					}
				}
				if(ds.Tables[0].Rows[0]["Email"]!=null )
				{
					this.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["EmailVerify"]!=null && ds.Tables[0].Rows[0]["EmailVerify"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["EmailVerify"].ToString()=="1")||(ds.Tables[0].Rows[0]["EmailVerify"].ToString().ToLower()=="true"))
					{
						this.EmailVerify=true;
					}
					else
					{
						this.EmailVerify=false;
					}
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ResgiterIdentify"]!=null )
				{
					this.ResgiterIdentify=ds.Tables[0].Rows[0]["ResgiterIdentify"].ToString();
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
			strSql.Append(" FROM [account] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}


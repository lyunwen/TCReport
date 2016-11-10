using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.AutoSql;
using TCReport.DB;
using TCReport.DB.DBModel;

namespace TCReport.Dal.Aspects.User
{
    public interface IAccountBaseAct
    {
        bool AccountExist(long id);
        db_account AccountGetByID(long id);
        db_account AccountGetUserName(string userName);

        int RegisterAccountByUserName(string userName, string password, string ResgiterIdentify);
        int RegisterAccountByMobile(string mobile, string password, string ResgiterIdentify);
        int RegisterAccountByEmail(string email, string password, string ResgiterIdentify);
        int RegisterAccountByWechatOpenId(string wechatOpenID,string ResgiterIdentify);
    }

    public class AccountBaseAct : IAccountBaseAct
    {
        bool IAccountBaseAct.AccountExist(long id)
        {
            string sqlCmd = AutoSqlBuilder<db_account>.BuildExistSql(string.Format("ID=@ID"));
            return MDBQuery.OpenAndQuery<int>(sqlCmd, new { ID = id }).Count() > 0;
        }

        db_account IAccountBaseAct.AccountGetByID(long id)
        {
            string sqlCmd = AutoSqlBuilder<db_account>.BuildGetSql("ID=@ID");
            return MDBQuery.OpenAndQuery<db_account>(sqlCmd, new { ID = id }).FirstOrDefault();
        }

        db_account IAccountBaseAct.AccountGetUserName(string userName)
        {
            string sqlCmd = AutoSqlBuilder<db_account>.BuildGetSql("UserName=@UserName AND UserNameVerify=1");
            return MDBQuery.OpenAndQuery<db_account>(sqlCmd, new { UserName = userName }).FirstOrDefault();
        }

        int IAccountBaseAct.RegisterAccountByEmail(string email, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<db_account>.BuildExistSql("Email=@Email AND EmailVerify=1"), new { Email = email });
            if (foo.Count() > 0)
            {
                return -1;
            }
            db_account account = new db_account
            {
                Role = 1,
                Password = password,
                PasswordVerify = false,
                UserName = null,
                UserNameVerify = false,
                Mobile = null,
                MobileVerify = false,
                WechatOpenId = null,
                WechatOpenIdVerify = false,
                Email = email,
                EmailVerify = true,
                CreateTime = DateTime.Now,
                ResgiterIdentify = ResgiterIdentify
            };
            string sqlCmd = AutoSqlBuilder<db_account>.BuildInsertSql();
            return MDBCommander.OpenAndExecute(sqlCmd, account); 
        }

        int IAccountBaseAct.RegisterAccountByMobile(string mobile, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<db_account>.BuildExistSql("Mobile=@Mobile AND MobileVerify=1"), new { Mobile = mobile });
            if (foo.Count() > 0)
            {
                return -1;
            }
            throw new NotImplementedException();
        }

        int IAccountBaseAct.RegisterAccountByUserName(string userName, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<db_account>.BuildExistSql("UserName=@UserName AND UserNameVerify=1"), new { UserName = userName });
            if (foo.Count() > 0)
            {
                return -1;
            }
            db_account account = new db_account
            {
                Role = 1,
                Password = password,
                PasswordVerify = true,
                UserName = userName,
                UserNameVerify = true,
                Mobile = null,
                MobileVerify = false,
                WechatOpenId = null,
                WechatOpenIdVerify = false,
                Email = null,
                EmailVerify = false,
                CreateTime = DateTime.Now,
                ResgiterIdentify = ResgiterIdentify
            };
            string sqlCmd = AutoSqlBuilder<db_account>.BuildInsertSql();
            return MDBCommander.OpenAndExecute(sqlCmd, account);
        }

        int IAccountBaseAct.RegisterAccountByWechatOpenId(string weChatOpenID, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<db_account>.BuildExistSql("WechatOpenId=@WechatOpenId AND WechatOpenIdVerify=1"), new { WechatOpenId = weChatOpenID });
            if (foo.Count() > 0)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
}
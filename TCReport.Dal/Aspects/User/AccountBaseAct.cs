using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.AutoSql;
using TCReport.DTO;
using TCReport.DTO.DBModel;

namespace TCReport.Dal.Aspects.User
{
    public interface IAccountBaseAct
    {
        bool AccountExist(long id);
        Account AccountGetByID(long id);
        Account AccountGetUserName(string userName);

        int RegisterAccountByUserName(string userName, string password, string ResgiterIdentify);
        int RegisterAccountByMobile(string mobile, string password, string ResgiterIdentify);
        int RegisterAccountByEmail(string email, string password, string ResgiterIdentify);
        int RegisterAccountByWechatOpenId(string wechatOpenID,string ResgiterIdentify);
    }

    public class AccountBaseAct : IAccountBaseAct
    {
        bool IAccountBaseAct.AccountExist(long id)
        {
            string sqlCmd = AutoSqlBuilder<Account>.BuildExistSql(string.Format("ID=@ID"));
            return MDBQuery.OpenAndQuery<int>(sqlCmd, new { ID = id }).Count() > 0;
        }

        Account IAccountBaseAct.AccountGetByID(long id)
        {
            string sqlCmd = AutoSqlBuilder<Account>.BuildGetSql("ID=@ID");
            return MDBQuery.OpenAndQuery<Account>(sqlCmd, new { ID = id }).FirstOrDefault();
        }

        Account IAccountBaseAct.AccountGetUserName(string userName)
        {
            string sqlCmd = AutoSqlBuilder<Account>.BuildGetSql("UserName=@UserName AND UserNameVerify=1");
            return MDBQuery.OpenAndQuery<Account>(sqlCmd, new { UserName = userName }).FirstOrDefault();
        }

        int IAccountBaseAct.RegisterAccountByEmail(string email, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<Account>.BuildExistSql("Email=@Email AND EmailVerify=1"), new { Email = email });
            if (foo.Count() > 0)
            {
                return -1;
            }
            Account account = new Account
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
            string sqlCmd = AutoSqlBuilder<Account>.BuildInsertSql();
            return MDBCommander.OpenAndExecute(sqlCmd, account); 
        }

        int IAccountBaseAct.RegisterAccountByMobile(string mobile, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<Account>.BuildExistSql("Mobile=@Mobile AND MobileVerify=1"), new { Mobile = mobile });
            if (foo.Count() > 0)
            {
                return -1;
            }
            throw new NotImplementedException();
        }

        int IAccountBaseAct.RegisterAccountByUserName(string userName, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<Account>.BuildExistSql("UserName=@UserName AND UserNameVerify=1"), new { UserName = userName });
            if (foo.Count() > 0)
            {
                return -1;
            }
            Account account = new Account
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
            string sqlCmd = AutoSqlBuilder<Account>.BuildInsertSql();
            return MDBCommander.OpenAndExecute(sqlCmd, account);
        }

        int IAccountBaseAct.RegisterAccountByWechatOpenId(string weChatOpenID, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSqlBuilder<Account>.BuildExistSql("WechatOpenId=@WechatOpenId AND WechatOpenIdVerify=1"), new { WechatOpenId = weChatOpenID });
            if (foo.Count() > 0)
            {
                return -1;
            }
            throw new NotImplementedException();
        }
    }
}
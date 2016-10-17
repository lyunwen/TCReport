using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }

    public class AccountBaseAct : IAccountBaseAct
    {
        bool IAccountBaseAct.AccountExist(long id)
        {
            string sqlCmd = AutoSql<Account>.ToExistSql(string.Format("ID=@ID"));
            return MDBQuery.OpenAndQuery<int>(sqlCmd, new { ID = id }).Count() > 0;
        }
        Account IAccountBaseAct.AccountGetByID(long id)
        {
            string sqlCmd = AutoSql<Account>.ToGetSql("ID=@ID");
            return MDBQuery.OpenAndQuery<Account>(sqlCmd, new { ID = id }).FirstOrDefault();
        }

        Account IAccountBaseAct.AccountGetUserName(string userName)
        {
            string sqlCmd = AutoSql<Account>.ToGetSql("UserName=@UserName");
            return MDBQuery.OpenAndQuery<Account>(sqlCmd, new { UserName = userName }).FirstOrDefault();
        }

        int IAccountBaseAct.RegisterAccountByUserName(string userName, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<object>(AutoSql<Account>.ToExistSql("UserName=@UserName AND UserNameVerify=1"), new { UserName = userName });
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
            string sqlCmd = AutoSql<Account>.ToInsertSql();
            return MDBCommander.OpenAndExecute(sqlCmd, account);
        }
    }
}

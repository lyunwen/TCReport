using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.DBModel;

namespace TCReport.Dal.Aspects.User
{
    public interface IAccountBaseAct
    {
        Account AccountGetByID(long id);
        Account AccountGetUserName(string userName);

        int RegisterAccountByUserName(string userName, string password, string ResgiterIdentify);

    }

    public class AccountBaseAct : IAccountBaseAct
    {
        Account IAccountBaseAct.AccountGetByID(long id)
        {
            string sqlCmd = @"SELECT * from account WHERE ID=@ID";
            return MDBQuery.OpenAndQuery<Account>(sqlCmd, new { ID = id }).FirstOrDefault();
        }

        Account IAccountBaseAct.AccountGetUserName(string userName)
        {
            string sqlCmd = @"SELECT * from account WHERE UserName=@UserName";
            return MDBQuery.OpenAndQuery<Account>(sqlCmd, new { UserName = userName }).FirstOrDefault();
        }

        int IAccountBaseAct.RegisterAccountByUserName(string userName, string password, string ResgiterIdentify)
        {
            var foo = MDBQuery.OpenAndQuery<int>("SELECT Id FROM account WHERE UserName=@UserName AND UserNameVerify=1", new { UserName = userName });
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
            string sqlCmd = @"INSERT INTO account (Role,Password,PasswordVerify,UserName,UserNameVerify,Mobile,MobileVerify,WechatOpenId,WechatOpenIdVerify,Email,EmailVerify,CreateTime,ResgiterIdentify ) 
                                        VALUES (@Role,@Password,@PasswordVerify,@UserName,@UserNameVerify,@Mobile,@MobileVerify,@WechatOpenId,@WechatOpenIdVerify,@Email,@EmailVerify,@CreateTime,@ResgiterIdentify)";
            return MDBCommander.OpenAndExecute(sqlCmd, account);
        }
    }
}

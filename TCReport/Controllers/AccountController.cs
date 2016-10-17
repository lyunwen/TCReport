using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Dal.Aspects.User;

namespace TCReport.Controllers
{
    public class AccountController : BaseController
    {
        readonly IAccountBaseAct _accountBaseAct;
        public AccountController(IAccountBaseAct accountBaseAct)
        {
            _accountBaseAct = accountBaseAct;
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            var foo = _accountBaseAct.AccountExist(1);
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(string userName, string password)
        {
            var account = _accountBaseAct.AccountGetUserName(userName);
            if (account == null)
            {
                return Json(new { msg = "用户名不存在", state = "false" });
            }
            else
            {
                if (account.Password == password)
                {
                    LoginUser = new TCReport_User
                    {
                        Id = account.ID,
                        Logon = DateTime.Now,
                        UserName = account.UserName,
                        Roles = account.Role
                    };
                    var cookie = Request.Cookies[Config.CookieConfig.SignInSuccessReturnUrl];
                    string returnUrl = null;
                    if (cookie != null)
                    {
                        returnUrl = cookie.Value;
                    }
                    return Json(new { state = "true", returnUrl = returnUrl });
                }
                else
                {
                    return Json(new { state = "false", msg = "用户名密码错误" });
                }
            }
        }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterByUserName(string userName, string password)
        {
            var account = _accountBaseAct.AccountGetUserName(userName);
            if (account == null)
            {
                int result = _accountBaseAct.RegisterAccountByUserName(userName, password, "PC");
                if (result > 0)
                {
                    return Json(new { state = "true" });
                }
                else
                {
                    return Json(new { state = "true", msg = "注册失败" });
                }
            }
            else
            {
                return Json(new { state = "false", msg = "用户名已存在" });
            }
        }

        public ActionResult SignOff()
        {
            LoginUser = null;
            return RedirectToAction("signin");
        }
    }
}
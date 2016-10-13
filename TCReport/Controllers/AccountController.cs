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
        public ActionResult Access()
        {
            return View();
        }
    }
}
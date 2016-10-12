using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Dal.Aspects.User;

namespace TCReport.Controllers
{
    public class HomeController : BaseController
    {
        readonly IAccountBaseAct _accountBaseAct;
        public HomeController(IAccountBaseAct accountBaseAct)
        {
            _accountBaseAct = accountBaseAct;
        } 
        public ActionResult Index()
        { 
            return View();
        }
    }
}
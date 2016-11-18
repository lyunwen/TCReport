using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Dal;
using TCReport.Dal.Aspects.Report;
using TCReport.Dal.Aspects.User;
using TCReport.Filters;

namespace TCReport.Controllers
{
    [TCReportAuthorizeAttribute]
    public class HomeController : BaseController
    {
        readonly IUserManager _userManager;
        readonly IReportBaseAct _reportBaseAct;
        public HomeController(IUserManager userManager, IReportBaseAct reportBaseAct)
        {
            _userManager = userManager;
            _reportBaseAct = reportBaseAct;
        }
        public ActionResult Index()
        {
            ViewBag.LoginUser = LoginUser;
            return View();
        }
        public ActionResult Test()
        {
            var t= _userManager.AccountGetByID(1);
            Dal.BOModel.Report_DefaultBO instance = new Dal.BOModel.Report_DefaultBO
            {
                BeginDate = DateTime.Now.Date,
                CreateBy = LoginUser.Id,
                CreateTime = DateTime.Now,
                EndDate = DateTime.Now,
                LeaderRemark = null,
                Remark = "remark"
            };
            _reportBaseAct.Report_Default_BOInsert(instance);
            return View();
        }
    }
}
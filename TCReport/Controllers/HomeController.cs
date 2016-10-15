using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Dal.Aspects.Report;
using TCReport.Dal.Aspects.User;

namespace TCReport.Controllers
{
    public class HomeController : BaseController
    {
        readonly IAccountBaseAct _accountBaseAct;
        readonly IReportBaseAct _reportBaseAct;
        public HomeController(IAccountBaseAct accountBaseAct, IReportBaseAct reportBaseAct)
        {
            _accountBaseAct = accountBaseAct;
            _reportBaseAct = reportBaseAct;
        }
        public ActionResult Index()
        { 
            return View();
        }
        public ActionResult Test()
        {
            var t=_accountBaseAct.AccountGetByID(1);
            DTO.BOModel.Report_DefaultBO instance = new DTO.BOModel.Report_DefaultBO
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
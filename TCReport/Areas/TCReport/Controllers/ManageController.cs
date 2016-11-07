using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Controllers;
using TCReport.Dal.Aspects.Report;
using TCReport.Dal.BOModel;
using TCReport.DTO.DBModel;

namespace TCReport.Areas.TCReport.Controllers
{
    [Filters.TCReportAuthorize]
    public class ManageController : BaseController
    {
        readonly IReportBaseAct _reportBaseAct;
        public ManageController(IReportBaseAct reportBaseAct)
        {
            _reportBaseAct = reportBaseAct;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add(Report_DefaultBO report, Report_Default_WorkContent[] workContents)
        {
            if (report != null)
            {
                report.CreateBy = LoginUser.Id;
                report.CreateTime = DateTime.Now;
                report.BeginDate = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
                report.EndDate = DateTime.Now.Date.AddDays(7-(int)DateTime.Now.DayOfWeek);
                _reportBaseAct.Report_Default_BOInsert(report);
            }
            return View();
        }
    }
    public class UserInfo
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}
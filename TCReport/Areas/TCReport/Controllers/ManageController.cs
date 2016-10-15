using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Controllers;

namespace TCReport.Areas.TCReport.Controllers
{
    public class ManageController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
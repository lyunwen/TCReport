using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCReport.Controllers;

namespace TCReport.Areas.User.Controllers
{
   // [Filters.TCReportAuthorize()]
    public class UserController : BaseController
    {
        // GET: User/User
        public ActionResult List()
        {
            return View();
        }

        #region partail
        public ActionResult _AddUser()
        {
            return PartialView();
        }
        #endregion
    }
}
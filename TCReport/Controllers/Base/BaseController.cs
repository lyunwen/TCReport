using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCReport.Controllers
{ 
    [Filters.TCReportAuthorizeAttribute]
    public abstract class BaseController : Controller
    {
        internal Controllers.TCReport_User LoginUser
        {
            get
            {
                return Session[Config.SessionConfig.TCReposrt_User] as Controllers.TCReport_User;
            }
             set
            {
                Session[Config.SessionConfig.TCReposrt_User] = value;
            }
        }
        /// <summary>
        /// 刷新当前登入用户信息
        /// </summary>
        internal void ReflashLoginUser()
        {
            ;
        }
    }
}
using System;
using System.Web;
using System.Web.Mvc;
using TCReport.Config;
using TCReport.Controllers;

namespace TCReport.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class TCReportAuthorizeAttribute : AuthorizeAttribute
    {
        public TCReportAuthorizeAttribute()
        {

        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            TCReport_User user = httpContext.Session[SessionConfig.TCReposrt_User] as TCReport_User;
            if (user == null)
            {
                httpContext.Response.Redirect("/Account/signin");
                httpContext.Response.End();
                return false;
            }
            else
            {
                return Common.UrlAuthorizehandler.Authorize(user.Id, httpContext.Request.Url.AbsolutePath);
            }
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ContentResult { Content = "Not Permit!" };
            // base.HandleUnauthorizedRequest(filterContext);
        }

        protected override HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            return base.OnCacheAuthorization(httpContext);
        }
    }
    public class UrlAuthorizeCommponent
    {
        public static bool UrlAuthorize(int userId, string url)
        {
            return false;
        }
    }
}

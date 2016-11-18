using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCReport.HttpModules
{
    public class UrlFinderHttpModule : IHttpModule
    {
        public void Dispose()
        {
            this.Dispose(true);////释放托管资源
            GC.SuppressFinalize(this);//请求系统不要调用指定对象的终结器. //该方法在对象头中设置一个位，系统在调用终结器时将检查这个位
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)//_isDisposed为false表示没有进行手动dispose
            {
                if (disposing)
                {
                    //清理托管资源
                }
                //清理非托管资源
            }
            _isDisposed = true;
        }
        private bool _isDisposed;


        public void Init(HttpApplication context)
        {
            context.AuthorizeRequest += Context_AuthorizeRequest;
        }

        private void Context_AuthorizeRequest(object sender, EventArgs e)
        { 
            HttpApplication ap = sender as HttpApplication;
            if (ap != null)
            {
                var url = string.Format(ap.Request.Url.Authority + "/staticHtml" + ap.Request.Url.PathAndQuery+".html");
                ap.Response.Redirect(url); 
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCReport.HttpModules;

namespace TCReport.App_Start
{
    public class PerApplicationStartAction
    {
        public static void UrlFilter()
        {
            Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UrlFinderHttpModule));
        }
    }
}
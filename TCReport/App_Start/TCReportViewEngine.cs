using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCReport.App_Start
{
    public class TCReportViewEngine : RazorViewEngine
    {
        public TCReportViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
            PartialViewLocationFormats = new[]
            {
                 "~/Views/{1}/{0}.cshtml",
                "~/Views/{1}/Partial/{0}.cshtml",
            };
            AreaViewLocationFormats = new[]
            {
                 "~/Areas/{2}/Views/{1}/{0}.cshtml"
            };
            AreaPartialViewLocationFormats = new[]
            {
                  "~/Areas/{2}/Views/{1}/Partial/{0}.cshtml"
            };
        }
        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return base.FindPartialView(controllerContext, partialViewName, useCache);
        }
        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }
    }
}
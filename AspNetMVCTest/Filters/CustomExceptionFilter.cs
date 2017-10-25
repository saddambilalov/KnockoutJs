using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace AspNetMVCTest.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            var exception = filterContext.Exception;
            Debug.WriteLine(exception.StackTrace, "Exception Filter Log");

            var controllerName = filterContext.RouteData.Values["controller"].ToString();
            var actionName = filterContext.RouteData.Values["action"].ToString();
            var model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml",
                MasterName = "~/Views/Shared/_Layout.cshtml",
                TempData = filterContext.Controller.TempData,
                ViewData = new ViewDataDictionary<HandleErrorInfo>(model) { { "message", exception.Message } }
            };
        }
    }
}
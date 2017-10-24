using System.Diagnostics;
using System.Web.Mvc;

namespace AspNetMVCTest.Filters
{
    public class CustomFilterAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //You may fetch data from database here 
            filterContext.Controller.ViewBag.GreetMesssage = "Hello Foo";
            base.OnResultExecuting(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = $"onactionexecuting controller:{controllerName} action:{actionName}";
            Debug.WriteLine(message, "Action Filter Log");
            base.OnActionExecuting(filterContext);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AspNetMVCTest.Filters;

namespace AspNetMVCTest.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 30, VaryByParam = "none", Location = OutputCacheLocation.Server)]
        [CustomActionFilter]
        [CustomExceptionFilter]
        public ActionResult Index()
        {
            //throw new Exception("Test");

            if (System.Web.HttpContext.Current.Cache["count"] == null)
            {
                var list = new List<string>();

                for (var i = 0; i < 5000000; i++)
                {
                    list.Add(i + "_new_" + i);
                }

                var count = list.Count(str => str.StartsWith("1"));

                System.Web.HttpContext.Current.Cache["count"] = count;
            }

            ViewBag.Count = System.Web.HttpContext.Current.Cache["count"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
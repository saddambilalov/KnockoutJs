using System;
using System.Web.Mvc;

namespace AspNetMVCTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new Exception("An erro occured when progress the request");

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
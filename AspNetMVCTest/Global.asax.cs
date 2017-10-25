﻿using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AspNetMVCTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

       //protected void Application_Error(object sender, EventArgs e)
       // {
       //     // Code that runs when an unhandled error occurs
       //     Exception objErr = Server.GetLastError().GetBaseException();
       //     string err = "Error in: " + Request.Url.ToString() +
       //                  ". Error Message:" + objErr.Message.ToString();

       // }
    }
}

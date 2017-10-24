using System.Web.Mvc;
using AspNetMVCTest.Filters;

namespace AspNetMVCTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomFilterAttribute());
        }
    }
}

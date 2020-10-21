using System.Web;
using System.Web.Mvc;

namespace _24HourAssignment_DavidandWes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

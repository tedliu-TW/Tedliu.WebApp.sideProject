using System.Web;
using System.Web.Mvc;

namespace Tedliu.WebApp.sideProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

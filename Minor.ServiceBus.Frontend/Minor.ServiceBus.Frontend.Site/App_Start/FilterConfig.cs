using System.Web;
using System.Web.Mvc;

namespace Minor.ServiceBus.Frontend.Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

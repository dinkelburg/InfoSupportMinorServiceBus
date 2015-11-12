using Minor.ServiceBus.Agent.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minor.ServiceBus.Frontend.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServiceFactory<IBSKlantBeheerService> factory = new ServiceFactory<IBSKlantBeheerService>("BSKlantbeheer");
            var proxy = factory.CreateAgent();

            proxy.FindKlanten();

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
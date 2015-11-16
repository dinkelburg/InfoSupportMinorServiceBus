using Minor.ServiceBus.Agent.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Minor.ServiceBus.Frontend.Site.Controllers
{
    public class KlantController : Controller
    {
        // GET: Klant
        public ActionResult Index()
        {
            ServiceFactory<IBSKlantBeheerService> factory = new ServiceFactory<IBSKlantBeheerService>("BSKlantbeheer");
            var proxy = factory.CreateAgent();
            var klant = proxy.FindKlanten();

            return View(klant.Klanten);
        }
    }
}
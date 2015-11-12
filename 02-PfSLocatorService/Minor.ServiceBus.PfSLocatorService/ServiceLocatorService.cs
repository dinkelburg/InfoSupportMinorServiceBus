using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Minor.ServiceBus.PfSLocatorService
{
    public class ServiceLocatorService : IServiceLocatorService
    {
        private static ServiceLocation[] _serviceLocations =
        {
            new ServiceLocation
            {
                name = "BSKlantbeheer",
                address = new Uri("http://localhost:30412/BSKlantbeheer/mex"),
                profile = "Development"
            }
        };

        public string FindMetadataEndpointAddress(string name, string profile)
        {
            return "http://localhost:30412/BSKlantbeheer/mex";
        }
    }
}

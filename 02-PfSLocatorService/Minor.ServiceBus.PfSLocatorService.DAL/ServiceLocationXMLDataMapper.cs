using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minor.ServiceBus.PfSLocatorService.DAL
{
    public class ServiceLocationXMLDataMapper : IServiceLocationDataMapper
    {
        public string FindMetadataEndpointAddress(string name, string profile)
        {
            return "http://localhost:30412/BSKlantbeheer/mex";
        }

        public string FindMetadataEndpointAddress(string name, string profile, decimal version)
        {
            return "http://localhost:30412/BSKlantbeheer/mex";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Minor.ServiceBus.Agent.Implementation
{
    public class WebServiceLocator<TContract> : IServiceLocator
    {
        private Uri _adress;
        private Binding _binding;

        public WebServiceLocator(string adress, string binding)
        {
            _adress = new Uri(adress);
            if(binding == "basicHttpBinding")
            {
                _binding = new BasicHttpBinding();
            } else
            {
                throw new Exception("No implementation found for binding: " + binding);
            }
            
        }

        public string FindMetadataEndpointAddress(string name, string profile)
        {
            using (var host = new ServiceHost(typeof(IServiceLocator)))
            {
                host.Open();
                host.AddServiceEndpoint(typeof(TContract), _binding, _adress);
                host.Close();
            }


        }

        public string FindMetadataEndpointAddress(string name, string profile, decimal version)
        {
            throw new NotImplementedException();
        }
    }
}

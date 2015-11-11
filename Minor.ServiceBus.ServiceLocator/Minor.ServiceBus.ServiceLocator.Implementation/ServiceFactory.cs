using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Minor.ServiceBus.ServiceLocator.Implementation
{
    class ServiceFactory<TContract>
    {
        private Dictionary<Uri, ChannelFactory<TContract>> _cache =
            new Dictionary<Uri, ChannelFactory<TContract>>();

        public TContract CreateFactory(Uri mexaddress)
        {
            ChannelFactory<TContract> factory =
                BuildFromUriOrGetFromCache(mexaddress);

            TContract proxy = factory.CreateChannel();
            return proxy;
        }

        private ChannelFactory<TContract> BuildFromUriOrGetFromCache(Uri address)
        {
            ChannelFactory<TContract> factory;
            if (!_cache.ContainsKey(address))   // if not in cache
            {
                factory = BuildFactory(address);// get it, and
                _cache.Add(address, factory);   // add it to the cache
            }
            else                                // else
            {
                factory = _cache[address];      // get it from the cache
            }
            return factory;
        }

        private static ChannelFactory<TContract> BuildFactory(Uri address)
        {
            var mexClient = new MetadataExchangeClient(address,
                            MetadataExchangeClientMode.MetadataExchange);
            MetadataSet metadataset = mexClient.GetMetadata();
            var importer = new WsdlImporter(metadataset);
            var endpoints = importer.ImportAllEndpoints();
            ServiceEndpoint endpoint = endpoints.First();

            var factory = new ChannelFactory<TContract>(endpoint.Binding, endpoint.Address);
            return factory;
        }
    }
}

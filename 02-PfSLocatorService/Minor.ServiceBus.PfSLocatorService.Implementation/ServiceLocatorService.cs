using Minor.ServiceBus.PfSLocatorService.Contract;
using Minor.ServiceBus.PfSLocatorService.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Minor.ServiceBus.PfSLocatorService.Implementation
{
    public class ServiceLocatorService : IServiceLocatorService
    {
        IServiceLocationDataMapper _datamapper;

        public ServiceLocatorService()
        {
            _datamapper = new ServiceLocationXMLDataMapper();
        }

        public ServiceLocatorService(IServiceLocationDataMapper datamapper)
        {
            _datamapper = datamapper;
        }

        public string FindMetadataEndpointAddress(Contract.DTO.ServiceLocation serviceLocation)
        {
            if (serviceLocation.Name == null || serviceLocation.Profile == null)
            {
                throw new ArgumentException("Name of Profile is null");
            }
            if (serviceLocation.Version == null)
            {
                return _datamapper.FindMetadataEndpointAddress(serviceLocation.Name, serviceLocation.Profile);
            }
            return _datamapper.FindMetadataEndpointAddress(serviceLocation.Name, serviceLocation.Profile, serviceLocation.Version);
        }
    }
}

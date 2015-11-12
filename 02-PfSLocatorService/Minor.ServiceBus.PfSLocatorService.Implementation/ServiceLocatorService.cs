using Minor.ServiceBus.PfSLocatorService.Contract;
using Minor.ServiceBus.PfSLocatorService.Contract.DTO;
using Minor.ServiceBus.PfSLocatorService.DAL;
using Minor.ServiceBus.PfSLocatorService.DAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Minor.ServiceBus.PfSLocatorService.Implementation
{
    public class ServiceLocatorService : Contract.IServiceLocatorService
    {
        private DAL.IServiceLocationDataMapper _datamapper;

        public ServiceLocatorService()
        {
            _datamapper = new ServiceLocationXMLDataMapper("./XML/locationData.xml");
        }

        public ServiceLocatorService(DAL.IServiceLocationDataMapper datamapper)
        {
            _datamapper = datamapper;
        }

        public string FindMetadataEndpointAddress(Contract.DTO.ServiceLocation serviceLocation)
        {
            if (serviceLocation.Name == null || 
                serviceLocation.Profile == null || 
                serviceLocation.Name == "" ||
                serviceLocation.Profile == "")
            {
                throw new FaultException<ServiceLocationServiceFault>(
                    new ServiceLocationServiceFault("Name or Profile is null"));
                //return "Name or Profile is null";
            }
            
            try
            {
                if (serviceLocation.Version == null)
                {
                    return _datamapper.FindMetadataEndpointAddress(serviceLocation.Name, serviceLocation.Profile);
                }
                return _datamapper.FindMetadataEndpointAddress(serviceLocation.Name, serviceLocation.Profile, serviceLocation.Version);
            }
            catch (MultipleRecordsFoundException ex)
            {
                throw new FaultException<ServiceLocationServiceFault>(
                    new ServiceLocationServiceFault(ex.Message));
                //return ex.Message;
            }
            catch (NoRecordsFoundException ex)
            {
                throw new FaultException<ServiceLocationServiceFault>(
                    new ServiceLocationServiceFault(ex.Message));
                //return ex.Message;
            }
            catch (VersionedRecordFoundException ex)
            {
                throw new FaultException<ServiceLocationServiceFault>(
                    new ServiceLocationServiceFault(ex.Message));
                //return ex.Message;
            }
        }
    }
}

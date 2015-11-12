using Minor.ServiceBus.PfSLocatorService.Contract.DTO;
using System.ServiceModel;

namespace Minor.ServiceBus.PfSLocatorService.Contract
{
    [ServiceContract]
    public interface IServiceLocatorService
    {
        [OperationContract]
        string FindMetadataEndpointAddress(ServiceLocation serviceLocation);
    }
}

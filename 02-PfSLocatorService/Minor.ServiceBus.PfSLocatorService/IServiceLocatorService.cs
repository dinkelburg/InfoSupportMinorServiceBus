using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Minor.ServiceBus.PfSLocatorService
{
    [ServiceContract]
    public interface IServiceLocatorService
    {
        [OperationContract]
        string FindMetadataEndpointAddress(string name, string profile);
    }
}

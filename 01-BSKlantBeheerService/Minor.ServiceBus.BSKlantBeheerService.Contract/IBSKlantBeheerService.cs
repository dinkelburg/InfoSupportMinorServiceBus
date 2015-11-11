using minorservicebusbsklantbeheer.v1.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Minor.ServiceBus.BSKlantBeheerService.Contract
{
    [ServiceContract(Namespace = "urn:minor:servicebus:bsklantbeheer:v1")]
    public interface IBSKlantBeheerService
    {
        [OperationContract]
        void FindKlanten();

        [OperationContract]
        FindKlantenResponseMessage FindKlantenBy();

        [OperationContract]
        void InsertCursusInstanties();
    }
}

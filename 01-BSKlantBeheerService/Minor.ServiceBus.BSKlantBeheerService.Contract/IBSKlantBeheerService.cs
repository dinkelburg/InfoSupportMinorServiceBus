using Minor.ServiceBus.BSKlantBeheer.V1.Messages;
using Minor.ServiceBus.BSKlantBeheer.V1.Schema;
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
        FindKlantenResponseMessage FindKlanten();

        [OperationContract]
        FindKlantenResponseMessage FindKlantenBy(KlantenSearchCriteria criteria);

        [OperationContract]
        void InsertCursusInstanties(Klant klant);
    }
}

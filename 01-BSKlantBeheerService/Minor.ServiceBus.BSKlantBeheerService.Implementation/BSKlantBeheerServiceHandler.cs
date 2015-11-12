using Minor.ServiceBus.BSKlantBeheerService.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minor.ServiceBus.BSKlantBeheer.V1.Messages;
using Minor.ServiceBus.BSKlantBeheer.V1.Schema;

namespace Minor.ServiceBus.BSKlantBeheerService.Implementation
{
    public class BSKlantBeheerServiceHandler : IBSKlantBeheerService
    {
        public FindKlantenResponseMessage FindKlanten()
        {
            throw new NotImplementedException();
        }

        public FindKlantenResponseMessage FindKlantenBy(KlantenSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public void InsertCursusInstanties(Klant klant)
        {
            throw new NotImplementedException();
        }
    }


}

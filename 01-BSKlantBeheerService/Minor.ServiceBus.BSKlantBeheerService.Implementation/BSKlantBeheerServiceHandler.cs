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
            return new FindKlantenResponseMessage() {
                Klanten = new KlantenCollection() 
                {
                    new Klant()
                    {
                        id = 1,
                        klantnummer = "Luben1",
                        voornaam = "Luben",
                        achternaam = "Dinkelman",
                        geboortedatum = new DateTime(2015, 11, 11).ToString(),
                        postcode = "1234AB",
                        straat = "Blackboy 112",
                        woonplaats = "Loenen"
                    }
                }
            };
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

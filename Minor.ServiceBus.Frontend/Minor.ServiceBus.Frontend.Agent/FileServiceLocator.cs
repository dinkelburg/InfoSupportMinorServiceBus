using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Minor.ServiceBus.Frontend.Agent
{
    class FileServiceLocator : IServiceLocator
    {

        public string FindMetadataEndpointAddress(string name, string profile)
        {
            //load xml file in
            //check with name, profile and version
            //return metadatAddress
            XmlSerializer s = new (typeOf(personen));
            presonen result = serializer.Deserialize(stream) as personen;

            throw new NotImplementedException();
        }

        public string FindMetadataEndpointAddress(string name, string profile, decimal version)
        {
            //load xml file in
            //check with name, profile and version
            //return metadatAddress

            throw new NotImplementedException();
        }
    }
}

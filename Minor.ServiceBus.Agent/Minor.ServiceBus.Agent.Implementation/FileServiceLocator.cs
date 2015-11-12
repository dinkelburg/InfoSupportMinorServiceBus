using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Minor.ServiceBus.Agent.Implementation
{
    public class FileServiceLocator : IServiceLocator
    {

        public string FindMetadataEndpointAddress(string name, string profile)
        {
            //load xml file in
            //check with name, profile and version
            //return metadatAddress

            var locationdata = new locationData();

            XmlSerializer s = new XmlSerializer(typeof(locationData));
            locationData result = s.Deserialize(stream) as personen;

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

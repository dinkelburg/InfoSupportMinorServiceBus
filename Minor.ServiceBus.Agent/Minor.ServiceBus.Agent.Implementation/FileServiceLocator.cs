using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using minor.servicebus.pfslocatorservice.schema;
using System.Web.Hosting;
using System.Web;

namespace Minor.ServiceBus.Agent.Implementation
{
    public class FileServiceLocator : IServiceLocator
    {
        private string _filePath;

        public FileServiceLocator(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                _filePath = filePath;
            } else
            {
                throw new FilePathNotDefinedException("File path is not defined.");
            }
        }

        public string FindMetadataEndpointAddress(string name, string profile)
        {
            return GetMetaDataEndPointAdress(name, profile);
        }

        public string FindMetadataEndpointAddress(string name, string profile, decimal version)
        {
            return GetMetaDataEndPointAdress(name, profile, version);
        }

        /// <summary>
        /// Get the metadata endpoint adress from the XML file. 
        /// </summary>
        /// <param name="name" type="string"></param>
        /// <param name="profile" type="string"></param>
        /// <param name="version" type="decimal?"></param>
        /// <returns></returns>
        private string GetMetaDataEndPointAdress(string name, string profile, decimal? version = null)
        {
            var data = LoadXMLFile<locationData>(); //get XML data from the XML file
            var serviceLocationList = new List<string>();
            foreach (var serviceLocation in data.serviceLocation)
            {
                if(version != null)
                {
                    if (serviceLocation.name == name &&
                        serviceLocation.profile == profile &&
                        serviceLocation.version == version)
                    {
                        serviceLocationList.Add(serviceLocation.metadataAddress);
                    }
                }
                else { 
                    if (serviceLocation.name == name &&
                        serviceLocation.profile == profile)
                    {
                        if(serviceLocation.version != null)
                        {
                            throw new VersionRecordFoundException("A record has been found with a version, you need to specify the version.");
                        }
                        serviceLocationList.Add(serviceLocation.metadataAddress);
                    }
                }
            }
            switch(serviceLocationList.Count())
            {
                case 0:
                    throw new ServiceLocationDoesntExistsException("The given service location doesn't exists inside of the given xml file.");
                case 1:
                    throw new MultipleRecordsFoundException("Multiple records has been found!");
            }

            return serviceLocationList[0];
        }

        /// <summary>
        /// Load the XML file for the given filePath.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns><T>object</returns>
        private T LoadXMLFile<T>() {
            string relativePath = _filePath;
            if (_filePath.StartsWith("~"))
            {
                relativePath = HostingEnvironment.MapPath(_filePath);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(locationData));
            using (StreamReader reader = new StreamReader(relativePath))
            {
                var data = serializer.Deserialize(reader);
                return (T)data;
            }
        }

    }
}

using Minor.ServiceBus.PfSLocatorService.DAL.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Hosting;

namespace Minor.ServiceBus.PfSLocatorService.DAL
{
    public class ServiceLocationXMLDataMapper : IServiceLocationDataMapper
    {
        private string _filePath;

        public ServiceLocationXMLDataMapper(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                _filePath = filePath;
            }
            else
            {
                throw new FilePathNotDefinedException("File path is not defined.");
            }
        }

        public string FindMetadataEndpointAddress(string name, string profile)
        {
            return GetMetaDataEndPointAdress(name, profile);
            //return "http://localhost:30412/BSKlantbeheer/mex";
        }

        public string FindMetadataEndpointAddress(string name, string profile, decimal? version)
        {
            //return "http://localhost:30412/BSKlantbeheer/mex";
            return GetMetaDataEndPointAdress(name, profile, version);
        }

        public string GetMetaDataEndPointAdress(string name, string profile, decimal? version = null)
        {
            var data = LoadXMLFile<locationData>();
            var serviceLocationList = new List<string>();
            foreach (var servicelocation in data.serviceLocation)
            {
                if (version != null)
                {
                    if (servicelocation.name == name && 
                        servicelocation.profile == profile &&
                        servicelocation.version == version)
                    {
                        serviceLocationList.Add(servicelocation.metadataAddress);
                    }
                } else if (servicelocation.name == name && servicelocation.profile == profile)
                {
                    if (servicelocation.version != null)
                    {
                        throw new VersionedRecordFoundException("The location service found has a version, so specify the version");
                }
                    serviceLocationList.Add(servicelocation.metadataAddress);
                }
            }
            switch (serviceLocationList.Count())
                {
                case 0:
                    throw new NoRecordsFoundException("No location services found");
                case 1:
                    return serviceLocationList.First();
                default:
                    throw new MultipleRecordsFoundException("Multiple location services found instead of one");
            }
        }

        public T LoadXMLFile<T>()
        {
            string relativePath = @"C:\TFS\LeviS\EsraRubenLevi\02-PfSLocatorService\Minor.ServiceBus.PfSLocatorService.DAL\XML\" + _filePath;

            string relativePath2 = @"C:\TFS\LeviS\EsraRubenLevi\02-PfSLocatorService\Minor.ServiceBus.PfSLocatorService.DAL\XML\" + _filePath;
            string path = MakeAbsolutePath(_filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(locationData));
            using (StreamReader reader = new StreamReader(path))
            {
                var data = serializer.Deserialize(reader);
                return (T)data;
            }
        }

        private string MakeAbsolutePath(string relativePath)
        {
            string defaultPath = @"..\..\Minor.ServiceBus.PfSLocatorService.DAL\";
            string path = null;

            if (HttpContext.Current != null)
            {
                path = HttpContext.Current.Server.MapPath(relativePath);
            }
            else
            {
                string executionFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).Name;
                if (executionFolder == "Debug" || executionFolder == "Release")
                {
                    defaultPath = Path.Combine(@"..\", defaultPath);
                }
                path = Path.Combine(Directory.GetCurrentDirectory(), defaultPath, relativePath);
            }

            return path;
        }
    }
}

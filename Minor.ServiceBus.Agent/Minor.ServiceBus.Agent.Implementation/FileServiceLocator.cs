﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using minor.servicebus.pfslocatorservice.schema;

namespace Minor.ServiceBus.Agent.Implementation
{
    public class FileServiceLocator : IServiceLocatorService
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

        public string FindMetadataEndpointAddress(ServiceLocation serviceLocation)
        {
            return GetMetaDataEndPointAdress(serviceLocation.Name, serviceLocation.Profile, serviceLocation.Version);
        }

        public string GetMetaDataEndPointAdress(string name, string profile, decimal? version = null)
        {
            var data = LoadXMLFile<locationData>();
            foreach (var servicelocation in data.serviceLocation)
            {
                if(version != null)
                {
                    if (servicelocation.name == name 
                        && servicelocation.profile == profile
                        && servicelocation.version == version)
                    {
                        return servicelocation.metadataAddress;
                    }
                }
                if (servicelocation.name == name && servicelocation.profile == profile)
                {
                    return servicelocation.metadataAddress;
                }
            }
            throw new ServiceLocationDoesntExistsException("The given service location doesn't exists inside of the given xml file.");
        }

        public T LoadXMLFile<T>() {
            XmlSerializer serializer = new XmlSerializer(typeof(locationData));
            using (StreamReader reader = new StreamReader(_filePath))
            {
                var data = serializer.Deserialize(reader);
                return (T)data;
            }
        }

    }
}

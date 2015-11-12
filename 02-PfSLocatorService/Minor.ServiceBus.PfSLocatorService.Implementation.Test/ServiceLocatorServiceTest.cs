using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minor.ServiceBus.PfSLocatorService.Contract.DTO;
using Moq;
using Minor.ServiceBus.PfSLocatorService.DAL;
using System.ServiceModel;

namespace Minor.ServiceBus.PfSLocatorService.Implementation.Test
{
    [TestClass]
    public class ServiceLocatorServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(FaultException<ServiceLocationServiceFault>))]
        public void FindMetadataEndpointAddress_NoName()
        {
            // Arrange
            string name = null;
            string profile = "Development";
            decimal? version = 1.0m;
            ServiceLocation serviceLocation = new ServiceLocation
            {
                Name = name,
                Profile = profile,
                Version = version
            };

            var mock = new Mock<IServiceLocationDataMapper>(MockBehavior.Strict);
            
            var target = new ServiceLocatorService(mock.Object);

            // Act
            var result = target.FindMetadataEndpointAddress(serviceLocation);

            // Assert
            //Exception thrown
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ServiceLocationServiceFault>))]
        public void FindMetadataEndpointAddress_NoProfile()
        {
            // Arrange
            string name = "BSKlantBeheer";
            string profile = null;
            decimal? version = 1.0m;
            ServiceLocation serviceLocation = new ServiceLocation
            {
                Name = name,
                Profile = profile,
                Version = version
            };

            var mock = new Mock<IServiceLocationDataMapper>(MockBehavior.Strict);

            var target = new ServiceLocatorService(mock.Object);

            // Act
            var result = target.FindMetadataEndpointAddress(serviceLocation);

            // Assert
            //Exception thrown
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ServiceLocationServiceFault>))]
        public void FindMetadataEndpointAddress_EmptyName()
        {
            // Arrange
            string name = "";
            string profile = "Development";
            decimal? version = 1.0m;
            ServiceLocation serviceLocation = new ServiceLocation
            {
                Name = name,
                Profile = profile,
                Version = version
            };

            var mock = new Mock<IServiceLocationDataMapper>(MockBehavior.Strict);

            var target = new ServiceLocatorService(mock.Object);

            // Act
            var result = target.FindMetadataEndpointAddress(serviceLocation);

            // Assert
            //Exception thrown
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ServiceLocationServiceFault>))]
        public void FindMetadataEndpointAddress_EmptyProfile()
        {
            // Arrange
            string name = "BSBeheerService";
            string profile = "";
            decimal? version = 1.0m;
            ServiceLocation serviceLocation = new ServiceLocation
            {
                Name = name,
                Profile = profile,
                Version = version
            };

            var mock = new Mock<IServiceLocationDataMapper>(MockBehavior.Strict);

            var target = new ServiceLocatorService(mock.Object);

            // Act
            var result = target.FindMetadataEndpointAddress(serviceLocation);

            // Assert
            //Exception thrown
        }
    }
}

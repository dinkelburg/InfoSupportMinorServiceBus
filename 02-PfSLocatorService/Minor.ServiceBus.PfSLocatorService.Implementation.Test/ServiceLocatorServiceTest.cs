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
        [ExpectedException(typeof(FaultException<FunctionalErrorList>))]
        public void FindMetaEA_NoName()
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

            var mock = new Mock<IServiceLocationDataMapper>();
            var target = new ServiceLocatorService(mock.Object);

            // Act
            var result = target.FindMetadataEndpointAddress(serviceLocation);

            // Assert
            //Exception thrown
        }

        [TestMethod]
        public void FindMetaEA_NoName_ExcMessage()
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

            var mock = new Mock<IServiceLocationDataMapper>();
            var target = new ServiceLocatorService(mock.Object);

            // Act
            try
            {
                var result = target.FindMetadataEndpointAddress(serviceLocation);
            }
            catch (FaultException<FunctionalErrorList> ex)
            {
                // Assert
                Assert.AreEqual(1, ex.Detail);
                Assert.AreEqual("Name or Profile is null", ex.Detail.Details[0].Message);   
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<FunctionalErrorList>))]
        public void FindMetaEA_NoProfile()
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
        public void FindMetaEA_NoProfile_ExcMessage()
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
            try
            {
                var result = target.FindMetadataEndpointAddress(serviceLocation);
            }
            catch (FunctionalException ex)
            {
                // Assert
                Assert.AreEqual(1, ex.Errors.Details.Length);
                Assert.AreEqual("Name or Profile is null", ex.Errors.Details[0].Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<FunctionalErrorList>))]
        public void FindMetaEA_EmptyName()
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
        public void FindMetaEA_EmptyName_ExcMessage()
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
            try
            {
                var result = target.FindMetadataEndpointAddress(serviceLocation);
            }
            catch (FaultException<FunctionalErrorList> ex)
            {
                // Assert
                Assert.AreEqual(1, ex.Detail.Details.Length);
                Assert.AreEqual("Name or Profile is null", ex.Detail.Details[0].Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<FunctionalErrorList>))]
        public void FindMetaEA_EmptyProfile()
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

        [TestMethod]
        public void FindMetaEA_EmptyProfile_ExcMessage()
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
            try
            {
                var result = target.FindMetadataEndpointAddress(serviceLocation);
            }
            catch (FaultException<FunctionalErrorList> ex)
            {
                // Assert
                Assert.AreEqual(1, ex.Detail.Details.Length);
                Assert.AreEqual("Name or Profile is null", ex.Detail.Details[0].Message);
            }
        }
    }
}

using Xunit;
using Moq;
using eGovWebAPI.Models;
using eGovWebAPI.Interfaces;
using eGovWebAPI.Services;

namespace eGovWebAPI.Tests
{
    public class CitizenServiceTests
    {
        [Fact]
        public void RegisterCitizen_AddsCitizenSuccessfully()
        {
            //Arrange
            var mockTaxPayer = new Mock<ITaxPayer>();
            var mockDriver = new Mock<IDriver>();
            var mockAddressFactory = new Mock<IAddressFactory>();

            var service = new CitizenService(
                mockTaxPayer.Object,
                mockDriver.Object,
                mockAddressFactory.Object
            );

            //Act
            var result = service.RegisterCitizen("Olesia", 18, true, true, true, "USA", "NY", "Main St");
            var citizen = service.GetCitizen("Olesia");

            //Assert
            Assert.NotNull(citizen);
            Assert.Equal("Olesia", citizen.Name);
            Assert.Equal(18, citizen.Age);
            Assert.NotNull(citizen.TaxPayer);
            Assert.NotNull(citizen.Driver);
        }


        [Fact]
        public void RegisterCitizen_ShouldReturnError_WhenCitizenAlreadyExisst()
        {
            // Arrange
            var mockTaxPayer = new Mock<ITaxPayer>();
            var mockDriver = new Mock<IDriver>();
            var mockAddressFactory = new Mock<IAddressFactory>();

            var service = new CitizenService(
                mockTaxPayer.Object,
                mockDriver.Object,
                mockAddressFactory.Object
            );
        
            var result1 = service.RegisterCitizen("Olena", 30, true, false, false);

            // Act
            var result2 = service.RegisterCitizen("Olena", 30, true, false, false);
        
            // Assert
            Assert.Equal("Citizen Olena is already registered", result2);
        }

        [Fact]
        public void RegisterCitizen_ShouldReturnNull_WhenAddressIsNull()
        {
            //Arrange 
            var mockTaxPayer = new Mock<ITaxPayer>();
            var mockDriver = new Mock<IDriver>();
            var mockAddressFactory = new Mock<IAddressFactory>();

            var service = new CitizenService(
                mockTaxPayer.Object,
                mockDriver.Object,
                mockAddressFactory.Object
            );

            //Act
            var result = service.RegisterCitizen("Test", 18, true, true, false);
            var citizen = service.GetCitizen("Test");

            //Assert
            Assert.Null(citizen.Address);
        }
        
    }
}

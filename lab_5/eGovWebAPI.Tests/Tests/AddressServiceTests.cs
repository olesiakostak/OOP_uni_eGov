using Moq;
using eGovWebAPI.Interfaces;
using eGovWebAPI.Services;
using eGovWebAPI.Models;
using Xunit;

namespace eGovWebAPI.Tests.Tests
{
    public class AddressServiceTests
    {
        [Fact]
        public void CreateAddress_AddsAddressSuccessfully()
        {
            //Arrange
            var mockAddressFactory = new Mock<IAddressFactory>();
            var mockTaxPayer = new Mock<ITaxPayer>();
            var mockDriver = new Mock<IDriver>();
            
            var citizenService = new CitizenService(
                mockTaxPayer.Object,
                mockDriver.Object,
                mockAddressFactory.Object
            );

            mockAddressFactory.Setup(f => f.Create("USA", "NY", "Main St")).Returns(new Address("USA", "NY", "Main St"));

            var service = new AddressService(mockAddressFactory.Object, citizenService);

            //Act
            var result = service.CreateAddress("USA", "NY", "Main St");

            //Assert
            Assert.NotNull(result);
            Assert.Equal("USA", result.Country);
            Assert.Equal("NY", result.City);
            Assert.Equal("Main St", result.Street);
        }

        // [Fact]
        // public void ChangeCitizenAddress_UpdatesCitizenAddressSuccessfully()
        // {
        //     //arrange
        //     var mockAddressFactory = new Mock<IAddressFactory>();
        //     var mockTaxPayer = new Mock<ITaxPayer>();
        //     var mockDriver = new Mock<IDriver>();

        //     var citizenService = new CitizenService(
        //         mockTaxPayer.Object,
        //         mockDriver.Object,
        //         mockAddressFactory.Object
        //     );

        //     citizenService.RegisterCitizen("Olesia", 18, true, true, true, "USA", "NY", "Main St");

        //     mockAddressFactory.Setup(f => f.Create("USA", "NY", "Main St")).Returns(new Address("USA", "NY", "Main St"));

        //     var service = new AddressService(mockAddressFactory.Object, citizenService);

        //     //act
        //     var result = service.ChangeAddress("Olesia", "Canada", "Toronto", "Queen St");
        //     var citizen = citizenService.GetCitizen("Olesia");

        //     // Assert
        //     Assert.NotNull(citizen);
        //     Assert.NotNull(citizen.Address);
        //     Assert.Equal("Canada", citizen.Address.Country);
        //     Assert.Equal("Toronto", citizen.Address.City);
        //     Assert.Equal("Queen St", citizen.Address.Street);
        //     Assert.Contains("successfully changed", result, StringComparison.OrdinalIgnoreCase);
        // }
    }
}
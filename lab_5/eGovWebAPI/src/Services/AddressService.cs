using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Services
{
    public class AddressService
    {
        private readonly IAddressFactory _addressFactory;
        private readonly CitizenService _citizenService;

        public AddressService(IAddressFactory addressFactory, CitizenService citizenService)
        {
            _addressFactory = addressFactory;
            _citizenService = citizenService;
        }

        public IAddress CreateAddress(string country, string city, string street)
        {
            return _addressFactory.Create(country, city, street);
        }

        public IAddress GetAddress(string name)
        {
            var citizen = _citizenService.GetCitizen(name);
            if (citizen == null || citizen.Address == null)
            {
                throw new InvalidOperationException("Citizen or address was not found.");
            }
            return citizen.Address;
        }

        public string ChangeAddress(string name, string country, string city, string street)
        {
            var citizen = _citizenService.GetCitizen(name);
            if (citizen == null || citizen.Address == null)
            {
                return "Citizen or address was not found";
            }
            var newAddress = _addressFactory.Create(country, city, street);
            citizen.SetAddress(newAddress);

            return "Address was changed successfully.";
        }
    }
}
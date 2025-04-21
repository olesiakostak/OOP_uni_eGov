using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Services
{
    public class AddressService
    {
        private readonly IAddressFactory AddressFactory;
        private readonly CitizenService Citizens;
        public AddressService (IAddressFactory _addressFactory, CitizenService _citizens)
        {
            AddressFactory = _addressFactory;
            Citizens = _citizens;
        }
        public IAddress CreateAddress(string _country, string _city, string _street)
        {
            return AddressFactory.Create(_country, _city, _street);
        }
        public IAddress GetAddress (string name)
        {
            var citizen = Citizens.GetCitizen(name);
            if (citizen == null || citizen.Address == null)
            {
                throw new InvalidOperationException("Citizen or address was not found.");
            }
            return citizen.Address;
        }

        public string ChangeAddress(string _name, string _country, string _city, string _street)
        {
            var citizen = Citizens.GetCitizen(_name);
            if (citizen == null || citizen.Address == null)
            {
                return "Citizen or address was not found";
            }
            var newAddress = AddressFactory.Create(_country, _city, _street);
            citizen.SetAddress(newAddress);
            
            return "Address was changed successfully.";
        }
    }
}
using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Services
{
    public class AddressService
    {
        private readonly IAddressFactory AddressFactory;

        public AddressService (IAddressFactory _addressFactory)
        {
            AddressFactory = _addressFactory;
        }
        public IAddress CreateAddress(string _country, string _city, string _street)
        {
            return AddressFactory.Create(_country, _city, _street);
        }
        public IAddress GetAddress (IAddress address)
        {
            return address;
        }
    }
}
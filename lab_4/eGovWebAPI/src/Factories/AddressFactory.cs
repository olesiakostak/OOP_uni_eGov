using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Factories
{
    public class AddressFactory: IAddressFactory
    {
        public IAddress Create(string _country, string _city, string _street)
        {
            return new Address(_country, _city, _street);
        }
    }
}
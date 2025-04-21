using eGovWebAPI.Models;

namespace eGovWebAPI.Interfaces
{
    public interface IAddressService
    {
        IAddress CreateAddress (string _country, string _city, string _street);
        IAddress GetAddress (IAddress address);
        
    }
}
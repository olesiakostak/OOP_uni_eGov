using eGovWebAPI.Models;

namespace eGovWebAPI.Interfaces
{
    public interface IAddressService
    {
        IAddress CreateAddress (string _country, string _city, string _street);
        IAddress GetAddress (string _name);
        string ChangeAddress(string _name, string _country, string _city, string _street);
    }
}
using eGovWebAPI.Models;

namespace eGovWebAPI.Interfaces
{
    public interface IAddress
    {
        string Country { get; }
        string City { get; }
        string Street { get; }
    }
}
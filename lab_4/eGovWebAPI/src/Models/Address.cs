using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Models
{
    public class Address: IAddress
    {
        public string Country { get; private set; }
        public string City { get; private set;}
        public string Street {get; private set;}

        public Address(string _country, string _city, string _street)
        {
            Country = _country;
            City = _city;
            Street = _street;
        }
    }
}
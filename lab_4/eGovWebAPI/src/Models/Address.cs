using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Models
{
    public class Address : IAddress
    {
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }

        public Address(string country, string city, string street)
        {
            Country = country;
            City = city;
            Street = street;
        }
    }
}
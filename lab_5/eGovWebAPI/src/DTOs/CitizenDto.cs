using eGovWebAPI.Models;

namespace eGovWebAPI.DTOs
{
    public class CitizenDto
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public bool TaxPayer { get; set; }
        public bool Driver { get; set; }
        public AddressDto? Address { get; set; }
    }
}
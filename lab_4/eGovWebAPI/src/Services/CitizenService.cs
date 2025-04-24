using eGovWebAPI.Models;
using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Services
{
    public class CitizenService
    {
        private static readonly Dictionary<string, Citizen> _citizens = new();
        private readonly ITaxPayer _taxPayer;
        private readonly IDriver _driver;
        private readonly IAddressFactory _addressFactory;

        public CitizenService(ITaxPayer taxPayer, IDriver driver, IAddressFactory addressFactory)
        {
            _taxPayer = taxPayer;
            _driver = driver;
            _addressFactory = addressFactory;
        }

        public string RegisterCitizen(string name, 
                                      int age, 
                                      bool isTaxPayer, 
                                      bool isDriver, 
                                      bool hasAddress,
                                      string? country = null, 
                                      string? city = null, 
                                      string? street = null)
        {
            if (_citizens.ContainsKey(name))
            {
                return $"Citizen {name} is already registered";
            }

            var taxPayer = isTaxPayer ? _taxPayer : null;
            var driver = isDriver ? _driver : null;
            IAddress? address = null;

            if (hasAddress && !string.IsNullOrWhiteSpace(country) && !string.IsNullOrWhiteSpace(city) && !string.IsNullOrWhiteSpace(street))
            {
                address = _addressFactory.Create(country, city, street);
            }

            var citizen = new Citizen(name, age, taxPayer, driver, address);

            _citizens.Add(name, citizen);

            return $"Citizen {name} was successfully registered!";
        }

        public Citizen? GetCitizen(string name)
        {
            return _citizens.TryGetValue(name, out var citizen) ? citizen : null;
        }

        public string ShowInfo(string name)
        {
            var citizen = GetCitizen(name);

            if (citizen == null)
            {
                return "Citizen with this name was not found.";
            }
            
            var taxPayer = citizen.IsTaxPayer() ? "Yes" : "No";
            var driver = citizen.IsDriver() ? "Yes" : "No";
            var address = citizen.HasAddress() ? $"Country: {citizen.Address!.Country}, City: {citizen.Address.City}, Street: {citizen.Address.Street}"
                : "Address is not entered";
            string info = $"Citizen name: {citizen.Name} \nAge: {citizen.Age} \nTaxPayer: {taxPayer} \nDriver: {driver} \nAddress: {address}";
            return info;
        }
    }
}
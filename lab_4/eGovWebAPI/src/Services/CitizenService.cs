using eGovWebAPI.Models;
using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Services
{
    public class CitizenService
    {
        private static readonly Dictionary<string, Citizen> Citizens = new();
        private readonly ITaxPayer TaxPayer;
        private readonly IDriver Driver;
        private readonly IAddressFactory AddressFactory;


        public CitizenService (ITaxPayer _taxPayer, IDriver _driver, IAddressFactory _addressFactory)
        {
            TaxPayer = _taxPayer;
            Driver = _driver;
            AddressFactory = _addressFactory;
        }

        public string RegisterCitizen  (string _name, 
                                        int _age, 
                                        bool _isTaxPayer, 
                                        bool _isDriver, 
                                        bool _hasAddress,
                                        string? _country = null, 
                                        string? _city = null, 
                                        string? _street = null)
        {
            if (Citizens.ContainsKey(_name))
            {
                return $"Citizen {_name} is already registered";
            }

            var taxPayer = _isTaxPayer ? TaxPayer: null;
            var driver = _isDriver ? Driver: null;
            IAddress? address = null;

            if (_hasAddress && !string.IsNullOrWhiteSpace(_country) && !string.IsNullOrWhiteSpace(_city) && !string.IsNullOrWhiteSpace(_street))
            {
                address = AddressFactory.Create(_country, _city, _street);
            }

            var citizen = new Citizen(_name, _age, taxPayer, driver, address);

            Citizens.Add(_name, citizen);

            return $"Citizen {_name} was successfully registered!";
        }

        public Citizen? GetCitizen(string _name)
        {
            return Citizens.TryGetValue(_name, out var citizen) ? citizen : null;
        }

        public string ShowInfo(string _name)
        {
            var citizen = GetCitizen(_name);

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
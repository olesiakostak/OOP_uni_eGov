using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Models
{
    public class Citizen
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private readonly ITaxPayer? TaxPayer;
        private readonly IDriver? Driver;
        private readonly IAddress? Address;

        public Citizen(string _name, int _age, ITaxPayer? _tax_payer = null, IDriver? _driver = null, IAddress? _address = null) 
        {
            Name = _name;
            Age = _age;
            Address = _address;
            TaxPayer = _tax_payer;
            Driver = _driver;
        }
    }
}
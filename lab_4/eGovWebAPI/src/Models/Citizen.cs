using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Models
{
    public class Citizen
    {
        public string Name { get;}
        public int Age { get;}
        public ITaxPayer? TaxPayer { get; private set; }
        public IDriver? Driver { get; private set; }
        public IAddress? Address { get; private set; }


        public Citizen(string _name, int _age, ITaxPayer? _tax_payer = null, IDriver? _driver = null, IAddress _address = null) 
        {
            Name = _name;
            Age = _age;
            Address = _address;
            TaxPayer = _tax_payer;
            Driver = _driver;
        }

        public bool IsTaxPayer()
        {
            return this.TaxPayer != null;
        }

        public bool IsDriver()
        {
            return this.Driver != null;
        }

        public bool HasAddress()
        {
            return this.Address != null;
        }
    }
}
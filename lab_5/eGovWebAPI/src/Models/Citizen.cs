using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Models
{
    public class Citizen
    {
        public string Name { get; }
        public int Age { get; }
        public ITaxPayer? TaxPayer { get; private set; }
        public IDriver? Driver { get; private set; }
        public IAddress? Address { get; private set; }

        public Citizen(string name, int age, ITaxPayer? taxPayer = null, IDriver? driver = null, IAddress? address = null)
        {
            Name = name;
            Age = age;
            Address = address;
            TaxPayer = taxPayer;
            Driver = driver;
        }

        public void SetAddress(IAddress address)
        {
            Address = address;
        }

        public bool IsTaxPayer()
        {
            return TaxPayer != null;
        }

        public bool IsDriver()
        {
            return Driver != null;
        }

        public bool HasAddress()
        {
            return Address != null;
        }
    }
}
using eGovWebAPI.Models;
using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Services
{
    public class CitizenService
    {
        private readonly Dictionary<string, Citizen> Citizens = new();
        private readonly ITaxPayer TaxPayer;
        private readonly IDriver Driver;
        private readonly IAddress Address;

        public CitizenService (ITaxPayer _taxPayer, IDriver _driver, IAddress _address)
        {
            TaxPayer = _taxPayer;
            Driver = _driver;
            Address = _address;
        }

        public string RegisterCitizen(string _name, int _age, bool _isTaxPayer, bool _isDriver, bool _hasAddress)
        {
            if (Citizens.ContainsKey(_name))
            {
                return "Citizen is already registered";
            }
            var taxPayer = _isTaxPayer ? TaxPayer: null;
            var driver = _isDriver ? Driver: null;
            var address = _hasAddress ? Address: null;

            var citizen = new Citizen(_name, _age, taxPayer, driver, address);

            return $"Citizen {_name} was successfully registered!";
        }


        // public void ShowInfo()
        // {
        //     Console.WriteLine("Citizen Info:");
        //     Console.Write("Tax payer: ");

        //     if (tax_payer != null)
        //     {
        //         tax_payer.CalculateTax();
        //     }
        //     else
        //     {
        //         Console.WriteLine("Not a tax payer.");
        //     }

        //     Console.Write("Car driver: ");
        //     if (driver != null)
        //     {
        //         driver.Drive();
        //     }
        //     else
        //     {
        //         Console.WriteLine("Not a car driver.");
        //     }
        // }
    }
}
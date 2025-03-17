using System;
using eGov.Interfaces;

namespace eGov.Models
{
    class Citizen
    {
        private string name { get; set; }
        private int age { get; set; }
        private ITaxPayer? tax_payer { get; set; }
        private IDriver? car_driver { get; set; }

        public Citizen() {}

        public void InputInfo ()
        {
            Console.Write("Enter full name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you tax payer? (y/n): ");
            char user_input = char.ToLower(Console.ReadKey(true).KeyChar);
            if (user_input == 'y')
            {
                tax_payer = new TaxPayer();
            }
            Console.WriteLine("Are you car driver? (y/n): ");
            user_input = char.ToLower(Console.ReadKey(true).KeyChar);
            if (user_input == 'y')
            {
                car_driver = new CarDriver();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}");
            
            Console.Write("Tax payer: ");
            if (tax_payer != null)
            {
                tax_payer.CalculateTax();
            }
            else
            {
                Console.WriteLine("not a tax payer");
            }

            Console.Write("Car driver: ");
            if (car_driver != null)
            {
                car_driver.Drive();
            }
            else
            {
                Console.WriteLine("not a car driver");
            }
        }
    }
}
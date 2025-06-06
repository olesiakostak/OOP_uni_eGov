using System;
using System.Drawing;
using System.Dynamic;
using System.Security.AccessControl;
using eGov.Interfaces;
using eGov.Services;

namespace eGov.Models
{
    class Citizen
    {
        private string name { get; set; }
        private int age { get; set; }
        private ITaxPayer? tax_payer { get; set; }
        private IDriver? car_driver { get; set; }
        private Address? home_address { get; set; }

        public Citizen() 
        {
            home_address = null;
        }

        public void InputInfo ()
        {
            Console.Write("Enter full name: ");
            while (true)
            {
                name = Console.ReadLine();
                if (!Vadidator.IfValidName(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered not correct name. Please try again");
                    Console.ResetColor();
                }
                else break;
            }
            
            Console.Write("Enter age: ");
            while (true)
            {
                age = int.Parse(Console.ReadLine());;
                if (!Vadidator.IfValidAge(age))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered not correct age. Please try again");
                    Console.ResetColor();
                }
                else break;
            }

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

            Console.WriteLine("Do you want to enter the place of recidence? (optional) (y/n)");
            user_input = char.ToLower(Console.ReadKey(true).KeyChar);
            if (user_input == 'y')
            {
                InputAddress();
            }
        }

        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Name: {name}");

            Console.WriteLine($"Age: {age}");
            
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

            Console.ResetColor();
        }

        public Address? GetAddress()
        {
            return home_address;
        }

        public void InputAddress()
        {
            home_address  = new Address();
            home_address.InputAddress();
        }

        public class Address
        {
            private string country { get; set; }
            private string city { get; set; }
            private string street {get; set; }

            public void InputAddress()
            {
                Console.Write("Input country: ");
                country = Console.ReadLine();
                Console.Write("Input city: ");
                city = Console.ReadLine();
                Console.Write("Input street: ");
                street = Console.ReadLine();
            }

            public void ShowAddress()
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"Coutry: {country}");
                Console.WriteLine($"City: {city}");
                Console.WriteLine($"Street: {street}");

                Console.ResetColor();                
            }

        }
    }
}
using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Models
{
    public class Address: IAddress
    {
        private string Country { get; set; }
        private string City { get; set; }
        private string Street {get; set; }

        public void InputAddress()
        {
            // Console.Write("Input country: ");
            // country = Console.ReadLine();
            // Console.Write("Input city: ");
            // city = Console.ReadLine();
            // Console.Write("Input street: ");
            // street = Console.ReadLine();
        }

        public void ShowAddress()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            // Console.WriteLine($"Coutry: {country}");
            // Console.WriteLine($"City: {city}");
            // Console.WriteLine($"Street: {street}");

            // Console.ResetColor();  
        }  

         public Address? GetAddress()
         {
            return this;
         }
    }
}
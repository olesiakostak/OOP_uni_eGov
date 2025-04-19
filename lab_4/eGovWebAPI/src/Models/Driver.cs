using eGovWebAPI.Interfaces;
using System;

namespace eGovWebAPI.Models
{
    public class Driver: IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Dring car..");
        }
    }
}
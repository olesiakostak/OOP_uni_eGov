using eGov.Interfaces;
using System;

namespace eGov.Models
{
    class CarDriver: IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Dring car..");
        }
    }
}
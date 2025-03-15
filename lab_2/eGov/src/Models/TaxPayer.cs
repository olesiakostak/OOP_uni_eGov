using eGov.Interfaces;
using System;

namespace eGov.Models
{
    class TaxPayer: ITaxPayer
    {
        public void CalculateTax()
        {
            Console.WriteLine("Calculating tax..");
        }
    }
}
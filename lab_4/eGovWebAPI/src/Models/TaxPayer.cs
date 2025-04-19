using eGovWebAPI.Interfaces;
using System;

namespace eGovWebAPI.Models
{
    public class TaxPayer: ITaxPayer
    {
        public void CalculateTax()
        {
            Console.WriteLine("Calculating tax..");
        }
    }
}
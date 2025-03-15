using System;
using eGov.Interfaces;

namespace eGov.Models
{
    class Citizen
    {
        private string name { get; set; };
        private int age { get; set; }
        private ITaxPayer? TaxPayer { get; set; };
        private ITaxDriver? TaxDriver { get; set; };


    }
}
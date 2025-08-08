using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Address
    {
        public string Street;
        public string City;

        // Constructor for Address
        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Street: {Street}, City: {City}");
        }
    }
}

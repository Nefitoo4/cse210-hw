using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;

namespace Foundation2
{
    public class Address
    {
        public Address(string street, string city, string state, string country)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        public bool IsInUSA()
        {
            return Country.ToLower() == "usa";
        }

        public override string ToString()
        {
            return $"{Street}\n{City}, {State}, {Country}";
        }
    }
}
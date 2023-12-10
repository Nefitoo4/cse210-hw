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
        private readonly string streetAddress;
        private readonly string city;
        private readonly string state;
        private readonly string country;

        public Address(string streetAddress, string city, string state, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            // Return all fields together in one string with newline characters where appropriate
            return $"Address: {streetAddress}, {city}, {state}, {country}\n";
        }
    }
}
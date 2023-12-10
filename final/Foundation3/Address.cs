using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation3
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

        public override string ToString()
        {
            return $"{streetAddress}, {city}, {state}, {country}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Foundation2
{
    public class Customer
    {
        private readonly string name;
        private readonly Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }

        public string GetAddressString()
        {
            return address.ToString();
        }

        public string Name => name;
    }
}
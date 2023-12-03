﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Foundation2
{
    public class Customer
    {
        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; private set; }
        public Address Address { get; private set; }

        public bool IsInUSA()
        {
            return Address.IsInUSA();
        }
    }
}
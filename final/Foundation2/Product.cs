using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Foundation2
{
    public class Product
    {
        private readonly string name;
        private readonly string productId;
        private readonly decimal price;
        private readonly int quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal CalculatePrice()
        {
            return price * quantity;
        }

        public string Name => name;
        public string ProductId => productId;
    }
}
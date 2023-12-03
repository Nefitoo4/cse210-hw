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
        public Product(string name, string productId, decimal price, int quantity)
        {
            Name = name;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; private set; }
        public string ProductId { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public decimal GetTotalPrice()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Product ID: {ProductId}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation2
{
    public class Order
    {
        public Order(Customer customer, List<Product> products)
        {
            Customer = customer;
            Products = products;
        }

        public Customer Customer { get; private set; }
        public List<Product> Products { get; private set; }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = Products.Sum(product => product.GetTotalPrice());
            // Add shipping cost based on customer's location
            if (Customer.IsInUSA())
            {
                totalPrice += 5.0m;
            }
            else
            {
                totalPrice += 35.0m;
            }
            return totalPrice;
        }

        public string GetPackingLabel()
        {
            return string.Join("\n", Products.Select(product => product.ToString()));
        }

        public string GetShippingLabel()
        {
            return $"{Customer.Name}\n{Customer.Address.ToString()}";
        }
    }
}
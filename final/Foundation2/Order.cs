using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation2
{
    public class Order
    {
        private readonly List<Product> products;
        private readonly Customer customer;

        public Order(List<Product> products, Customer customer)
        {
            this.products = products ?? throw new ArgumentNullException(nameof(products));
            this.customer = customer ?? throw new ArgumentNullException(nameof(customer));
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;

            foreach (var product in products)
            {
                totalCost += product.CalculatePrice();
            }

            totalCost += customer.IsInUSA() ? 5 : 35;

            return totalCost;
        }

        public string GetPackingLabel()
        {
            // Packing label should list the name and product id of each product
            var packingLabel = "Packing Label:\n";

            foreach (var product in products)
            {
                packingLabel += $"{product.Name}, Product ID: {product.ProductId}\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            // Shipping label should list the name and address of the customer
            var shippingLabel = "Shipping Label:\n";
            shippingLabel += $"Customer: {customer.Name}\n";
            shippingLabel += customer.GetAddressString();

            return shippingLabel;
        }
    }
}
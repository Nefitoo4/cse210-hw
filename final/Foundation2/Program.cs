using System;
using System.Collections.Generic;
using System.Net;

namespace Foundation2
{
class Program
{
    static void Main(string[] args)
    {
            // Create addresses
            Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
            Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create products
            Product product1 = new Product("Widget", "W123", 10.0m, 2);
            Product product2 = new Product("Gadget", "G456", 20.0m, 1);
            Product product3 = new Product("Doodad", "D789", 15.0m, 3);

            // Create orders
            Order order1 = new Order(customer1, new List<Product> { product1, product2 });
            Order order2 = new Order(customer2, new List<Product> { product2, product3 });

            // Display information for each order
            Console.WriteLine("Order 1:");
            Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
            Console.WriteLine($"Total Price: {order1.CalculateTotalPrice():C}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
            Console.WriteLine($"Total Price: {order2.CalculateTotalPrice():C}");
        }
    }
}
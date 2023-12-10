using System;
using System.Collections.Generic;
using System.Net;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product product1 = new Product("Laptop", "P123", 800, 2);
            Product product2 = new Product("Mouse", "P456", 20, 5);

            // Create customers with addresses
            Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
            Customer customer1 = new Customer("John Doe", address1);

            Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create orders
            List<Product> orderProducts1 = new List<Product> { product1, product2 };
            Order order1 = new Order(orderProducts1, customer1);

            List<Product> orderProducts2 = new List<Product> { product1 };
            Order order2 = new Order(orderProducts2, customer2);

            // Display results
            DisplayOrderDetails(order1);
            DisplayOrderDetails(order2);

            Console.ReadKey(); // Wait for a key press before closing the console
        }

        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine("Order Details:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}\n");
        }
    }
}
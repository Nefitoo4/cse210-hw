using System;
using System.Collections.Generic;
using System.Net;

namespace Foundation3
{
class Program
{
    static void Main(string[] args)
    {
            // Create addresses
            Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
            Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");

            // Create events
            Event genericEvent = new Event("Generic Event", "A generic event description", DateTime.Now, "7:00 PM", address1);
            Lecture lectureEvent = new Lecture("Programming Lecture", "Learn about programming", DateTime.Now.AddDays(7), "6:30 PM", address1, "John Doe", 50);
            Reception receptionEvent = new Reception("Networking Reception", "Network with professionals", DateTime.Now.AddDays(14), "8:00 PM", address2, "rsvp@example.com");
            OutdoorGathering outdoorEvent = new OutdoorGathering("Community Picnic", "Enjoy a day in the park", DateTime.Now.AddDays(21), "12:00 PM", address2, "Sunny with a high of 75°F");

            // Display information for each event
            Console.WriteLine("Generic Event:");
            Console.WriteLine($"Standard Details:\n{genericEvent.GetStandardDetails()}\n");
            Console.WriteLine($"Full Details:\n{genericEvent.GetFullDetails()}\n");
            Console.WriteLine($"Short Description:\n{genericEvent.GetShortDescription()}\n");

            Console.WriteLine("Programming Lecture:");
            Console.WriteLine($"Standard Details:\n{lectureEvent.GetStandardDetails()}\n");
            Console.WriteLine($"Full Details:\n{lectureEvent.GetFullDetails()}\n");
            Console.WriteLine($"Short Description:\n{lectureEvent.GetShortDescription()}\n");

            Console.WriteLine("Networking Reception:");
            Console.WriteLine($"Standard Details:\n{receptionEvent.GetStandardDetails()}\n");
            Console.WriteLine($"Full Details:\n{receptionEvent.GetFullDetails()}\n");
            Console.WriteLine($"Short Description:\n{receptionEvent.GetShortDescription()}\n");

            Console.WriteLine("Community Picnic:");
            Console.WriteLine($"Standard Details:\n{outdoorEvent.GetStandardDetails()}\n");
            Console.WriteLine($"Full Details:\n{outdoorEvent.GetFullDetails()}\n");
            Console.WriteLine($"Short Description:\n");
        }
    }
}
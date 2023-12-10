using System;
using System.Collections.Generic;
using System.Net;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create events
            Address eventAddress = new Address("123 Main St", "Cityville", "CA", "USA");

            Event genericEvent = new Event("Generic Event", "A generic event", DateTime.Now, "10:00 AM", eventAddress);
            Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion", DateTime.Now, "2:00 PM", eventAddress, "John Doe", 100);
            Reception receptionEvent = new Reception("Networking Reception", "Socialize and network", DateTime.Now, "6:00 PM", eventAddress, "rsvp@example.com");
            OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "Fun in the sun", DateTime.Now, "12:00 PM", eventAddress, "Weather permitting");

            // Display event details
            DisplayEventDetails(genericEvent);
            DisplayEventDetails(lectureEvent);
            DisplayEventDetails(receptionEvent);
            DisplayEventDetails(outdoorEvent);
        }

        static void DisplayEventDetails(Event eventItem)
        {
            Console.WriteLine($"Event Details for {eventItem.GetType().Name}:\n");

            Console.WriteLine("Standard Details:");
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine(new string('-', 50)); // Separator line
            Console.WriteLine("Press Enter to Display the outputs");
            Console.ReadLine();
        }
    
    }
}
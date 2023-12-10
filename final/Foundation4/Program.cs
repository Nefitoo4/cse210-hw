using System;
using System.Collections.Generic;

namespace Foundation4
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Activity runningActivity = new Running(new DateTime(2023, 11, 15), 30, 3.0);
            Activity bicycleActivity = new StationaryBicycle(new DateTime(2023, 11, 16), 45, 20.0);
            Activity swimmingActivity = new Swimming(new DateTime(2023, 11, 17), 40, 20);

            // Display activity summaries
            DisplayActivitySummary(runningActivity);
            DisplayActivitySummary(bicycleActivity);
            DisplayActivitySummary(swimmingActivity);
        }

        static void DisplayActivitySummary(Activity activity)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 50)); // Separator line
            Console.WriteLine("Press any key to see the outputs");
            Console.ReadLine();
        }
    }
}
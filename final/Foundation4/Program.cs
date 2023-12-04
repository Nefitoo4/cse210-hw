using System;
using System.Collections.Generic;

namespace Foundation4
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 20.0);
            Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, 20);

            // Put each activity in the same list
            List<Activity> activities = new List<Activity>
            {
                runningActivity,
                cyclingActivity,
                swimmingActivity
            };

            // Iterate through the list and call GetSummary on each item
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
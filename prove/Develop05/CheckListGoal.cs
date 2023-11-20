using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    class ChecklistGoal : Goal
    {
        public int RequiredEvents { get; set; }
        public int CompletedEvents { get; set; }

        public ChecklistGoal(string goalDescription, int goalValue, int requiredEvents)
            : base(goalDescription, goalValue)
        {
            RequiredEvents = requiredEvents;
            CompletedEvents = 0;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" Completed {CompletedEvents}/{RequiredEvents} times");
        }

        public override void RecordEvent()
        {
            base.RecordEvent();
            CompletedEvents++;

            if (CompletedEvents == RequiredEvents)
            {
                Console.WriteLine($"Bonus achieved for completing {GoalDescription} {RequiredEvents} times! Bonus: {GoalValue * 2} points");
                GoalValue *= 2; // Double the points for reaching the checklist goal
            }
        }
    }
}
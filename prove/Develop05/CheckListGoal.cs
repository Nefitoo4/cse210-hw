using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    class CheckListGoal : Goal
    {
        public int RequiredEvent {get; set;}
        private int completedEvents;

        public CheckListGoal(string goalDescription, int goalValue, int requiredEvents) : base(goalDescription, goalValue)
        {
            _requiredEvents = requiredEvents;
            completedEvents = 0;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Completed {completedEvents} / {requiredEvents} times");
        }

        public override void RecordEvent()
        {
            base. RecordEvent();
            completedEvents++;

            if (completedEvents == RequiredEvents)
            {
                Console.WriteLine($"Bonus achived for completing {GoalDescription} {RequiredEvents} times! Bonus: {GoalValue * 2} points.");
                GoalValue *= 2; //Double the points for reaching the checklist goal
            }
        }
    }
}
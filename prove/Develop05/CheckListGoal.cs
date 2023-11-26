using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        private int pointsPerEvent;
        public int requiredEvents;
        public int completedEvents;
        public ChecklistGoal(string description, int pointsPerEvent, int requiredEvents)
            : base(description) // Call the base class constructor with the description parameter
        {
            this.pointsPerEvent = pointsPerEvent;
            this.requiredEvents = requiredEvents;
            this.completedEvents = 0;
        }

        public override int RecordEvent()
        {
            if(!Completed)
            {
                completedEvents++;
                if(completedEvents == requiredEvents)
                {
                    Completed = true;
                    return pointsPerEvent + CalculateBonus();
                }

                return pointsPerEvent;
            }

            return 0;
        }
        private int CalculateBonus()
        {
            //adding the bonus calculation here
            return 500;
        }

        public override void Display()
        {
            Console.WriteLine($"[] {GoalDescription} - {pointsPerEvent} points per event, {completedEvents}/{requiredEvents} completed");
        }
    }
}
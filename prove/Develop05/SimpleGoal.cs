using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private int points;
        public SimpleGoal(string description, int points) : base (description)
        {
            this.points = points;
        }

        public override int RecordEvent()
        {
            if(!Completed)
            {
                Completed = true;
                return points;
            }

            return 0;
        }

        public override void Display()
        {
            Console.WriteLine($"[] {GoalDescription} - {points} points");
        }
    }
}
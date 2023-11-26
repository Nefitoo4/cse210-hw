using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        private int points;
        public EternalGoal(string description, int points) : base(description)
        {
            this.points = points;
        }

        public override int RecordEvent()
        {
            return points;
        }

        public override void Display()
        {
            Console.WriteLine($"[] {GoalDescription} - {points} points (Eternal)");
        }
    }
}
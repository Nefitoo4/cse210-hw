using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Develop05
{
    abstract class Goal
    {
        public string GoalDescription {get; set;}
        public bool Completed {get; set;}
        public int GoalValue {get; set;}
    }

    public Goal(string goalDescription, int goalValue)
    {
        _goalDescription = goalDescription;
        _Completed = false;
        _GoalValue = goalValue;
    }

    public virtual void Display()
    {
        Console.WriteLine($"[{Completed ? 'X' : ' '}] {GoalDescription}");
    }

    public virtual void RecordEvent()
    {
        Completed = true;
        Console.WriteLine($"Event recorded for: {GoalDescription}. You gained {GoalValue} points!");
    }
}
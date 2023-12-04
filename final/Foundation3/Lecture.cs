using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Foundation3
{
    public class Lecture : Event
    {
        public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
                : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public string Speaker { get; private set; }
        public int Capacity { get; private set; }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Lecture\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}

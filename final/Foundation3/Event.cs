using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Foundation3
{
    public class Event
    {
        public Event(string title, string description, DateTime date, string time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public string Time { get; private set; }
        public Address Address { get; private set; }

        public virtual string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"Type: Generic Event\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}

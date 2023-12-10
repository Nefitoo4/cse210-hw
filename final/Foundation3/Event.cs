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
        private readonly string title;
        private readonly string description;
        private readonly DateTime date;
        private readonly string time;
        private readonly Address address;

        public Event(string title, string description, DateTime date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetShortDescription()
        {
            return $"Type: Generic Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
        }
    }
}

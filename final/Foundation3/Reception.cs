using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Foundation3
{
    public class Reception : Event
    {
        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
                : base(title, description, date, time, address)
        {
            RSVPEmail = rsvpEmail;
        }

        public string RSVPEmail { get; private set; }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {RSVPEmail}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Reception\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}

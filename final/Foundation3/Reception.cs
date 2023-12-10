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
        private readonly string rsvpEmail;

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
        }
    }
}

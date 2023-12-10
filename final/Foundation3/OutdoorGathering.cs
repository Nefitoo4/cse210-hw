using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Foundation3
{
    public class OutdoorGathering : Event
    {
        private readonly string weatherStatement;

        public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherStatement)
            : base(title, description, date, time, address)
        {
            this.weatherStatement = weatherStatement;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Statement: {weatherStatement}";
        }
    }
}
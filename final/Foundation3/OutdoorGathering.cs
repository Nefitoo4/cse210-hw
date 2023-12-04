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
        public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            WeatherForecast = weatherForecast;
        }

        public string WeatherForecast { get; private set; }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
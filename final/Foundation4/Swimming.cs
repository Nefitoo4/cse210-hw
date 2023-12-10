using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Swimming : Activity
    {
        private readonly int laps;

        public Swimming(DateTime date, int durationMinutes, int laps)
            : base(date, durationMinutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50.0 / 1000.0; // Convert laps to kilometers
        }

        public override double GetPace()
        {
            return durationMinutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance {GetDistance()} km, Laps: {laps}, Pace: {GetPace()} min per km";
        }
    }
}
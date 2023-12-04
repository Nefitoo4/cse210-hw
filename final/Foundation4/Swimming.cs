using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Swimming : Activity
    {
        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            Laps = laps;
        }

        public int Laps { get; private set; }

        public override double GetDistance()
        {
            return Laps * 50.0 / 1000.0;
        }

        public override double GetSpeed()
        {
            return GetDistance() / (Minutes / 60.0);
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Running : Activity
    {
        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            Distance = distance;
        }

        public double Distance { get; private set; }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return Distance / (Minutes / 60.0);
        }

        public override double GetPace()
        {
            return Minutes / Distance;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {Distance} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}

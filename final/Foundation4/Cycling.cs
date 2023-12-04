using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    public class Cycling : Activity
    {
        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            Speed = speed;
        }

        public double Speed { get; private set; }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return 60.0 / Speed;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Speed: {Speed:F1} kph, Pace: {GetPace():F1} min per km";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation4
{
    public class StationaryBicycle : Activity
    {
        private readonly double speed;

        public StationaryBicycle(DateTime date, int durationMinutes, double speed)
            : base(date, durationMinutes)
        {
            this.speed = speed;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Speed: {speed} mph";
        }
    }
}
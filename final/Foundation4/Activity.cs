using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Foundation4
{
    public class Activity
    {
        protected readonly DateTime date;
        protected readonly int durationMinutes;

        public Activity(DateTime date, int durationMinutes)
        {
            this.date = date;
            this.durationMinutes = durationMinutes;
        }

        public virtual double GetDistance()
        {
            return 0; // Default implementation (override in derived classes)
        }

        public virtual double GetSpeed()
        {
            return 0; // Default implementation (override in derived classes)
        }

        public virtual double GetPace()
        {
            return 0; // Default implementation (override in derived classes)
        }

        public virtual string GetSummary()
        {
            return $"{date.ToShortDateString()} {GetType().Name} ({durationMinutes} min)";
        }
    }
}

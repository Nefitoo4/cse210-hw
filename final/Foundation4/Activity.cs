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
        public Activity(DateTime date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public DateTime Date { get; private set; }
        public int Minutes { get; private set; }

        public virtual double GetDistance()
        {
            // Base class has no specific distance calculation
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            // Base class has no specific speed calculation
            return 0.0;
        }

        public virtual double GetPace()
        {
            // Base class has no specific pace calculation
            return 0.0;
        }

        public virtual string GetSummary()
        {
            return $"{Date.ToShortDateString()} - {GetType().Name} ({Minutes} min)";
        }
    }
}

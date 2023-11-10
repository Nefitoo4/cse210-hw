using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfulness_Program
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string ActivityName, string Description) : base(ActivityName, Description)
        {
            
        }

        private void BreatheIn()
        {
            Console.Write("Breathe in...");
            CountDown(4);
            Console.WriteLine();
        }

        private void BreatheOut()
        {
             Console.Write("Now Breathe out...");
            CountDown(6);
            Console.WriteLine();
        }

        public void Run()
        {
            Prepare();
            GetReady();

            DateTime CurrentTime = DateTime.Now;
            DateTime FutureTime = CurrentTime.AddSeconds(_duration);
            do
            {
                Console.WriteLine();
                BreatheIn();
                BreatheOut();
            } while (DateTime.Now < FutureTime);

            Ending();
        }
    }
}
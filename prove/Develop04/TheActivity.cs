using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfulness_Program
{
    public class Activity
    {
        private string _activityName;
        private string _description;
        protected int _duration;

        public Activity(string ActivityName, string Description)
        {
            _activityName = ActivityName;
            _description = Description;
        }

        protected void GetReady()
        {
            Console.Clear();
            Console.WriteLine("Get ready...");
            Spinner(5);
        }

        protected void Prepare()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName}");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session?  =>  ");
            _duration = Convert.ToInt32(Console.ReadLine());

        }

        protected void Ending()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            Spinner(5);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
            Spinner(5);
        }

        protected void CountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--) 
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        protected void Spinner(int seconds)
        {
            List<string> Characters = new List<string>() 
            { 
                "|", "/", "-", "\\", "|", "/", "-", "\\"
            };

            DateTime start = DateTime.Now;
            DateTime end = start.AddSeconds(seconds);

            while (DateTime.Now < end) 
            {
                foreach (string Char in Characters)
                {
                    Console.Write(Char);
                    Thread.Sleep(150);
                    Console.Write("\b \b");
                }
            }
            
        }

        
    }
}
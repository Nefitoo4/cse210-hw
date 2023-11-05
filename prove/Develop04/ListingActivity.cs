using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfulness_Program
{
    public class ListingActivity : Activity
    {
        private List<string> PROMPTS = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity(string ActivityName, string Description) : base(ActivityName, Description)
        {
        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(PROMPTS.Count);
            return PROMPTS[randomIndex];
        }

        public void Run()
        {
            Prepare();
            GetReady();

            DateTime CurrentTime = DateTime.Now;
            DateTime FutureTime = CurrentTime.AddSeconds(_duration);

            Console.WriteLine("List as many responses you can to the following promt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---\n");

            Console.Write("You may begin in: ");
            CountDown(5);
            Console.WriteLine();

            do
            {
                Console.Write(">");
                Console.ReadLine();
            } while (DateTime.Now < FutureTime);

            Ending();
        }
    }
}
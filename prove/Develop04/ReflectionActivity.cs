using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mindfulness_Program
{
    public class ReflectionActivity : Activity
    {
        private List<string> PROMPTS = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> QUESTIONS = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity(string ActivityName, string Description) : base(ActivityName, Description)
        {
        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(PROMPTS.Count);
            return PROMPTS[randomIndex];
        }

        private string GetRandomQuestion()
        {
            Random random = new Random();
            int randomIndex = random.Next(QUESTIONS.Count);
            return QUESTIONS[randomIndex];
        }

        public void Run()
        {
            Prepare();
            GetReady();

            Console.WriteLine("Consider the following promt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
            Console.Write("When you have something in mind, press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: ");
            CountDown(5);
            Console.Clear();

            DateTime CurrentTime = DateTime.Now;
            DateTime FutureTime = CurrentTime.AddSeconds(_duration);

            do
            {
                Console.Write($"> {GetRandomQuestion()}");
                Spinner(10);
                Console.WriteLine();
            } while (DateTime.Now < FutureTime);

            Ending();
        }
    }
}
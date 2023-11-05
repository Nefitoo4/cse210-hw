using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Mindfulness_Program
{
    public class Menu
    {
   
        private List<string> menu = new List<string>()
        {
            "  1. Start Breathing Activity",
            "  2. Start Reflecting Activity",
            "  3. Start listing Activity",
            "  4. Quit"
        };

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu options");
            Console.WriteLine();

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Select a choise from the menu");
        }

    }
}
using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Develop05
{
    public class Menu
    {
        private list<string> menu = new List<string>()
        {
            " 1. Create a New Goal",
            " 2. List Goals",
            " 3. Save Goals",
            " 4. Load Goals",
            " 5. Records Events",
            " 6. Quit"
        };

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu Option:");
            Console.WriteLine();

            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Select the choice from the menu: ");
        }
    }
}
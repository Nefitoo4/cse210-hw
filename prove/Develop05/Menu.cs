using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Linq;

namespace Develop05
{
    public class Menu
    {
        public static int ShowMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create a new goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Record Events");
            Console.WriteLine("6.Quit");

            int choice;
            do
            {
                Console.WriteLine("Select a choice from the menu: ");
            }while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6);

            return choice;
        }
    }
}
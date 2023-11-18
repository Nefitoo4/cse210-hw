using System;
using System.IO;
using Develop05;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
        Console.Write("Which type of Goal would you like to Create? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            SimpleGoal newGoal = new SimpleGoal();
            Console.WriteLine("What is the name of your goal? ");
            string GoalName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string GoalDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
        }
        else if (choice == "2")
        {
        }
        else if (choice == "3")
        {

        }
        else if (choice == "4")
        {

        }
        else if (choice == "5")
        {

        }
        else
        {
            Console.WriteLine("Quit");
        }
    }
}
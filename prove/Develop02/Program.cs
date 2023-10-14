<<<<<<< HEAD
using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Menu displayMenu = new Menu();
        displayMenu.Display();

        Journal journal = new Journal();

        string Break = "5";
        string Selection = "";

        while (Break != Selection)
        {
            Console.Write("What would you like to do? ");
            Selection = Console.ReadLine();
            
            if (Selection == "1")
            {
                journal.Write();

                displayMenu.Display();
            }else if (Selection == "2")
            {
                journal.Display();

                displayMenu.Display();
            }else if (Selection == "3")
            {
                journal.ReadFile();

                displayMenu.Display();
            }else if (Selection == "4")
            {
                journal.SaveToFile();

                displayMenu.Display();
            }else if (Selection == "5")
            {
                //Quit
            }else
            {
                Console.WriteLine("Please select a below option");
                displayMenu.Display();
            }
        }
        {
            Console.WriteLine("Tell something new you did learn today.");
        }
    }
=======
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
>>>>>>> cc9009385e1f408a3d06cc8dcb5d2d364a3ef2b5
}
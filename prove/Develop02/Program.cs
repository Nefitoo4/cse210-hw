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
}
    public class Menu
    {
        public void Display()
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        }
    }
    public class Journal
    {
        public List<Prompt> _prompts = new List<Prompt>();
        public List<Entry> _entries = new List<Entry>();

        public void Write()
        {
            Prompt prompts = new Prompt();
            string randomPrompt = prompts.PromptGenerator();
            Console.WriteLine(randomPrompt);

            Console.Write("> ");
            string newEntry = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            Entry newPrompt = new Entry();
            Entry entry = new Entry();
            Entry blank = new Entry();

            newPrompt._entry = $"{dateText} - Prompt: {randomPrompt}";
            entry._entry = $"{newEntry}";
            blank._entry = "";

            _entries.Add(newPrompt);
            _entries.Add(entry);
            _entries.Add(blank);
        }
        public void Display()
        {
            foreach(Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine("");
            }
        }
        public void SaveToFile()
        {
            Console.WriteLine("What is the Filename?");
            Console.Write("> ");
            string filename = Console.ReadLine();

            Console.WriteLine("Journal saved");

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach(Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._entry}");
                }
            }
        }
        public void ReadFile()
        {
            Console.WriteLine("What is the filename? ");
            Console.Write("> ");

            string filename = Console.ReadLine();
            string[] lines = File.ReadAllLines(filename);

            foreach(string line in lines)
            {
                Entry entry = new Entry();
                entry._entry = line;
                _entries.Add(entry);
            }

            Console.WriteLine("Entries loaded");
        }
    }
    public class Entry
    {
        public string _entry;
        public void Display()
        {
            Console.Write(_entry);
        }
    }
    public class Prompt
    {
        public int NumberGenerator()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 5);
            return number;
        }
        public string PromptGenerator()
        {
            string random = NumberGenerator().ToString();
                if (random == "1")
                {
                    return "Tell me something new you did learn today.";
                }else if (random == "2")
                {
                    return "Did you know someone new today?";
                }else if  (random == "3")
                {
                    return "Did you do something good for someone today?";
                }else if (random == "4")
                {
                    return "What impresions of the spirit did you?";
                }else
                {
                    return "What you do to be better then today?";
                }
        }
    }
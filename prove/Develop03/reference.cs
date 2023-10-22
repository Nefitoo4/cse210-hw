using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine();

        Reference reference = new Reference("Proverbs", "3","5","6");
        Console.WriteLine(reference.DisplayReference());

        string myScripture = "Trust in the Lord with all your heart and lean not on your own " +
            "understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture scripture = new Scripture();
        string[] words = myScripture.Split(' ');
        foreach (string word in words)
        {
            scripture.AddWord(word);
        }

        string quit = "";

        scripture.DisplayScripture();
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide words or type 'quit' to finish");
        Console.ReadLine();

        while (quit != "quit")
        {
            scripture.HideWords();
            Console.Clear();
            Console.WriteLine("Scripture Memorizer");
            Console.WriteLine();
            Console.WriteLine(reference.DisplayReference());
            scripture.GetRenderedText();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to finish");
            quit = Console.ReadLine();
        }
    }
}
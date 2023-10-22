public class Scripture
{
    private List<Word> Words;

    public Scripture()
    {
        Words = new List<Word>();
    }

    public void AddWord(string word)
    {
        Words.Add(new Word(word));
    }

    public void DisplayScripture()
    {
        foreach (Word word in Words)
        {
            Console.Write(word.Text + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        foreach (Word word in Words)
        {
            word.HideRandomly();
        }

        if (Words.All(word => word.IsHidden))
        {
            Console.WriteLine("All the words will be hidden. Ending");
            Environment.Exit(0);
        }
    }

    public void GetRenderedText()
    {
        foreach (Word word in Words)
        {
            Console.Write(word.Text + " ");
        }
        Console.WriteLine();
    }
}
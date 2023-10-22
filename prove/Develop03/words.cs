public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void HideRandomly()
    {
        if (!IsHidden && new Random().Next(2) == 0)
        {
            IsHidden = true;
            Text = new string('_', Text.Length);
        }
    }
}
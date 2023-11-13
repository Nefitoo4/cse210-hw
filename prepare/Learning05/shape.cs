public abstract class shape
{
    private string _color;

    public shape(string color)
    {
        _color = color;
    }
    public string GetColor;
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}
public class circle : shape
{
    private double_radius;

    public circle(string color, double radius) : base(color)
    {
        _radius = radius;   
    }

    public override double GetArea()
    {
        return _radius*_radius*Math.PI;
    }
}
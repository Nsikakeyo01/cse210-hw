public class RainbowRectangle : Shape
{
    private double _length;
    private double _width;

    public RainbowRectangle(string color, string texture, double length, double width) : base(color, texture)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"Length: {_length}, Width: {_width}, Area: {GetArea()}.");
    }
}

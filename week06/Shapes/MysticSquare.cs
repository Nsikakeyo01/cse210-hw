public class MysticSquare : Shape
{
    private double _side;

    public MysticSquare(string color, string texture, double side) : base(color, texture)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"Its side length is {_side}, giving it an area of {GetArea()}.");
    }
}

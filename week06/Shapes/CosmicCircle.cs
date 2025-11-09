public class CosmicCircle : Shape
{
    private double _radius;

    public CosmicCircle(string color, string texture, double radius) : base(color, texture)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"Radius: {_radius}, Area: {GetArea():F2}.");
    }
}

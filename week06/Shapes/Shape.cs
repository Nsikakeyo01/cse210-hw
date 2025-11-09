public abstract class Shape
{
    private string _color;
    private string _texture;

    public string Color { get { return _color; } set { _color = value; } }
    public string Texture { get { return _texture; } set { _texture = value; } }

    public Shape(string color, string texture)
    {
        _color = color;
        _texture = texture;
    }

    public abstract double GetArea();
    public virtual void Describe()
    {
        Console.WriteLine($"I am a {GetType().Name} with {Color} color and {Texture} texture.");
    }
}

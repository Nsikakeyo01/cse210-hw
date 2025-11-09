using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> myShapes = new List<Shape>();

        myShapes.Add(new MysticSquare("Red", "Glossy", 5));
        myShapes.Add(new RainbowRectangle("Blue", "Striped", 4, 6));
        myShapes.Add(new CosmicCircle("Green", "Sparkly", 3));

        Console.WriteLine("Welcome to YOUR personalized Shape Gallery!\n");

        foreach (Shape s in myShapes)
        {
            s.Describe();
            Console.WriteLine();
        }
    }
}

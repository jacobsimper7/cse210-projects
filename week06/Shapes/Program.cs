using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle("Red", 5);
        Square square = new Square("Blue", 4);
        Rectangle rectangle = new Rectangle("Green", 6, 3);
        List<Shape> shapes = new List<Shape> { circle, square, rectangle };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
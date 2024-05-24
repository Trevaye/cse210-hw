using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 3, 6));
        shapes.Add(new Circle("Green", 5));
        

        foreach (Shape s in shapes)
        {
            // Get and display the color of the shape
            string color = s.GetColor();

            // Get and display the area of the shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
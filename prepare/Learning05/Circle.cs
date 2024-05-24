public class Circle : Shape
{
    // Private member variable to store the radius of the circle
    private double _radius;

    // Constructor that sets the color and radius, and calls the base constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method to calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
public abstract class Shape
{
    // Member variable to store the color of the shape
    private string _color;

    // Constructor that sets the color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and setter for the color
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method for getting the area, to be overridden by derived classes
    public abstract double GetArea();
}
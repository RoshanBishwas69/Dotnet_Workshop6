public class Rectangle
{
    private double length;
    private double breadth;

    // Expression-bodied Properties
    public double Length
    {
        get => length;
        set => length = value;
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    // Expression-bodied Methods
    public double GetArea() => length * breadth;

    public string ShowDetails() =>
        $"Length: {length}, Breadth: {breadth}";

    // New Method: Perimeter (Expression-bodied)
    public double GetPerimeter() => 2 * (length + breadth);
}
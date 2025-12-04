using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.Length = 10;
        r.Breadth = 5;

        Console.WriteLine("Area: " + r.GetArea());
        Console.WriteLine("Perimeter: " + r.GetPerimeter());
        Console.WriteLine(r.ShowDetails());
    }
}
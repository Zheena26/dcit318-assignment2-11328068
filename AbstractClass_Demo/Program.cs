using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius;
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width, Height;
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Choose a shape (circle or rectangle): ");
        string shapeInput = Console.ReadLine()?.Trim().ToLower();

        Shape shape = null;

        if (shapeInput == "circle")
        {
            Console.Write("Enter the radius: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                shape = new Circle(radius);
                Console.WriteLine("Area of Circle: " + shape.GetArea());
            }
            else
            {
                Console.WriteLine("Invalid input for radius.");
            }
        }
        else if (shapeInput == "rectangle")
        {
            Console.Write("Enter the width: ");
            bool validWidth = double.TryParse(Console.ReadLine(), out double width);

            Console.Write("Enter the height: ");
            bool validHeight = double.TryParse(Console.ReadLine(), out double height);

            if (validWidth && validHeight)
            {
                shape = new Rectangle(width, height);
                Console.WriteLine("Area of Rectangle: " + shape.GetArea());
            }
            else
            {
                Console.WriteLine("Invalid input for width or height.");
            }
        }
        else
        {
            Console.WriteLine("Unknown shape. Exiting...");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

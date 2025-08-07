using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Choose a vehicle (car or bicycle): ");
        string input = Console.ReadLine()?.Trim().ToLower();

        IMovable vehicle;

        if (input == "car")
        {
            vehicle = new Car();
            vehicle.Move();
        }
        else if (input == "bicycle")
        {
            vehicle = new Bicycle();
            vehicle.Move();
        }
        else
        {
            Console.WriteLine("Unknown vehicle. Exiting...");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

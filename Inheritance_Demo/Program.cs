using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the name of the animal (Dog or Cat): ");
        string input = Console.ReadLine()?.Trim().ToLower();

        Animal animal;

        if (input == "dog")
        {
            animal = new Dog();
            animal.MakeSound();
        }
        else if (input == "cat")
        {
            animal = new Cat();
            animal.MakeSound();
        }
        else
        {
            Console.WriteLine("Unknown animal. Exiting program...");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}


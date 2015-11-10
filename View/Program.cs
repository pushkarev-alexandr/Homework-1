using System;
using Domain;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.Write("Welcome to pet-shop!\nEnter the age of the cat: ");
            var cat = new Cat(Console.ReadLine());
            Console.WriteLine("\nCongratulation! Your cat is created!");

            while (true)
            {
                Console.WriteLine("\nInformation about the cat:");
                Console.WriteLine("Name: {0}\nAge: {1}\nColor: {2}\n", cat.Name, cat.Age, cat.CurrentColor);

                Console.WriteLine("Choose what you wanna do with your cat.");
                Console.WriteLine("1. Set name\n2. Set color\n3. Punish\n4. Feed");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter the name: ");
                        cat.Name = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Enter the sick color: ");
                        cat.Color.SickColor = Console.ReadLine();
                        Console.Write("Enter the healthy color: ");
                        cat.Color.HealthyColor = Console.ReadLine();
                        break;
                    case "3":
                        cat.Punish();
                        break;
                    case "4":
                        cat.Feed();
                        break;
                }

            }
        }
    }
}

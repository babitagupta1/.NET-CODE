using System;

namespace PizzaChoiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter the choice ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("make veg pizza");
                        break;
                    case 2:
                        Console.WriteLine("make non veg pizza");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}

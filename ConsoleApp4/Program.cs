namespace sandwich_making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sandwich Maker!");
            Console.WriteLine("Select ingredients to add to your sandwich. Each ingredient adds to the total price.");

            int choice = 0;
            float totalPrice = 0f;

            // Ingredient prices
            float breadPrice = 2f;
            float lettucePrice = 1.5f;
            float cheesePrice = 2.5f;
            float tomatoPrice = 1f;
            float chickenPrice = 3f;
            float mayoPrice = 0.5f;
            float eggPrice = 2f;

            do
            {
                Console.WriteLine("\n -------------------- Choose your Menu: --------------------");
                Console.WriteLine($"1. Bread      - ${breadPrice}");
                Console.WriteLine($"2. Lettuce    - ${lettucePrice}");
                Console.WriteLine($"3. Cheese     - ${cheesePrice}");
                Console.WriteLine($"4. Tomato     - ${tomatoPrice}");
                Console.WriteLine($"5. Chicken    - ${chickenPrice}");
                Console.WriteLine($"6. Mayo       - ${mayoPrice}");
                Console.WriteLine($"7. Egg        - ${eggPrice}");
                Console.WriteLine("0. Exit and calculate total");

                Console.Write("Enter your choice (0-7): ");
                bool validInput = int.TryParse(Console.ReadLine(), out choice);

                if (validInput)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("*Bread added.*");
                            totalPrice += breadPrice;
                            break;
                        case 2:
                            Console.WriteLine("*Lettuce added.*");
                            totalPrice += lettucePrice;
                            break;
                        case 3:
                            Console.WriteLine("*Cheese added.*");
                            totalPrice += cheesePrice;
                            break;
                        case 4:
                            Console.WriteLine("*Tomato added.*");
                            totalPrice += tomatoPrice;
                            break;
                        case 5:
                            Console.WriteLine("*Chicken added.*");
                            totalPrice += chickenPrice;
                            break;
                        case 6:
                            Console.WriteLine("*Mayo added.*");
                            totalPrice += mayoPrice;
                            break;
                        case 7:
                            Console.WriteLine("*Egg added.*");
                            totalPrice += eggPrice;
                            break;
                        case 0:
                            Console.WriteLine("------------------Exiting......................");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please enter a number between 0 and 7.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            } while (choice != 0);

            Console.WriteLine($"\n\n Total price for your sandwich is: ${totalPrice:F2}");

            Thread.Sleep(1000);
            Console.WriteLine("\n\nYour sandwich will be ready in 5 min.................");
            Thread.Sleep(10000);
            Console.WriteLine("\n\nAfter 5 min, sandwich is ready , enjoy your meal sir.");
        }
    }
}
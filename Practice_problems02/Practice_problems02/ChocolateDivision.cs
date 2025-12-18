using System;

namespace Practice_problems02
{
    public static class ChocolateDivision
    {
        public static void Run()
        {
            int numberOfChocolates;
            while (true)
            {
                Console.Write("Enter number of chocolates (integer): ");
                if (int.TryParse(Console.ReadLine(), out numberOfChocolates) && numberOfChocolates >= 0)
                    break;
                Console.WriteLine("Invalid input. Enter a non-negative integer.");
            }

            int numberOfChildren;
            while (true)
            {
                Console.Write("Enter number of children (integer, > 0): ");
                if (int.TryParse(Console.ReadLine(), out numberOfChildren) && numberOfChildren > 0)
                    break;
                Console.WriteLine("Invalid input. Enter an integer greater than 0.");
            }

            int eachGets = numberOfChocolates / numberOfChildren;
            int remaining = numberOfChocolates % numberOfChildren;

            Console.WriteLine($"The number of chocolates each child gets is {eachGets} and the number of remaining chocolates is {remaining}");
        }
    }
}
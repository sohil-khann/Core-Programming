using System;

namespace Practice_problems02
{
    public static class SwapNumbers
    {
        public static void Run()
        {
            double number1;
            while (true)
            {
                Console.Write("Enter number1: ");
                if (double.TryParse(Console.ReadLine(), out number1))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double number2;
            while (true)
            {
                Console.Write("Enter number2: ");
                if (double.TryParse(Console.ReadLine(), out number2))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            // swap
            double temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"The swapped numbers are {number1} and {number2}");
        }
    }
}
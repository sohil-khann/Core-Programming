using System;

namespace Level_03
{
    public static class Abundant
    {
        public static void Run()
        {
            Console.Write("Enter an integer to check for Abundant: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            if (sum > number)
                Console.WriteLine($"{number} is an Abundant Number (sum of divisors = {sum}).");
            else
                Console.WriteLine($"{number} is NOT an Abundant Number (sum of divisors = {sum}).");
        }
    }
}
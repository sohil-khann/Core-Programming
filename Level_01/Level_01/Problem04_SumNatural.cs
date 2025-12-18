using System;

namespace Level_01
{
    public static class Problem04_SumNatural
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            if (!long.TryParse(Console.ReadLine(), out var n))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (n >= 1)
            {
                var sum = n * (n + 1) / 2;
                Console.WriteLine($"The sum of {n} natural numbers is {sum}");
            }
            else
            {
                Console.WriteLine($"The number {n} is not a natural number");
            }
        }
    }
}
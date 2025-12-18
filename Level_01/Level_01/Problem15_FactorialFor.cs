using System;

namespace Level_01
{
    public static class Problem15_FactorialFor
    {
        public static void Run()
        {
            Console.WriteLine("Enter a non-negative integer:");
            if (!long.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }
            if (n < 0) { Console.WriteLine("Number must be non-negative"); return; }

            long result = 1;
            for (long i = 1; i <= n; i++) result *= i;
            Console.WriteLine($"Factorial of {n} is {result}");
        }
    }
}
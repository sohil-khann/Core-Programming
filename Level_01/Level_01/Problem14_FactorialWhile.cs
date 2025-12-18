using System;

namespace Level_01
{
    public static class Problem14_FactorialWhile
    {
        public static void Run()
        {
            Console.WriteLine("Enter a non-negative integer:");
            if (!long.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }
            if (n < 0) { Console.WriteLine("Number must be non-negative"); return; }

            long result = 1;
            long i = 1;
            while (i <= n)
            {
                result *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {n} is {result}");
        }
    }
}
using System;

namespace Level_01
{
    public static class Problem13_SumNaturalFor
    {
        public static void Run()
        {
            Console.WriteLine("Enter n:");
            if (!long.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }
            if (n < 1) { Console.WriteLine($"The number {n} is not a natural number"); return; }

            long sumUsingLoop = 0;
            for (long i = 1; i <= n; i++) sumUsingLoop += i;

            long sumFormula = n * (n + 1) / 2;
            Console.WriteLine($"Sum using for loop = {sumUsingLoop}");
            Console.WriteLine($"Sum using formula = {sumFormula}");
            Console.WriteLine($"Results equal: {sumUsingLoop == sumFormula}");
        }
    }
}
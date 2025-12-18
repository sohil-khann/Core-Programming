using System;

namespace Level_01
{
    public static class Problem12_SumNaturalWhile
    {
        public static void Run()
        {
            Console.WriteLine("Enter n:");
            if (!long.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }
            if (n < 1) { Console.WriteLine($"The number {n} is not a natural number"); return; }

            long sumUsingLoop = 0;
            long i = 1;
            while (i <= n)
            {
                sumUsingLoop += i;
                i++;
            }

            long sumFormula = n * (n + 1) / 2;
            Console.WriteLine($"Sum using loop = {sumUsingLoop}");
            Console.WriteLine($"Sum using formula = {sumFormula}");
            Console.WriteLine($"Results equal: {sumUsingLoop == sumFormula}");
        }
    }
}
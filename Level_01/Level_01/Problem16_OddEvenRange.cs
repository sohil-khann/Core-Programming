using System;

namespace Level_01
{
    public static class Problem16_OddEvenRange
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            if (!int.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }
            if (n < 1) { Console.WriteLine($"The number {n} is not a natural number"); return; }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} is {(i % 2 == 0 ? "even" : "odd")}");
            }
        }
    }
}
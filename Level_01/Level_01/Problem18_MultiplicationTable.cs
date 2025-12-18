using System;

namespace Level_01
{
    public static class Problem18_MultiplicationTable
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            if (!int.TryParse(Console.ReadLine(), out var number)) { Console.WriteLine("Invalid input"); return; }

            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
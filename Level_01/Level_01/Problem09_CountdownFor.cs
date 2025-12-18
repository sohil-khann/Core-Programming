using System;

namespace Level_01
{
    public static class Problem09_CountdownFor
    {
        public static void Run()
        {
            Console.WriteLine("Enter countdown start:");
            if (!int.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Launch!");
        }
    }
}
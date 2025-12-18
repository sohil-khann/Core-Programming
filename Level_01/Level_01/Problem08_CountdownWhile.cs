using System;

namespace Level_01
{
    public static class Problem08_CountdownWhile
    {
        public static void Run()
        {
            Console.WriteLine("Enter countdown start:");
            if (!int.TryParse(Console.ReadLine(), out var counter)) { Console.WriteLine("Invalid input"); return; }

            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }

            Console.WriteLine("Launch!");
        }
    }
}
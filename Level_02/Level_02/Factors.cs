using System;

namespace Level_02Programs
{
    public static class Factors
    {
        public static void Run()
        {
            Console.Write("Enter an integer (>0): ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0) { Console.WriteLine("Invalid"); return; }

            Console.WriteLine("Factors:");
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) Console.WriteLine(i);
            }
        }
    }
}

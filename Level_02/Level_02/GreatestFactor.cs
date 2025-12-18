using System;

namespace Level_02Programs
{
    public static class GreatestFactor
    {
        public static void Run()
        {
            Console.Write("Enter an integer (>1): ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number <= 1) { Console.WriteLine("Invalid input"); return; }

            int greatestFactor = 1;
            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }

            Console.WriteLine($"Greatest factor besides itself: {greatestFactor}");
        }
    }
}

using System;

namespace Level_02Programs
{
    public static class PrimeCheck
    {
        public static void Run()
        {
            Console.Write("Enter an integer (>1): ");
            if (!int.TryParse(Console.ReadLine(), out int number)) { Console.WriteLine("Invalid input"); return; }

            if (number <= 1)
            {
                Console.WriteLine("Number should be greater than 1 to check prime.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }
    }
}

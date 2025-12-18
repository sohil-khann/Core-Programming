using System;

namespace Level_02Programs
{
    public static class FizzBuzzWhile
    {
        public static void Run()
        {
            Console.Write("Enter a positive integer: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0) { Console.WriteLine("Invalid input"); return; }

            int i = 0;
            while (i <= n)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
                i++;
            }
        }
    }
}

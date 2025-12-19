using System;

namespace Level_03
{
    public static class Harshad
    {
        public static void Run()
        {
            Console.Write("Enter an integer to check for Harshad: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int temp = Math.Abs(number);
            int sum = 0;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (sum == 0)
            {
                Console.WriteLine("Sum of digits is 0, cannot divide by zero.");
                return;
            }

            if (number % sum == 0)
                Console.WriteLine($"{number} is a Harshad Number.");
            else
                Console.WriteLine($"{number} is NOT a Harshad Number.");
        }
    }
}
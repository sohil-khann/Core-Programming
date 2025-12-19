using System;

namespace Level_03
{
    public static class DigitCount
    {
        public static void Run()
        {
            Console.Write("Enter an integer to count digits: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int count = 0;
            int temp = Math.Abs(number);

            if (temp == 0) // special case: 0 has 1 digit
            {
                count = 1;
            }
            else
            {
                while (temp != 0)
                {
                    temp /= 10; // remove last digit
                    count++; // increment count
                }
            }

            Console.WriteLine($"Number of digits in {number} is {count}.");
        }
    }
}
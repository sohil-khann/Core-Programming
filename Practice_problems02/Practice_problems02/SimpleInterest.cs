using System;

namespace Practice_problems02
{
    public static class SimpleInterest
    {
        public static void Run()
        {
            decimal principal;
            while (true)
            {
                Console.Write("Enter principal (amount): ");
                if (decimal.TryParse(Console.ReadLine(), out principal) && principal >= 0)
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            decimal rate;
            while (true)
            {
                Console.Write("Enter rate of interest (percent): ");
                if (decimal.TryParse(Console.ReadLine(), out rate) && rate >= 0)
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            decimal time;
            while (true)
            {
                Console.Write("Enter time (years): ");
                if (decimal.TryParse(Console.ReadLine(), out time) && time >= 0)
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            decimal simpleInterest = (principal * rate * time) / 100m;
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
    }
}
using System;

namespace Practice_problems02
{
    public static class TemperatureFtoC
    {
        public static void Run()
        {
            double fahrenheit;
            while (true)
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                if (double.TryParse(Console.ReadLine(), out fahrenheit))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double celsiusResult = (fahrenheit - 32.0) * 5.0 / 9.0;
            Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius");
        }
    }
}   
using System;

namespace Practice_problems02
{
    public static class PoundsToKg
    {
        public static void Run()
        {
            double pounds;
            while (true)
            {
                Console.Write("Enter weight (in pounds): ");
                if (double.TryParse(Console.ReadLine(), out pounds) && pounds >= 0)
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double kg = pounds * 2.2;
            Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kg}");
        }
    }
}
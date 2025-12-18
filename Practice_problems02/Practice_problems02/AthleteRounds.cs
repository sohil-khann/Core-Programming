using System;

namespace Practice_problems02
{
    public static class AthleteRounds
    {
        public static void Run()
        {
            double side1, side2, side3;

            while (true)
            {
                Console.Write("Enter side1 (meters): ");
                if (double.TryParse(Console.ReadLine(), out side1))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            while (true)
            {
                Console.Write("Enter side2 (meters): ");
                if (double.TryParse(Console.ReadLine(), out side2))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            while (true)
            {
                Console.Write("Enter side3 (meters): ");
                if (double.TryParse(Console.ReadLine(), out side3))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double perimeter = side1 + side2 + side3;
            const double targetMeters = 5000.0; 
            double rounds = perimeter > 0 ? Math.Ceiling(targetMeters / perimeter) : 0.0;

            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
        }
    }
}           
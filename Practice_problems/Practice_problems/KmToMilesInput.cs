using System;
namespace Practice_problems
{
    public class KmToMilesInput
    {
        public KmToMilesInput()
        {
            Console.Write("Enter distance in kilometers: ");
            double km = double.Parse(Console.ReadLine() ?? "0");
           
            double miles = km / 1.6;
            Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
        }
    }
}
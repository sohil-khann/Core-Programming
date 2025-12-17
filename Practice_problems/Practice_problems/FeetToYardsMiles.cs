using System;
namespace Practice_problems
{
    public class FeetToYardsMiles
    {
        public FeetToYardsMiles()
        {
            Console.Write("Enter distance in feet: ");
            double feet = double.Parse(Console.ReadLine() ?? "0");
            double yards = feet / 3.0;
            double miles = yards / 1760.0;
            Console.WriteLine($"The distance {feet} feet is {yards} yards and {miles} miles");
        }
    }
}
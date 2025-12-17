using System;
namespace Practice_problems
{
    public class TriangleArea
    {
        public TriangleArea()
        {
            Console.Write("Enter base (in inches): ");
            double baseVal = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter height (in inches): ");
            double height = double.Parse(Console.ReadLine() ?? "0");
            double areaInSqIn = 0.5 * baseVal * height;
            double areaInSqCm = areaInSqIn * Math.Pow(2.54, 2);
            Console.WriteLine($"The area of the triangle is {areaInSqIn} square inches and {areaInSqCm} square centimeters");
        }
    }
}
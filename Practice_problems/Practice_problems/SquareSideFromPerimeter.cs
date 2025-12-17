using System;
namespace Practice_problems
{
    public class SquareSideFromPerimeter
    {
        public SquareSideFromPerimeter()
        {
            Console.Write("Enter perimeter: ");
            double perimeter = double.Parse(Console.ReadLine() ?? "0");
            double side = perimeter / 4.0;
            Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
        }
    }
}
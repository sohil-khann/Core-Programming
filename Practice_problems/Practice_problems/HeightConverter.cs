using System;
namespace Practice_problems
{
    public class HeightConverter
    {
        public HeightConverter()
        {
            Console.Write("Enter height in centimeters: ");
            double cm = double.Parse(Console.ReadLine() ?? "0");
            double totalInches = cm / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches - feet * 12;
            Console.WriteLine($"Your Height in cm is {cm} while in feet is {feet} and inches is {Math.Round(inches, 2)}");
        }
    }
}
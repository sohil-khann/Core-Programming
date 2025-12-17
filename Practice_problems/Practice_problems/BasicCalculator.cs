using System;
namespace Practice_problems
{
    public class BasicCalculator
    {
        public BasicCalculator()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine() ?? "0");
            double add = a + b;
            double sub = a - b;
            double mul = a * b;
            string div = b == 0 ? "Infinity (division by zero)" : (a / b).ToString();
            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {a} and {b} is {add}, {sub}, {mul}, and {div}");
        }
    }
}
using System;

namespace Level_01
{
    public static class Problem02_SmallestOfThree
    {
        public static void Run()
        {
            Console.WriteLine("Enter number1:");
            var a = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter number2:");
            var b = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter number3:");
            var c = int.Parse(Console.ReadLine() ?? "0");

            bool isFirstSmallest = a < b && a < c;
            Console.WriteLine($"Is the first number the smallest? {isFirstSmallest}");
        }
    }
}
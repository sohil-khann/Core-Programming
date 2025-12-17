using System;
namespace Practice_problems
{
    public class MaxHandshakes
    {
        public MaxHandshakes()
        {
            Console.Write("Enter number of students: ");
            long n = long.Parse(Console.ReadLine() ?? "0");
            long handshakes = n * (n - 1) / 2;
            Console.WriteLine($"The maximum number of possible handshakes is {handshakes}");
        }
    }
}
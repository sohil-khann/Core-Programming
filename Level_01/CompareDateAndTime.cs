/*4. Problem 4: Date Comparison
Write a program that:
 Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.
Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
using DateTime methods.*/

using System;
internal static class CompareDateAndTime
{
    internal static void Main()
    {
        Console.WriteLine("Enter date in format (MM/DD/YYYY):");
        DateTime dt = DateTime.Parse(Console.ReadLine());
        DateTime dt1 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(dt, dt1);

        if (result == 0)
        {
            Console.WriteLine("Both dates are the same.");
        }
        else if (result < 0)
        {
            Console.WriteLine("The first date is earlier than the second date.");
        }
        else
        {
            Console.WriteLine("The first date is later than the second date.");
        }
    }
}
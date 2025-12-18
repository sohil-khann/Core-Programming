using System;

namespace Level_01
{
    public static class Problem07_SpringSeason
    {
        public static void Run()
        {
            Console.WriteLine("Enter month (1-12):");
            if (!int.TryParse(Console.ReadLine(), out var month)) { Console.WriteLine("Invalid input"); return; }
            Console.WriteLine("Enter day (1-31):");
            if (!int.TryParse(Console.ReadLine(), out var day)) { Console.WriteLine("Invalid input"); return; }

            // Spring: March 20 to June 20
            var dateValue = new DateTime(1, month, day);
            var start = new DateTime(1, 3, 20);
            var end = new DateTime(1, 6, 20);

            if (dateValue >= start && dateValue <= end)
                Console.WriteLine("Its a Spring Season");
            else
                Console.WriteLine("Not a Spring Season");
        }
    }
}
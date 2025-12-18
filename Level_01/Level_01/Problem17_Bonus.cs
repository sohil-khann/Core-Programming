using System;

namespace Level_01
{
    public static class Problem17_Bonus
    {
        public static void Run()
        {
            Console.WriteLine("Enter salary:");
            if (!double.TryParse(Console.ReadLine(), out var salary)) { Console.WriteLine("Invalid input"); return; }
            Console.WriteLine("Enter years of service:");
            if (!int.TryParse(Console.ReadLine(), out var years)) { Console.WriteLine("Invalid input"); return; }

            if (years > 5)
            {
                var bonus = salary * 0.05;
                Console.WriteLine($"Bonus amount = {bonus}");
            }
            else
            {
                Console.WriteLine("No bonus");
            }
        }
    }
}
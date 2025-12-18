using System;

namespace Level_02Programs
{
    public static class BMI
    {
        public static void Run()
        {
            Console.Write("Enter weight (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double weight)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter height (cm): ");
            if (!double.TryParse(Console.ReadLine(), out double heightCm)) { Console.WriteLine("Invalid input"); return; }

            double heightM = heightCm / 100.0;
            if (heightM <= 0) { Console.WriteLine("Invalid height"); return; }

            double bmi = weight / (heightM * heightM);
            string status;

            if (bmi <= 18.4) status = "Underweight";
            else if (bmi <= 24.9) status = "Normal";
            else if (bmi <= 39.9) status = "Overweight";
            else status = "Obese";

            Console.WriteLine($"BMI: {bmi:F2} - {status}");
        }
    }
}

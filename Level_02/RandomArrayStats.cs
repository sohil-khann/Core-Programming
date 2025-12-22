/*
12. Write a program that generates five 4 digit random values and then finds their average value, and their minimum and maximum value. Use Math.Random(), Math.Min(), and Math.Max(). Hint =>
a. Write a method that generates array of 4 digit random numbers given the size as a parameter as shown in the method signature public int[] Generate4DigitRandomArray(int size)
b. Write a method to find average, min and max value of an array public double[] FindAverageMinMax(int[] numbers)
*/

using System;
using System.Linq;

namespace Level_02
{
    public class RandomArrayStats
    {
        public static void runMethod()
        {
            RandomArrayStats app = new RandomArrayStats();
            int[] randomNumbers = app.Generate4DigitRandomArray(5);

            Console.WriteLine("Generated 4-digit random numbers:");
            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num);
            }

            double[] stats = app.FindAverageMinMax(randomNumbers);
            Console.WriteLine($"\nAverage: {stats[0]:F2}");
            Console.WriteLine($"Minimum: {stats[1]}");
            Console.WriteLine($"Maximum: {stats[2]}");
        }

        public int[] Generate4DigitRandomArray(int size)
        {
            Random rand = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                // 4-digit numbers range from 1000 to 9999
                numbers[i] = rand.Next(1000, 10000);
            }
            return numbers;
        }

        public double[] FindAverageMinMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return new double[] { 0, 0, 0 };
            }

            double sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }

            double average = sum / numbers.Length;

            return new double[] { average, (double)min, (double)max };
        }
    }
}

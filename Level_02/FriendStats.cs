/*
8. Create a program to find the youngest friends among 3 Amar, Akbar and Anthony based on their ages and tallest among the friends based on their heights and display it Hint =>
a. Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
b. Write a Method to find the youngest of the 3 friends
c. Write a Method to find the tallest of the 3 friends
*/

using System;

namespace Level_02
{
    public class FriendStats
    {
        private static string[] Names = { "Amar", "Akbar", "Anthony" };

        public static void runMethod()
        {
            int[] ages = new int[3];
            double[] heights = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for {Names[i]}:");
                
                Console.Write("Age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    ages[i] = age;
                }

                Console.Write("Height (in cm): ");
                if (double.TryParse(Console.ReadLine(), out double height))
                {
                    heights[i] = height;
                }
                Console.WriteLine();
            }

            int youngestIndex = FindYoungestIndex(ages);
            int tallestIndex = FindTallestIndex(heights);

            Console.WriteLine($"The youngest friend is {Names[youngestIndex]} with age {ages[youngestIndex]}.");
            Console.WriteLine($"The tallest friend is {Names[tallestIndex]} with height {heights[tallestIndex]} cm.");
        }

        public static int FindYoungestIndex(int[] ages)
        {
            int minIndex = 0;
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int FindTallestIndex(double[] heights)
        {
            int maxIndex = 0;
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}

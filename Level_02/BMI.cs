/*An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in
the team. For this create a program to find the BMI and display the height, weight, BMI and
status of each individual
Hint =>
a. Take input for a number of persons
b. Create arrays to store the weight, height, BMI, and weight status of the persons
c. Take input for the weight and height of the persons
d. Calculate the BMI of all the persons and store them in an array and also find the weight
status of the persons
e. Display the height, weight, BMI, and weight status of each person
f. Use the table to determine the weight status of the person*/

using System;
internal static class BMI
{
    internal static void runMethod()
    {
        Console.WriteLine("Enter number of persons:");
        int n = int.Parse(Console.ReadLine());
        double[] weights = new double[n];
        double[] heights = new double[n];
        double[] bmis = new double[n];
        string[] statuses = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter weight (in kg) of person {i + 1}:");
            weights[i] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter height (in meters) of person {i + 1}:");
            heights[i] = double.Parse(Console.ReadLine());
            bmis[i] = weights[i] / (heights[i] * heights[i]);
            if (bmis[i] < 18.5)
                statuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
                statuses[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] < 29.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obesity";
        }
      
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Height : {heights[i]}  Weight : {weights[i]}  BMI : {bmis[i]}  Status : {statuses[i]}\n");
        }
    }
}
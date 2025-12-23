/*Write a program Euclidean distance between two points as well as the equation of
the line using those two points. Use Math functions Math.Pow() and Math.Sqrt()
Hint =>
a. Take inputs for 2 points x1, y1, and x2, y2
b. Method to find the Euclidean distance between two points and return the distance
distance = (x2-x1)2 +(y2-y1)2
d. Write a Method to find the equation of a line given two points and return the equation
which includes the slope and the y-intercept
The equation of a line is given by the equation y = m*x + b Where m is the slope and b is the
y-intercept. So firstly compute the slope using the formulae
m = (y2 - y1)/(x2 - x1)
Post that compute the y-intercept b using the formulae
b = y1 - m*x1
Finally, return an array having slope m and y-intercept b*/
using System;
internal static class DistanceBetweenTwoPoints
{
    internal static void Main()
    {
        Console.WriteLine("Enter coordinates of first point (x1 y1): ");
        string[] point1 = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(point1[0]);
        double y1 = Convert.ToDouble(point1[1]);
        Console.WriteLine("Enter coordinates of second point (x2 y2): ");
        string[] point2 = Console.ReadLine().Split(' ');
        double x2 = Convert.ToDouble(point2[0]);
        double y2 = Convert.ToDouble(point2[1]);
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"Euclidean Distance: {distance}");
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Line Equation: y = {lineEquation[0]}*x + {lineEquation[1]}");
    }
    private static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    private static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }
}

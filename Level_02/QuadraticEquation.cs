/*
11. Write a program Quadratic to find the roots of the equation ax2+ bx + c. Use Math functions Math.pow() and Math.sqrt() Hint =>
a. Take a, b, and c as input values to find the roots of x.
b. The roots are computed using the following formulae delta = b2+ 4*a*c If delta is positive the find the two roots using formulae root1 of x = (-b + delta)/(2*a) root1 of x = (-b - delta)/(2*a) If delta is zero then there is only one root of x root of x = -b/(2*a) If delta is negative return empty array or nothing
c. Write a Method to find find the roots of a quadratic equation and return the roots
*/

using System;

namespace Level_02
{
    public class QuadraticEquation
    {
        public static void runMethod()
        {
            Console.WriteLine("Enter coefficients for quadratic equation (ax^2 + bx + c = 0):");
            
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double[] roots = FindRoots(a, b, c);

            if (roots.Length == 2)
            {
                Console.WriteLine($"Two real roots found: {roots[0]:F4} and {roots[1]:F4}");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"One real root found: {roots[0]:F4}");
            }
            else
            {
                Console.WriteLine("No real roots exist.");
            }
        }

        public static double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[] { };
            }
        }
    }
}

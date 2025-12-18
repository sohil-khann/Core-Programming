using System;
public class IntOperation
{
	public IntOperation()
	{
		Console.Write("Enter first integer: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter second integer: ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter Third integer: ");
		int c = Convert.ToInt32(Console.ReadLine());

		int sum = a + (b * c);
		int difference = (a * b) + c;
		int product = c + (a / b);
		double quotient = (a % b) +c;
		Console.WriteLine($"Result of a + b * c: {sum}");
		Console.WriteLine($"Result of a * b + c: {difference}");
		Console.WriteLine($"Result of  c + a / b: {product}");
		Console.WriteLine($"Result of a % b +c: {quotient}");
	}
}
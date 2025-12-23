/*Problem 2: Date Arithmetic
Create a program that:
 Takes a date input and adds 7 days, 1 month, and 2 years to it.
 Then subtracts 3 weeks from the result.
Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(),
and DateTime.AddWeeks() methods.*/

using System;
internal class DateArithmatic
{
	// Main Method
	internal static void Main()
	{
		Console.Write("enter date in mm-dd-yyyy format :");
		DateTime dt = DateTime.Parse(Console.ReadLine());

		//logic to add 7 days ,1 month and 2 years
		dt = dt.AddDays(7).AddMonths(1).AddYears(2);

		Console.WriteLine($"{dt.ToString()}");
	}
}
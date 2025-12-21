using System;
/*
7.Demonstrate FormatException
 Hint =>
 Use int.Parse() on a non-numeric string to generate FormatException.
 Use try-catch to handle the exception.
*/
using System;

internal static class DemonstrateFormatException
{
    public static void ParseNonNumericString()
    {
        Console.Write("Enter a value to parse as integer: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            Console.WriteLine($"Parsed number: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"FormatException: '{input}' is not a valid integer format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("OverflowException: The number is too large or too small.");
        }
    }

    public static void ParseWithTryParse()
    {
        Console.Write("Enter a value: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            Console.WriteLine($"Successfully parsed: {result}");
        }
        else
        {
            Console.WriteLine($"Could not parse '{input}' as an integer.");
        }
    }
}

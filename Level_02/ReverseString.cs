/*
 * Problem 2: Reverse a String
 * Write a C# program to reverse a given string without using any built-in reverse functions.
 */

public class StringReverser
{
    public static string ReverseString(string input)
    {
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;
    }

    public static void DisplayReversedString(string input)
    {
        string result = ReverseString(input);
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Reversed: {result}");
        Console.WriteLine();
    }
}

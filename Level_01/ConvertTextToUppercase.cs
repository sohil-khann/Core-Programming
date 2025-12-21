/*Convert Text to Uppercase
 Hint =>
 Write a method to convert each character in a string to uppercase using ASCII
logic (char manipulation).
 Compare the result with the built-in string.ToUpper().*/
using System;

internal static class ConvertTextToUppercase
{
    public static string ManualToUppercase(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (c >= 'a' && c <= 'z')
            {
                result[i] = (char)(c - 32);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }

    public static void CompareUppercaseMethods()
    {
        Console.Write("Enter text to convert: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        string manualResult = ManualToUppercase(input);
        string builtInResult = input.ToUpper();

        Console.WriteLine($"\nOriginal text: {input}");
        Console.WriteLine($"Manual conversion: {manualResult}");
        Console.WriteLine($"Built-in ToUpper(): {builtInResult}");

        if (manualResult == builtInResult)
        {
            Console.WriteLine("\nBoth methods produce identical results.");
        }
        else
        {
            Console.WriteLine("\nResults differ.");
        }
    }
}

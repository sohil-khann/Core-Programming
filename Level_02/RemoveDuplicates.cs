/*
 * Problem 4: Remove Duplicates from a String
 * Write a C# program to remove all duplicate characters from a given string 
 * and return the modified string.
 */

public class DuplicateRemover
{
    public static string RemoveDuplicates(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            bool found = false;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == c)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                result += c;
            }
        }
        return result;
    }

    public static void DisplayDuplicatesRemoved(string input)
    {
        string result = RemoveDuplicates(input);
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Without Duplicates: {result}");
        Console.WriteLine();
    }
}

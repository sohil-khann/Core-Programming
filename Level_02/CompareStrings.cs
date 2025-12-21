/*
 * Problem 8: Compare Two Strings
 * Write a C# program to compare two strings lexicographically (dictionary order) 
 * without using built-in compare methods.
 * Example Input:
 * String 1: "apple"
 * String 2: "banana"
 * Expected Output:
 * "apple" comes before "banana" in lexicographical order
 */

public class LexicographicComparator
{
    public static int CompareStrings(string str1, string str2)
    {
        int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                return -1;
            }
            else if (str1[i] > str2[i])
            {
                return 1;
            }
        }

        if (str1.Length < str2.Length)
            return -1;
        else if (str1.Length > str2.Length)
            return 1;
        else
            return 0;
    }

    public static void CompareTwoStrings(string str1, string str2)
    {
        int result = CompareStrings(str1, str2);
        Console.WriteLine($"String 1: {str1}");
        Console.WriteLine($"String 2: {str2}");

        if (result < 0)
            Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
        else if (result > 0)
            Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order");
        else
            Console.WriteLine($"\"{str1}\" and \"{str2}\" are equal");

        Console.WriteLine();
    }
}

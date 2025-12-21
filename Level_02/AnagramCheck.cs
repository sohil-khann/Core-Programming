/*
 * Problem 11: Check if Two Strings are Anagrams
 * Write a C# program that accepts two strings from the user and checks if the two 
 * strings are anagrams of each other (i.e., whether they contain the same characters 
 * in any order).
 */

public class AnagramChecker
{
    public static bool AreAnagrams(string str1, string s   tr2)
    {
        string s1 = "";
        string s2 = "";

        foreach (char c in str1)
        {
            if (char.IsLetter(c))
            {
                s1 += char.ToLower(c);
            }
        }

        foreach (char c in str2)
        {
            if (char.IsLetter(c))
            {
                s2 += char.ToLower(c);
            }
        }

        if (s1.Length != s2.Length)
            return false;

        bool[] found = new bool[s2.Length];

        for (int i = 0; i < s1.Length; i++)
        {
            bool charFound = false;
            for (int j = 0; j < s2.Length; j++)
            {
                if (!found[j] && s1[i] == s2[j])
                {
                    found[j] = true;
                    charFound = true;
                    break;
                }
            }
            if (!charFound)
                return false;
        }

        return true;
    }

    public static void CheckAnagrams(string str1, string str2)
    {
        bool result = AreAnagrams(str1, str2);
        Console.WriteLine($"String 1: {str1}");
        Console.WriteLine($"String 2: {str2}");
        Console.WriteLine($"Are Anagrams: {result}");
        Console.WriteLine();
    }
}

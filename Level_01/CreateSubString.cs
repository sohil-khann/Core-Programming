/*Create a Substring Using charAt()
Hint =>
o Take user input using Console.ReadLine() for string, start index, and end
index.
o Write a method to create a substring using charAt() (string[index] in C#).
o Use string.Substring() to generate the substring and compare the results.
*/
using System.Text;

internal static class CreateSubString
{
    public static void Substring()
    {
        Console.Write("Type a String : ");
        String str = Console.ReadLine();
        Console.Write("Type Start Index : ");
        int startIndex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type End Index : ");
        int endIndex = Convert.ToInt32(Console.ReadLine());
        // string[index] in C#)
        StringBuilder substring = new StringBuilder();
        for (int i = startIndex; i < endIndex; i++)
        {
            substring.Append(str[i]);
        }
        Console.WriteLine($"Substring using c: {substring.ToString()}");
        // Using built-in string.Substring()
        String substringUsingBuiltIn = str.Substring(startIndex, endIndex - startIndex);
        Console.WriteLine($"Substring using built-in method: {substringUsingBuiltIn}");
        // Compare the results
        if (substring.ToString().Equals(substringUsingBuiltIn))
        {
            Console.WriteLine("Both substrings are equal.");
        }
        else
        {
            Console.WriteLine("Substrings are not equal.");
        }
    }
}
/*
 * Problem 9: Find the Most Frequent Character
 * Write a C# program to find the most frequent character in a string.
 * Example Input:
 * String: "success"
 * Expected Output:
 * Most Frequent Character: 's'
 */

public class FrequentCharacterFinder
{
    public static char FindMostFrequentCharacter(string input)
    {
        char mostFrequent = input[0];
        int maxCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = input[i];
            }
        }

        return mostFrequent;
    }

    public static void DisplayMostFrequentCharacter(string input)
    {
        char result = FindMostFrequentCharacter(input);
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Most Frequent Character: {result}");
        Console.WriteLine();
    }
}

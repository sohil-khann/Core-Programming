using System;
using System.Collections.Generic;

internal static class SplitTextIntoWords
{
    public static List<string> ExtractWords(string text)
    {
        List<string> words = new List<string>();
        string currentWord = string.Empty;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ' || text[i] == '\t' || text[i] == '\n')
            {
                if (currentWord.Length > 0)
                {
                    words.Add(currentWord);
                    currentWord = string.Empty;
                }
            }
            else
            {
                currentWord += text[i];
            }
        }

        if (currentWord.Length > 0)
        {
            words.Add(currentWord);
        }

        return words;
    }

    public static int GetStringLength(string text)
    {
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            count++;
        }

        return count;
    }

    public static void AnalyzeTextWords()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        List<string> words = ExtractWords(input);

        Console.WriteLine($"\nTotal words found: {words.Count}");
        Console.WriteLine("\nWord Analysis:");
        Console.WriteLine("Word | Length");
        Console.WriteLine("-----|---------");

        foreach (string word in words)
        {
            int length = GetStringLength(word);
            Console.WriteLine($"{word,-4} | {length}");
        }

        Console.WriteLine("\n--- Built-in Split() Method ---");
        string[] splitWords = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Words from Split(): {splitWords.Length}");
        Console.WriteLine("Words match: " + (words.Count == splitWords.Length ? "Yes" : "No"));
    }

    public static string[][] GetWordLengthsArray(string text)
    {
        List<string> words = ExtractWords(text);
        string[][] result = new string[words.Count][];

        for (int i = 0; i < words.Count; i++)
        {
            result[i] = new string[2];
            result[i][0] = words[i];
            result[i][1] = GetStringLength(words[i]).ToString();
        }

        return result;
    }
}

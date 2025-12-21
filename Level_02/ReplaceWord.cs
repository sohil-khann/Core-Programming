/*
 * Problem 12: Replace a Word with Another Word in a Sentence
 * Write a replace method in C# that replaces a given word with another word 
 * in a sentence.
 */

public class WordReplacer
{
    public static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        int i = 0;

        while (i < sentence.Length)
        {
            bool match = true;

            if (i + oldWord.Length <= sentence.Length)
            {
                for (int j = 0; j < oldWord.Length; j++)
                {
                    if (sentence[i + j] != oldWord[j])
                    {
                        match = false;
                        break;
                    }
                }
            }
            else
            {
                match = false;
            }

            if (match)
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += sentence[i];
                i++;
            }
        }

        return result;
    }

    public static void DisplayWordReplaced(string sentence, string oldWord, string newWord)
    {
        string result = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine($"Original Sentence: {sentence}");
        Console.WriteLine($"Old Word: {oldWord}");
        Console.WriteLine($"New Word: {newWord}");
        Console.WriteLine($"Modified Sentence: {result}");
        Console.WriteLine();
    }
}

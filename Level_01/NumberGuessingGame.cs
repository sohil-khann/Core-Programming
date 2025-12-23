/*Problem Statements for Practice in C#
1. Number Guessing Game:
Write a program where the user thinks of a number between 1 and 100, and the computer
tries to guess the number by generating random guesses.
 The user provides feedback by indicating whether the guess is high, low, or correct.
 The program should be modular, with different functions for generating guesses,
receiving user feedback, and determining the next guess.
*/
using System;
internal class NumberGuessingGame
{
    private static Random random = new Random();
    private static int GenerateGuess(int min, int max)
    {
        return random.Next(min, max + 1);
    }
    private static string GetUserFeedback(int guess)
    {
        Console.WriteLine($"Is your number {guess}? (h for high, l for low, c for correct): ");
        return Console.ReadLine().ToLower();
    }
    public static void Main()
    {
        int min = 1;
        int max = 100;
        string feedback = "";
        int guess;
        Console.WriteLine("Think of a number between 1 and 100. I will try to guess it");
        while (feedback != "c")
        {
            guess = GenerateGuess(min, max);
            feedback = GetUserFeedback(guess);
            if (feedback == "h")
            {
                max = guess - 1;
            }
            else if (feedback == "l")
            {
                min = guess + 1;
            }
            else if (feedback != "c")
            {
                Console.WriteLine("Invalid input. Please enter 'h', 'l', or 'c'.");
            }
        }

        Console.WriteLine("I guessed your number");
    }
}
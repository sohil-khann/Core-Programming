/*5. Palindrome Checker:
Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
that reads the same backward as forward).
Break the program into functions for input, checking the palindrome condition, and
displaying the result.*/

using System;
internal class Palindrome
{
	private static string GetInput() 
		//for taking input
	{
		Console.Write("Enter a string to check if it's a palindrome: ");
		return Console.ReadLine();
	}
	private static bool IsPalindrome(string str)
		//for checking palindrome
	{
		int left = 0;
		int right = str.Length - 1;
		// Compare characters from both ends
		while (left < right)
		{
			if (str[left] != str[right])
			{
				return false;
			}
			left++;
			right--;
		}
		return true;
	}
	private static void DisplayResult(string str, bool isPalindrome) 
		//for displaying result
	{
		if (isPalindrome)
		{
			Console.WriteLine($"\"{str}\" is a palindrome.");
		}
		else
		{
			Console.WriteLine($"\"{str}\" is not a palindrome.");
		}
	}
	public static void Main()
		//entry point
	{
		string inputStr = GetInput();
		bool result = IsPalindrome(inputStr);
		DisplayResult(inputStr, result);
	}
}

/*2. Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to Find the count of digits in the number
b. Method to Store the digits of the number in a digits array
c. Method to Check if a number is a duck number using the digits array. A duck number
is a number that has a non-zero digit present in it
d. Method to check if the number is an armstrong number using the digits array.
Armstrong number is a number that is equal to the sum of its own digits raised to the power
of the number of digits. Eg: 153 = 1^3 + 5^3 + 3^3
e. Method to find the largest and second largest elements in the digits array. Use
Int32.MinValue to initialize the variable.
f. Method to find the smallest and second smallest elements in the digits array. Use
Int32.MaxValue to initialize the variable.*/using System;internal static class NumberChecker{    internal static void Main()    {        Console.WriteLine("enter Number");        int number = int.Parse(Console.ReadLine()); // Example number        int digitCount = CountDigits(number);        int[] digitsArray = StoreDigits(number);        bool isDuck = IsDuckNumber(digitsArray);
        Console.WriteLine($"Number: {number}");        Console.WriteLine($"Digit Count: {digitCount}");        Console.WriteLine($"Digits Array: [{string.Join(", ", digitsArray)}]");        Console.WriteLine($"Is Duck Number: {isDuck}");        bool isArmstrong = IsArmstrongNumber(number, digitsArray);        (int largest, int secondLargest) = FindLargestAndSecondLargest(digitsArray);        (int smallest, int secondSmallest) = FindSmallestAndSecondSmallest(digitsArray);               Console.WriteLine($"Is Armstrong Number: {isArmstrong}");        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");        Console.WriteLine($"Smallest: {smallest}, Second Smallest: {secondSmallest}");    }    internal static int CountDigits(int number)    {        return number.ToString().Length;    }    internal static int[] StoreDigits(int number)    {        string numStr = number.ToString();        int[] digits = new int[numStr.Length];        for (int i = 0; i < numStr.Length; i++)        {            digits[i] = int.Parse(numStr[i].ToString());        }        return digits;    }    internal static bool IsDuckNumber(int[] digits)    {        foreach (int digit in digits)        {            if (digit != 0)            {                return true;            }        }        return false;    }    internal static bool IsArmstrongNumber(int number, int[] digits)    {        int sum = 0;        int power = digits.Length;        foreach (int digit in digits)        {            sum += (int)Math.Pow(digit, power);        }        return sum == number;    }    internal static (int, int) FindLargestAndSecondLargest(int[] digits)    {        int largest = Int32.MinValue;        int secondLargest = Int32.MinValue;        Array.Sort(digits);
        largest = digits[digits.Length - 1];
        secondLargest = digits.Length > 1 ? digits[digits.Length - 2] : Int32.MinValue;
        //foreach (int digit in digits)
        //{
        //    if (digit > largest)
        //    {
        //        secondLargest = largest;
        //        largest = digit;
        //    }
        //    else if (digit > secondLargest && digit != largest)
        //    {
        //        secondLargest = digit;
        //    }
        //}
        return (largest, secondLargest);    }    internal static (int, int) FindSmallestAndSecondSmallest(int[] digits)    {        int smallest = Int32.MaxValue;        int secondSmallest = Int32.MaxValue;        Array.Sort(digits);
        smallest = digits[0];
        secondSmallest = digits.Length > 1 ? digits[1] : Int32.MaxValue;

        //foreach (int digit in digits)
        //{
        //    if (digit < smallest)
        //    {
        //        secondSmallest = smallest;
        //        smallest = digit;
        //    }
        //    else if (digit < secondSmallest && digit != smallest)
        //    {
        //        secondSmallest = digit;
        //    }
        //}
        return (smallest, secondSmallest);    }    }
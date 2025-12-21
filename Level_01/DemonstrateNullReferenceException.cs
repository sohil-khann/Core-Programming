/*4. Demonstrate NullReferenceException
 Hint =>
 Write a method to demonstrate NullReferenceException by accessing a
method on a null string.
 Use a try-catch block to handle the exception.*/
using System;

internal static class DemonstrateNullReferenceException
{
    public static void HandleNullReference()
    {
        string nullString = null;

        try
        {
            Console.WriteLine("Attempting to call method on null string...");
            int length = nullString.Length;
            Console.WriteLine($"String length: {length}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Caught NullReferenceException!");
            Console.WriteLine($"Error message: {ex.Message}");
        }
    }

    public static void DemonstrateNullCheck()
    {
        try
        {
            string value = null;
            string result = value.ToUpper();
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Cannot invoke method on null object reference.");
        }
    }
}

/*Create a program to take a number as input and reverse the number. To do this, store the
digits of the number in an array and display the array in reverse order
Hint =>
a. Take user input for a number.
b. Find the count of digits in the number.
c. Find the digits in the number and save them in an array
d. Create an array to store the elements of the digits array in reverse order
e. Finally, display the elements of the array in reverse order

 */


using System;
public static class ReverseTheNum
{
    public static void runMethod()
    {
        
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            int temp = number;
            int Count = 0;
            while (temp != 0)
            {
                Count++; // count it for array size
            temp /= 10;
            }
            int[] arr = new int[Count];
            temp = number;
            for (int i = 0; i < Count; i++)
            {
                arr[i] = temp % 10;
                temp /= 10;
            }
        Console.Write("Reversed number is: ");
        foreach (int a in arr) {

            Console.Write(a);
        }
        Console.WriteLine();
        

    }
}

using System;
public class AddTwoNum 
{
  
    public static void PrintMessage(int s)
    {
        Console.WriteLine("Sum is " + s);


    }
    public int Add(int a, int b)
    {

        return a + b;
    }

   
    public void sub(int a, int b)
    {
        Console.WriteLine("Subtraction using void method is " + (a - b));
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public int Divide(int a, int b)
    {
        return a / b;
    }

}
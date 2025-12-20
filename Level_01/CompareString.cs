/*1.Compare Two Strings Using charAt()
Hint =>
o Take user input using Console.ReadLine().
o Create a method to compare two strings using CharAt() logic(string[index] in
C#).
o Compare the result with the built -in string.Equals().*/
using System;
internal static class CompareString
{
    public static void compare()
    {
        Console.Write("Type String 1 : ");
        String first = Console.ReadLine();
        Console.WriteLine("Type String 2 : ");
        String second = Console.ReadLine();

        if(first.Length != second.Length)
        {
            Console.WriteLine("Strings are not equal");
            return;
        }
        else
        {
            for(int i = 0; i < first.Length; i++)
            {

                if (first[i] != second[i])
                {
                    Console.WriteLine("Strings are not equal");
                    return ;
                }
                else
                {

                    Console.WriteLine($" {first}  equal to  {second}");
                    return;


                }

            }
        }
    }
   

}
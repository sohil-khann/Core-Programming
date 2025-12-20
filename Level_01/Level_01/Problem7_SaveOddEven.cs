using System;

public static class Problem7_SaveOddEven
{
    public static void run()
    {
        Console.Write("Enter a natural number: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Input must be a natural number.");
            return;
        }

        int size = number / 2 + 1;
        int[] evens = new int[size];
        int[] odds = new int[size];
        int eIdx = 0, oIdx = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) evens[eIdx++] = i;
            else odds[oIdx++] = i;
        }

        Console.WriteLine("Even numbers:");
        for (int i = 0; i < eIdx; i++) Console.WriteLine(evens[i]);

        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oIdx; i++) Console.WriteLine(odds[i]);
    }
}

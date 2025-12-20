using System;

public static class Problem5_MultiplicationTable6to9
{
    public static void run()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        int[] results = new int[4]; // for 6,7,8,9
        int idx = 0;
        for (int i = 6; i <= 9; i++)
        {
            results[idx++] = number * i;
        }

        Console.WriteLine();
        idx = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {results[idx++]}");
        }
    }
}

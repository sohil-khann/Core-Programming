using System;

public static class Problem8_FactorsDynamicArray
{
    public static void run()
    {
        Console.Write("Enter a number to find its factors: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Enter a positive integer.");
            return;
        }

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int idx = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (idx == maxFactor)
                {
                    int newMax = maxFactor * 2;
                    int[] temp = new int[newMax];
                    for (int j = 0; j < factors.Length; j++) temp[j] = factors[j];
                    factors = temp;
                    maxFactor = newMax;
                }
                factors[idx++] = i;
            }
        }

        Console.WriteLine("Factors:");
        for (int i = 0; i < idx; i++) Console.WriteLine(factors[i]);
    }
}

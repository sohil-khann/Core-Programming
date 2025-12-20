using System;

public static class Problem4_StoreUpToTenOrUntilNonPositive
{
    public static void run()
    {
        double[] arr = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter positive numbers (enter 0 or a negative number to stop):");
        while (true)
        {
            Console.Write($"Number {index + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                Console.WriteLine("Invalid input, try again.");
                continue;
            }

            if (value <= 0 || index == 10)
            {
                break;
            }

            arr[index++] = value;
            if (index == 10) break;
        }

        Console.WriteLine();
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine($"Value {i + 1}: {arr[i]}");
            total += arr[i];
        }

        Console.WriteLine($"Sum of entered numbers: {total}");
    }
}

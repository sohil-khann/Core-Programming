using System;
public

    class RemainderAndQuat
{
    public RemainderAndQuat()
    {
        Console.Write("Enter dividend and divisor:");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter divisor");
        int divisor = Convert.ToInt32(Console.ReadLine());
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        Console.WriteLine($"Dividend: {dividend}");
        Console.WriteLine($"Divisor: {divisor}");
        Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"Remainder: {remainder}");
    }
}   
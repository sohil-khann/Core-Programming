using System;
namespace Practice_problems
{
    public class TotalPurchasePrice
    {
        public TotalPurchasePrice()
        {
            Console.Write("Enter unit price (INR): ");
            double unitPrice = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine() ?? "0");
            double total = unitPrice * quantity;
            Console.WriteLine($"The total purchase price is INR {total} if the quantity {quantity} and unit price is INR {unitPrice}");
        }
    }
}
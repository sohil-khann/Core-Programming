using System;
namespace Practice_problems
{
    public class CourseDiscountInput
    {
        public CourseDiscountInput()
        {
            Console.Write("Enter fee (INR): ");
            double fee = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter discount percent: ");
            double discountPercent = double.Parse(Console.ReadLine() ?? "0");
            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;
            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
        }
    }
}
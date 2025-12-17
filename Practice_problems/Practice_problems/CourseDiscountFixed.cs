using System;
namespace Practice_problems
{
    public class CourseDiscountFixed
    {
        public CourseDiscountFixed()
        {
            double fee = 125000;
            double discountPercent = 10;
            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;
            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
        }
    }
}
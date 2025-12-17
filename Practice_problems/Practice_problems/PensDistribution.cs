using System;
namespace Practice_problems
{
    public class PensDistribution
    {
        public PensDistribution()
        {
            int totalPens = 14;
            int students = 3;
            int pensPerStudent = totalPens / students;
            int remaining = totalPens % students;
            Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remaining}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_problems
{
    internal class AvgMarks
    {
            public AvgMarks(int phy, int chem, int math)
        {
            int avg = (phy+chem+math)/3;
            Console.WriteLine("Avg is  :"+avg);
        
        }

    }
}

using System;
public static class CheckVoteEligibility
{
    public static void run() {
        int size = 10;
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter your age :");
            arr[i] = Convert.ToInt32(Console.ReadLine());


        }
        foreach(int n in arr) {
            if (n >= 18)
            {
                Console.WriteLine($"The student with the age {n} can vote");
            }
            else
            {
                Console.WriteLine($"The student with the age {n} cannot vote");
            }

        }
    }
    
}
/*
7. Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18. Hint =>
a. Create a class public class StudentVoteChecker and define a method public boolean CanStudentVote(int age) which takes in age as a parameter and returns true or false
b. Inside the method firstly validate the age for a negative number, if a negative return is false cannot vote. For valid age check for age is 18 or above return true; else return false;
c. In the main function define an array of 10 integer elements, loop through the array by take user input for the student's age, call CanStudentVote() and display the result
*/

using System;

namespace Level_02
{
    public class StudentVoteChecker
    {
        public bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false;
            }

            return age >= 18;
        }

        public static void runMethod()
        {
            StudentVoteChecker checker = new StudentVoteChecker();
            int[] studentAges = new int[10];

            Console.WriteLine("Please enter the ages of 10 students:");

            for (int i = 0; i < studentAges.Length; i++)
            {
                Console.Write($"Enter age for student {i + 1}: ");
                string? input = Console.ReadLine();
                
                if (input != null && int.TryParse(input, out int age))
                {
                    studentAges[i] = age;
                    bool canVote = checker.CanStudentVote(age);
                    
                    if (canVote)
                    {
                        Console.WriteLine($"Student {i + 1} (Age: {age}) is eligible to vote.");
                    }
                    else
                    {
                        Console.WriteLine($"Student {i + 1} (Age: {age}) is NOT eligible to vote.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                    i--; // Repeat for the same student index
                }
            }
        }
    }
}

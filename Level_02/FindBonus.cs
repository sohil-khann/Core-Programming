/*1.Create a program to find the bonus of 10 employees based on their years of service and the
total bonus amount the company Zara has to pay, along with the old and new salary.
Hint =>
a.Zara decides to give a bonus of 5% to employees whose year of service is more than 5
years or 2% if less than 5 years
b. Define a double array to save salary and years of service for each of the 10 employees
c. Also define a double array to save the new salary and the bonus amount as well as
variables to save the total bonus, total old salary, and new salary
d.Define a loop to take input from the user. If salary or year of service is an invalid number
then ask the user to enter again. Note in this case you will have to decrement the index
counter
e.Define another loop to calculate the bonus of 10 employees based on their years of
service.Save the bonus in the array, compute the new salary, and save in the array.
Also, the total bonus and total old and new salary can be calculated in the loop
f. Print the total bonus payout as well as the total old and new salary of all the employees*/


using System;
internal static class FindBonus
{
    public static void runMethod()
    {
        const int employeeCount = 10;
        double[] salaries = new double[employeeCount];

        double[] yearsOfService = new double[employeeCount];

        double[] bonuses = new double[employeeCount];
        double[] newSalaries = new double[employeeCount];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        // Input loop
        for (int i = 0; i < employeeCount; i++)
        {
            while (true)
            {
                Console.Write($"Enter salary for employee {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double salary) && salary > 0)
                {
                    salaries[i] = salary;
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a valid salary.");
                }
            }
            while (true)
            {
                Console.Write($"Enter years of service for employee {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double years) && years >= 0)
                {
                    yearsOfService[i] = years;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of years.");
                }
            }
        }
        // Calculation loop
        for (int i = 0; i < employeeCount; i++)
        {
            double bonusRate = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusRate;
            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }
        // Output results
            Console.WriteLine($"\nTotal Bonus Payout: {totalBonus:C}");
 
               Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
          Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
    }
}
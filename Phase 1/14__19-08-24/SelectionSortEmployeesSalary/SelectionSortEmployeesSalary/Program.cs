//Question 2
//Implement an Abstract Class with Method Overriding and Salary Comparison

//Task: Create an abstract class `Employee` with an abstract method `CalculateSalary()`. 
//Derive two classes `FullTimeEmployee` and `PartTimeEmployee` from `Employee`.

//Requirements:

//1.FullTimeEmployee: 
//   -Properties: `BaseSalary` and `BonusPercentage`.
//   - Implement the `CalculateSalary()` method to return the total salary, including the bonus.

//2. PartTimeEmployee: 
//   -Properties: `HourlyRate` and `HoursWorked`.
//   - Implement the `CalculateSalary()` method to return the total earnings based on hours worked.

//3. Input N employee details (using an array). 

//4.Print employees before sorting. Sort employees using selection sort. Print sorted employees.


using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using static SelectionSortEmployeesSalary.Program;

namespace SelectionSortEmployeesSalary
{
    internal class Program
    {
        public abstract class Employee
        {
            public abstract double CalculateSalary();
        }

        public class FullTimeEmployee : Employee
        {
            public int BaseSalary { get; set; }
            public int BonusPercentage { get; set; }

            public FullTimeEmployee()
            {
            }

            public FullTimeEmployee(int baseSalary, int bonusPercentage)
            {
                BaseSalary = baseSalary;
                BonusPercentage = bonusPercentage;

            }

            public override double CalculateSalary()
            {
                return BaseSalary + (BaseSalary * BonusPercentage);
            }
            public override string ToString()
            {
                return $"{CalculateSalary()}";
            }
        }

        public class PartTimeEmployee : Employee
        {
            public double HourlyRate;
            public int HoursWorked;

            public PartTimeEmployee()
            {
            }

            public PartTimeEmployee(double hourlyRate, int hoursWorked)
            {
                HourlyRate = hourlyRate;
                HoursWorked = hoursWorked;
            }

            public override double CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }
            public override string ToString()
            {
                return $"{CalculateSalary()}";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];

            //3. Input N employee details (using an array). 

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("Enter details of Employee");
                Console.WriteLine("Full time(f) or Part Time employee(p)");
                char choice = char.Parse(Console.ReadLine().ToLower());
                if (choice == 'p')
                {
                    PartTimeEmployee emp = new PartTimeEmployee();
                    Console.Write("Hourly Rate: ");
                    emp.HourlyRate = double.Parse(Console.ReadLine());
                    Console.Write("Hours Worked: ");
                    emp.HoursWorked = int.Parse(Console.ReadLine());
                    employees[i] = emp;
                }
                else if (choice == 'f')
                {
                    FullTimeEmployee emp = new FullTimeEmployee();
                    Console.Write("Base Salary:");
                    emp.BaseSalary = int.Parse(Console.ReadLine());
                    Console.Write("Bonus Percentage:");
                    emp.BonusPercentage = int.Parse(Console.ReadLine());
                    employees[i] = emp;
                }
                else
                {
                    Console.WriteLine("Invalid type of employee");
                }
            }
            //Print employees before sorting. 

            Console.WriteLine("\nEmployees salary before sorting:");
            foreach (var emp in employees)
            {
                Console.Write($"{emp} ");
            }

            //Sort employees using selection sort. 
            for (int i = 0; i < employees.Length; i++)// i-selected index
            {
                int min = i;
                for (int j = i + 1; j < employees.Length; j++)//j-next index
                {
                    if (employees[j].CalculateSalary() < employees[min].CalculateSalary())
                    {
                        min = j;
                    }
                    if (min != i)
                    {
                        Employee temp = employees[min];
                        employees[min] = employees[i];
                        employees[i] = temp;
                    }
                    
                }
            }
            //Print sorted employees.
            Console.WriteLine("\nEmployees salary after sorting:");
            foreach (var emp in employees)
            {
                Console.Write($"{emp} ");
            }
        }
    }
}

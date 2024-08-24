//Question 3
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

//3. Input N employee details (using an List< Employee >). 

//4.Print employees before sorting. Sort employees using insertion sort. Print sorted employees.


using System;
using System.Collections.Generic;


namespace AbstractClassWithMethodOverriding
{
    internal class Program
    {
        public abstract class Employee
        {
            public abstract int CalculateSalary();
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

            public override int CalculateSalary()
            {
                return BaseSalary + (BaseSalary * BonusPercentage);
            }
            public override string ToString()
            {
                return $"Salary: {CalculateSalary()}";
            }
        }

        public class PartTimeEmployee : Employee
        {
            public int HourlyRate;
            public int HoursWorked;

            public PartTimeEmployee()
            {
            }

            public PartTimeEmployee(int hourlyRate, int hoursWorked)
            {
                HourlyRate = hourlyRate;
                HoursWorked = hoursWorked;
            }

            public override int CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }
            public override string ToString()
            {
                return $"Salary: {CalculateSalary()}";
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for employee {i+1}:");
                Console.WriteLine("Is this Full Time(f) or Part Time(p) employee");
                char type = char.Parse(Console.ReadLine().ToLower());

                if (type == 'f')
                {
                    FullTimeEmployee emp = new FullTimeEmployee();
                    Console.Write("Base Salary:");
                    emp.BaseSalary = int.Parse(Console.ReadLine());
                    Console.Write("Bonus Percentage:");
                    emp.BonusPercentage = int.Parse(Console.ReadLine());
                    employees.Add(emp);//emp added to employees list
                }
                else if (type == 'p')
                {
                    PartTimeEmployee emp = new PartTimeEmployee();
                    Console.Write("Hourly Rate: ");
                    emp.HourlyRate = int.Parse(Console.ReadLine());
                    Console.Write("Hours Worked: ");
                    emp.HoursWorked = int.Parse(Console.ReadLine());
                    employees.Add(emp);
                }
                else
                {
                    Console.WriteLine("Invalid type of employee");
                }
 
            }
            Console.WriteLine("\nEmployees before sorting:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }

            // Insertion Sort
            for (int i = 1; i < employees.Count; i++)//sorting starts from 2nd elem (index 1)
            {
                var key = employees[i];//assigns the current element (at index i) to the variable key (elem to be sorted)
                int j = i - 1;//initializes j to the index of the last element in the sorted portion of the list

                while (j >= 0 && employees[j].CalculateSalary() > key.CalculateSalary())//j does not go out of bounds &&
                {                       //compares j's sal with key's sal 
                                        //if j's sal>key's sal, key needs to move further left
                            
                    employees[j + 1] = employees[j];//shifts elem at j one pos to right, creates space for key
                    j--;//continue checking next elem to left
                }
                 employees[j + 1] = key;//correst pos of key found(when while fails)
                //key inserted to correct pos of sorted portion of list
                //shift to right, insert at left
            }

            //Print after sorting
            Console.WriteLine("\nEmployees after sorting by salary:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
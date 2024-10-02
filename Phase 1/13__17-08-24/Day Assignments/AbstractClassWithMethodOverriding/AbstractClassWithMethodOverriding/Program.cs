//#1.Implement an Abstract Class with Method Overriding
//  - Task: Create an abstract class `Employee` with an abstract method `CalculateSalary()`.
//  Derive two classes `FullTimeEmployee` and `PartTimeEmployee` from `Employee`.
//  - Requirements:
//     - `FullTimeEmployee` should have properties `BaseSalary` and `BonusPercentage`. Implement the `CalculateSalary()` method to return the total salary, including bonus.
//     - `PartTimeEmployee` should have properties `HourlyRate` and `HoursWorked`. Implement the `CalculateSalary()` method to return the total earnings based on hours worked.


using System;


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
            int BaseSalary;
            int BonusPercentage;

            public FullTimeEmployee(int baseSalary, int bonusPercentage)
            {
                BaseSalary = baseSalary;
                BonusPercentage = bonusPercentage;
            }

            public override int CalculateSalary()
            {
                return BaseSalary+(BaseSalary *BonusPercentage);
            }
        }

        public class PartTimeEmployee : Employee
        {
            int HourlyRate;
            int HoursWorked;

            public PartTimeEmployee(int hourlyRate, int hoursWorked)
            {
                HourlyRate = hourlyRate;
                HoursWorked = hoursWorked;
            }

            public override int CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }
        }
        static void Main(string[] args)
        {
            //Employee employee = new Employee();//cannot create instance of abstract/interface type
            Employee fullTime =new FullTimeEmployee(5000, 1);
            Console.WriteLine(fullTime.CalculateSalary());  // Output: 10000
            Employee partTime = new PartTimeEmployee(20, 80);
            Console.WriteLine(partTime.CalculateSalary());  // Output: 1600
        }
    }
}

//create an app that can store emp details
//name, email, base_pay, age
//get emp with highest sal
//get 12 month sal of an emp
//get youngest emp
//get num of emps by a given age

using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSalUsingIndexes
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal BasePay { get; set; }
        public int Age { get; set; }

        public Employee(string name, string email, decimal basePay, int age)
        {
            Name = name;
            Email = email;
            BasePay = basePay;
            Age = age;
        }

        public decimal GetAnnualSalary()
        {
            return BasePay * 12;
        }
    }

    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        // Indexer to get employee by index
        public Employee this[int index]
        {
            get { return employees[index]; }
        }

        // Add a new employee
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        // Get the employee with the highest salary
        public Employee GetEmployeeWithHighestSalary()
        {
            return employees.OrderByDescending(emp => emp.BasePay).FirstOrDefault();
        }

        // Get the 12-month salary of an employee by index
        public decimal GetAnnualSalary(int index)
        {
            return employees[index].GetAnnualSalary();
        }

        // Get the youngest employee
        public Employee GetYoungestEmployee()
        {
            return employees.OrderBy(emp => emp.Age).FirstOrDefault();
        }

        // Get the number of employees with a given age
        public int GetNumberOfEmployeesByAge(int age)
        {
            return employees.Count(emp => emp.Age == age);
        }
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            EmployeeManager empManager = new EmployeeManager();

            // Adding employees
            empManager.AddEmployee(new Employee("John Doe", "john@example.com", 5000, 28));
            empManager.AddEmployee(new Employee("Jane Smith", "jane@example.com", 6000, 32));
            empManager.AddEmployee(new Employee("Sam Brown", "sam@example.com", 5500, 24));

            // Get employee with the highest salary
            var highestSalaryEmp = empManager.GetEmployeeWithHighestSalary();
            Console.WriteLine($"Employee with the highest salary: {highestSalaryEmp.Name} with a base pay of {highestSalaryEmp.BasePay}");

            // Get 12-month salary of the first employee
            var annualSalary = empManager.GetAnnualSalary(0);
            Console.WriteLine($"12-month salary of the first employee: {annualSalary}");

            // Get the youngest employee
            var youngestEmp = empManager.GetYoungestEmployee();
            Console.WriteLine($"Youngest employee: {youngestEmp.Name}, Age: {youngestEmp.Age}");

            // Get number of employees with age 32
            int numEmps = empManager.GetNumberOfEmployeesByAge(32);
            Console.WriteLine($"Number of employees with age 32: {numEmps}");
        }
    }
}

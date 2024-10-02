//Create a C# program with two classes: Employee and EmployeeManagement.

//Class Employee:
//Properties: Id(int), Name(string), and IsHandicapped(bool) to indicate if the employee is handicapped.

//Class EmployeeManagement:
//Contains a list of Employee objects.
//Methods:
//AddEmployee(Employee employee): Adds an employee to the list.
//DisplayAllEmployees(): Displays the details of all employees.
//DisplayHandicappedEmployees(): Displays the details of employees who are handicapped.
//RemoveHandicappedEmployees(): Removes all employees who are handicapped from the list.

//Demonstrate the functionality by:
//Creating several Employee objects.
//Adding them to an EmployeeManagement instance.
//Calling methods to display all employees, display handicapped employees, and remove handicapped employees, showing the updated list after removal.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static List_Operations_HandicappedEmployees.Program;


namespace List_Operations_HandicappedEmployees
{
    internal class Program
    {
        public class Employee
        {
            public Employee()
            {
            }

            public Employee(int id, string name, bool isHandicapped)
            {
                Id = id;
                Name = name;
                IsHandicapped = isHandicapped;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsHandicapped { get; set; }

            public override string ToString()
            {
                return $"ID: {Id}, Name: {Name}, Handicapped: {IsHandicapped}";
            }

        }
        public class EmployeeManagement
        {
            List<Employee> list = new List<Employee>();
            public void AddEmployee(Employee employee)
            {
                list.Add(employee);
            }
            public void DisplayAllEmployees()
            {
                foreach (var emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
            public void DisplayHandicappedEmployees()
            {
                foreach (var e in list.Where(e => e.IsHandicapped))
                {
                    Console.WriteLine(e);
                }

            }
            public void RemoveHandicappedEmployees()
            {
                list.RemoveAll(e=>e.IsHandicapped);
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            EmployeeManagement management = new EmployeeManagement();
            management.AddEmployee(new Employee(1,"Sini",false));
            management.AddEmployee(new Employee(2, "Hari", true));
            Console.WriteLine("All Employees:");
            management.DisplayAllEmployees();
            Console.WriteLine("\nHandicapped Employees:");
            management.DisplayHandicappedEmployees();
            management.RemoveHandicappedEmployees();
            Console.WriteLine("\nAll Employees after removing handicapped employees:");
            management.DisplayAllEmployees();
        }
    }
}

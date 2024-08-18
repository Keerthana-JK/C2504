//10.Design a Class Hierarchy with Method Overriding and Virtual Methods
//   - Task: Create a base class `Person` with a virtual method `DisplayInfo()` that returns a string containing the person's details.
//          Derive classes `Student` and `Teacher` from `Person`.
//   - Requirements:
//     - `Student` should have properties `StudentId` and `Major`. Override `DisplayInfo()` to return student-specific information.
//     - `Teacher` should have properties `EmployeeId` and `Subject`. Override `DisplayInfo()` to return teacher-specific information.
using System;
using System.Runtime.InteropServices;

namespace ClassHierarchyMethOverridingVirtualMeths
{
    internal class Program
    {
        public class Person
        {
            public virtual string DisplayInfo() => $"Information :";

        }
        public class Student : Person 
        {
            string StudentId;
            string Major;

            public Student(string studentId, string major)
            {
                StudentId = studentId;
                Major = major;
            }

            public override string DisplayInfo() => $"Student ID: {StudentId}, Major: {Major}";
        }

        public class Teacher : Person
        {
            string EmployeeId;
            string Subject;

            public Teacher(string employeeId, string subject)
            {
                EmployeeId = employeeId;
                Subject = subject;
            }

            public override string DisplayInfo() => $"Employee ID: {EmployeeId}, Subject: {Subject}";
        }
        static void Main(string[] args)
        {
            Person student = new Student("S123", "Computer Science");
            Console.WriteLine(student.DisplayInfo());

            Person teacher = new Teacher("T456", "Mathematics");
            Console.WriteLine(teacher.DisplayInfo());

        }
    }
}

using System;

namespace PartialClass
{
    internal class Program
    {
        static void Main()
        {
            Person p = new Person("John", "Doe", 30);
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    age = 30
            //};
            Console.WriteLine($"First Name : {p.FirstName}");
            Console.WriteLine($"Last Name : {p.LastName}");
            Console.WriteLine(p.DisplayFullName());
            //Console.WriteLine(p.age);
            Console.WriteLine(p.DisplayAge());
        }
    }
}

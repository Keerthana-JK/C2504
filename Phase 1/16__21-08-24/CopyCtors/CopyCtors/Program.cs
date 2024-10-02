using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyCtors
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Person(Person other)//Copy Ctor
            {
                Name = other.Name;
                Age = other.Age;
            }
        }
        static void Main(string[] args)
        {
            // Create an object using the parameterized constructor
            Person original = new Person("Da Vinci",42);
            Console.WriteLine("Original Person details:");
            Console.WriteLine($"Name: {original.Name}");
            Console.WriteLine($"Age: {original.Age}");
            Console.WriteLine("\nCopied Person details:");
            // Create a new object using the copy constructor
            Person copy = new Person(original);
            Console.WriteLine($"Name: {copy.Name}");
            Console.WriteLine($"Name: {copy.Age}");
            //changing field values (of copied object, will not affect original object)
            copy.Name = "Samuel King";
            copy.Age = 23;
            Console.WriteLine("\nPrinting after changing field values of copied object:");
            Console.WriteLine(copy.Name);
            Console.WriteLine(copy.Age);
        }
    }
}

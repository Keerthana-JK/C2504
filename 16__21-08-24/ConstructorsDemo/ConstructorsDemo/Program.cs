using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public static string College { get; set; }

            public Person()//Default Ctor
            {
                Name = "";
                Age = 0;
                Console.WriteLine("***Default Ctor called***");
            }

            public Person(string name, int age)//Parameterized Ctor
            {
                Name = name;
                Age = age;
                Console.WriteLine("***Parameterized Ctor called***");
            }

            public Person(Person other)//Copy Ctor
            {
                Name = other.Name;
                Age = other.Age;
                Console.WriteLine("***Copy Ctor called***");
            }

            
            static Person()//Static Ctor (gets called first)
            {
                College = "Toc H";
                Console.WriteLine("***Static Ctor called***");
            }

        }

        public class Kid
        {
            public static string Name { get; set; }
            public static int Age { get; set; }

            private Kid()//Private Ctor
            {
                Name = "Kiki";
                Age = 1;
                Console.WriteLine("***Private Ctor called***");
            }

        }

        static void Main(string[] args)
        {
            Person p = new Person();//calls default ctor
            Console.WriteLine($"College : {Person.College}");//ClassName.StaticCtorName //calls static ctor 

            Console.WriteLine($"Name: {p.Name}"); //"" (default val)
            Console.WriteLine($"Age: {p.Age}");//0 (default val)

            Person p2 = new Person("Arnav Singh", 36);
            Console.WriteLine($"Name: {p2.Name}");
            Console.WriteLine($"Age: {p2.Age}");

            // Create a new object using the copy constructor (from p1, which uses default ctor)
            Person copy = new Person(p);
            Console.WriteLine($"Name: {copy.Name}");
            Console.WriteLine($"Name: {copy.Age}");

            // Create a new object using the copy constructor (from p2, which uses param ctor)
            Person copy2 = new Person(p2);
            Console.WriteLine($"Name: {copy2.Name}");
            Console.WriteLine($"Name: {copy2.Age}");

            //private ctor gets called. we cant create an object of the Kid class
            Console.WriteLine(Kid.Name);
            Console.WriteLine(Kid.Age);

        }
    }
}

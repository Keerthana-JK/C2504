/*
- Ctor    - same name as class
	      - special method used to initialize objects
          - do not have a return type
	      - to initialize members of class
          - called automatically when an object is created
- Types : 
	1. default ctor - no parameters 
                    - provided automatically by compiler
                      if no constuctor is explicitly 
                      defined in the class
	2. param ctor   - takes params and allows you to initialize 
                      an object with specific values.
    3. static ctor  - used to initialize static members of the class
				    - called only once, before any static members 
                      are accessed or any static methods are called.
    4. copy ctor    - creates a new object as a copy of an existing
                      object.
				    - important in for creating immutable objects
				    - copy ctor takes a reference to an object of the 
                      same class as its argument.
    5. private ctor - used to prevent creation of instances of a class
				    - often used in classes that contain only 
                      static members. */

using System;

namespace ConstructorsTypesDemo
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
                Console.WriteLine("\n***Default Ctor called***");
            }

            public Person(string name, int age)//Parameterized Ctor
            {
                Name = name;
                Age = age;
                Console.Write("\n***Parameterized Ctor called***\n");
            }

            public Person(Person other)//Copy Ctor
            {
                Name = other.Name;
                Age = other.Age;
                Console.Write("\n***Copy Ctor called");
            }


            static Person()//Static Ctor (gets called first)
            {
                College = "Toc H";
                Console.WriteLine("***Static Ctor called***");
            }

        }

        public class Kid
        {
            public static string Name;
            public static int Age;

            static Kid()// Static Ctor to initialize static properties
            {
                Name = "Aaron";
                Age = 1; // Example age
            }
            private Kid()//Private Ctor (prevents creation of instances of class from outside)
            {

            }
            public static void DisplayKid()
            {
                Console.WriteLine("\n***Private Ctor called***");
                Console.WriteLine($"Kid's Name: {Name}, Age: {Age}");
            }

        }

        static void Main(string[] args)
        {
            Person p = new Person();//calls default ctor
            Console.WriteLine($"College : {Person.College}");//ClassName.StaticCtorName //calls static ctor 

            Console.WriteLine($"Name: {p.Name}"); //"" (default val)
            Console.WriteLine($"Age: {p.Age}");//0 (default val)

            Person p2 = new Person("Arnav Singh", 36);//calls parameterized ctor
            Console.WriteLine($"Name: {p2.Name}");
            Console.WriteLine($"Age: {p2.Age}");

            // Create a new object using the copy constructor (from p1, which uses default ctor)
            Person copy = new Person(p);
            Console.Write(" from p1, which uses default ctor***\n");
            Console.WriteLine($"Name: {copy.Name}");
            Console.WriteLine($"Name: {copy.Age}");

            // Create a new object using the copy constructor (from p2, which uses param ctor)
            Person copy2 = new Person(p2);
            Console.Write(" from p2, which uses parameterized ctor***\n");
            Console.WriteLine($"Name: {copy2.Name}");
            Console.WriteLine($"Name: {copy2.Age}");

            //private ctor gets called. we cant create an object of the Kid class
            //Console.WriteLine(Kid.Name);
            //Console.WriteLine(Kid.Age);
            Kid.DisplayKid();

        }
    }
}

/*  OUTPUT :
***Static Ctor called***

***Default Ctor called***
College : Toc H
Name:
Age: 0

***Parameterized Ctor called***
Name: Arnav Singh
Age: 36

***Copy Ctor called from p1, which uses default ctor***
Name:
Name: 0

***Copy Ctor called from p2, which uses parameterized ctor***
Name: Arnav Singh
Name: 36

***Private Ctor called***
Kid's Name: Aaron, Age: 1
Press any key to continue . . .*/
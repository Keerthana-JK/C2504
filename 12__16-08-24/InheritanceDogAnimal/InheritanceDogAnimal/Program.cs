using InheritanceDogAnimal;
using System;
using System.Runtime.InteropServices.ComTypes;


namespace InheritanceDogAnimal
{
    public abstract class Animal
    {
        public abstract void Eat();

    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weep...");
        }
    }
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Dog***");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.WriteLine();
            Console.WriteLine("***Puppy***");
            Puppy puppy = new Puppy();
            puppy.Weep();
            puppy.Eat();
            puppy.Bark();
            Console.WriteLine();
            Console.WriteLine("***Cat***");
            Cat cat = new Cat();
            cat.Meow();
            cat.Eat();
            //Console.WriteLine(cat.Equals(dog));
            
        }
    }
}

//Ouput :
//***Dog * **
//Eating...
//Barking...

//***Puppy * **
//Weep...
//Eating...
//Barking...

//***Cat * **
//Meowing...
//Eating...

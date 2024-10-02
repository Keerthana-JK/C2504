//Write the parent class with the method MakeSound.
//Child classes Dog and Cat to have the same method in the child class.
//Dog has an additional method Fetch


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Animal_MakeSound
{
    internal class Program
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes sound");
            }
        }
        //Alternate way : use abstract class Animal with abstract method MakeSound();
        //public abstract class Animal
        //{
        //    public abstract void MakeSound();
        //}
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog Bows!!!");
            }
            public void Fetch()
            {
                Console.WriteLine("Dog fetches the ball");
            }
        }
        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat Meows!!!");
            }
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal(); //In case of using abstract class Animal, instance cant be created
            animal.MakeSound();
            Animal dog = new Dog();
            dog.MakeSound();
            Dog dog1 = new Dog(); //directly referencing Dog class, so you can call any method specific to Dog that might not be present in Animal
            dog1.MakeSound();
            dog1.Fetch(); //specific to Dog class, dog.Fetch() doesnt work
            Animal cat = new Cat();
            cat.MakeSound();
        }
    }
}

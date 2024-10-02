//4.Design a Class Hierarchy with Abstract Methods and Interfaces
//   - Task: Create an abstract class `Vehicle` with an abstract method `Drive()`. Create an interface `IFuel` with a method `Refuel()`.
//      Derive classes `Car` and `Motorcycle` from `Vehicle` and implement `IFuel`.
//   - Requirements:
//     - `Car` should have properties `FuelLevel` and `TankCapacity`. Implement the `Drive()` method to simulate driving and `Refuel()` to refill the tank.
//     - `Motorcycle` should have properties `FuelLevel` and `TankCapacity`. Implement the `Drive()` method to simulate driving and `Refuel()` to refill the tank.


using System;

namespace ClassHierarchywithAbstractAndIF
{
    internal class Program
    {
        public abstract class Vehicle : IFuel
        {
            public abstract void Drive();
            public abstract void Refuel(int amount);

        }
        interface IFuel
        {
            void Refuel(int r);
        }
        public class Car : Vehicle
        {
            int FuelLevel;
            int TankCapacity;

            public Car(int fuelLevel, int tankCapacity)
            {
                FuelLevel = fuelLevel;
                TankCapacity = tankCapacity;
            }

            public override void Drive()
            {
                Console.WriteLine("You are driving the Car");
            }
            public override void Refuel(int r)
            {
                FuelLevel = Math.Min(FuelLevel + r, TankCapacity);
                Console.WriteLine("You car is refueled");
            }

        }
        public class Motorcycle : Vehicle
        {
            int FuelLevel;
            int TankCapacity;

            public Motorcycle(int fuelLevel, int tankCapacity)
            {
                FuelLevel = fuelLevel;
                TankCapacity = tankCapacity;
            }

            public override void Drive()
            {
                Console.WriteLine("You are driving the Motocycle");
            }
            public override void Refuel(int r)
            {
                FuelLevel = Math.Min(FuelLevel + r, TankCapacity);
                Console.WriteLine("You motorcycle is refueled");
            }
        }
        static void Main(string[] args)
        {
            Vehicle car = new Car(10, 50);
            car.Drive(); // Output: Car is driving
            (car as IFuel).Refuel(20); // Output: Car is refueled  //casts the "car object" to the "IFuel interface" type explicitly


            //IFuel fuelCar = car as IFuel;

            //if (fuelCar != null)
            //{
            //    fuelCar.Refuel(20);
            //}
            //else
            //{
            //    Console.WriteLine("The car does not support refueling.");
            //}

            Vehicle motorcycle = new Motorcycle(5, 15);
            motorcycle.Drive(); // Output: Motorcycle is driving
            (motorcycle as IFuel).Refuel(10); // Output: Motorcycle is refueled
        }
    }
}

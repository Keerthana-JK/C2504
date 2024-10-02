//6.Implement a Class Hierarchy with Abstract Methods and Interfaces
//   - Task: Create an abstract class `Appliance` with an abstract method `Operate()`. Create an interface `IEnergyEfficient` with a method `GetEnergyEfficiency()`.
//          Derive two classes `WashingMachine` and `Refrigerator` from `Appliance` and implement `IEnergyEfficient`.
//   - Requirements:
//     - `WashingMachine` should have properties `LoadCapacity` and `WaterUsage`. Implement `Operate()` to simulate operation and `GetEnergyEfficiency()` to return energy efficiency details.
//     - `Refrigerator` should have properties `Temperature` and `CoolingCapacity`. Implement `Operate()` to simulate operation and `GetEnergyEfficiency()` to return energy efficiency details.

using System;

namespace ClassHierarchyAbstractMethAndIF
{
    internal class Program
    {
        public abstract class Appliance
        {
            public abstract void Operate();
        }
        interface IEnergyEfficient
        {
            string GetEnergyEfficiency();
        }
        public class WashingMachine : Appliance, IEnergyEfficient
        {
            public WashingMachine(int loadCapacity, int waterUsage)
            {
                LoadCapacity = loadCapacity;
                WaterUsage = waterUsage;
            }

            int LoadCapacity { get; set; }
            int WaterUsage { get; set; }
            public override void Operate()
            {
                Console.WriteLine("Washing machine is operating");
            }
            public string GetEnergyEfficiency()
            {
                return $"Washing machine with load capacity {LoadCapacity} kg and water usage {WaterUsage} L.";
            }

        }
        public class Refrigerator : Appliance, IEnergyEfficient
        {
            public Refrigerator(int temperature, int coolingCapacity)
            {
                Temperature = temperature;
                CoolingCapacity = coolingCapacity;
            }

            int Temperature { get; set; }
            int CoolingCapacity { get; set; }   

            public override void Operate()
            {
                Console.WriteLine("Refrigerator is operating");
            }
            public string GetEnergyEfficiency()
            {
                return $"Refrigerator with temperature set to {Temperature}°C and cooling capacity {CoolingCapacity} BTU.";
            }
        }
        static void Main(string[] args)
        {
            Appliance washer = new WashingMachine(7, 50);
            washer.Operate();
            Console.WriteLine(((IEnergyEfficient)washer).GetEnergyEfficiency());

            Appliance fridge = new Refrigerator(-5, 300);
            fridge.Operate();
            Console.WriteLine(((IEnergyEfficient)fridge).GetEnergyEfficiency());
        }
    }
}

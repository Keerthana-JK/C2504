//Problem Statement: Inheritance and Overriding in Medication Management
//- Define an abstract class: `Medication` with the following properties and methods:
//-Properties: `MedicationID` (integer), `Dosage` (double, in milligrams)
//- Method: `CalculateCost()` (abstract, returns double)

//- Define a derived class: `TabletMedication` that inherits from `Medication` and has additional properties:
//- `TabletCount` (integer)
//- Override the `CalculateCost()` method to calculate cost based on the number of tablets and dosage.

//- Define another derived class: `InjectionMedication` that also inherits from `Medication` and has additional properties:
//- `Volume` (double, in milliliters)
//- Override the `CalculateCost()` method to calculate cost based on volume and dosage.

//- Tasks:
//1.Data Input:
//-Read N `medications` of both types (tablets and injections).
//2. Calculate Total Cost:
//-Implement a method that calculates and displays the total cost for all medications.
//3. Display Details:
//-Display the details of each medication using overridden `ToString()` methods in the derived classes.



using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTest4b
{
    // Class Medication
    public abstract class Medication
    {
        public int MedicationID { get; set; }
        public double Dosage { get; set; }
        public abstract double CalculateCost();

    }

    // Class TabletMedication

    class TabletMedication : Medication
    {
        public TabletMedication()
        {
        }

        public int TabletCount { get; set; }
        public override double CalculateCost()
        {
            double CostPerTablet=0.5;
            return TabletCount * Dosage * CostPerTablet;
        }

        public override string ToString()
        {
            return $"Tablet Count: {TabletCount}, Dosage: {Dosage}, Total Cost for Tablets: {CalculateCost()}";
        }
    }

    // Class InjectionMedication

    class InjectionMedication : Medication
    {
        public InjectionMedication()
        {
        }
        public double Volume { get; set; }
        public override double CalculateCost()
        {
            double CostPerInjection = 2;
            return Volume * Dosage * CostPerInjection;
        }

        public override string ToString()
        {
            return $"Volume: {Volume} ml, Dosage: {Dosage}, Total Cost for Injection: {CalculateCost()}";
        }
    }

    internal class Program
    {
        //2. Calculate Total Cost:
        //-Calculate and display the total cost for all medications.
        public static void CalcTotalCost(List<Medication> medications)
        {
            double totalCost=0.0;
            foreach (var medication in medications)
            {
                totalCost += medication.CalculateCost();
            }
            Console.WriteLine($"Total cost of all medications: {totalCost}");
        }

        //3. Display Details:
        //-Display the details of each medication using overridden `ToString()` methods in the derived classes.
        public static void DisplayMedicationDetails(List<Medication> medications)
        {
            Console.WriteLine("Details of all medications:");
            foreach (var medication in medications)
            {
                Console.WriteLine(medication.ToString());
            }
        }
        static void Main(string[] args)
        {
            //1.Data Input:
            //-Read N `medications` of both types (tablets and injections).
            Console.Write("Enter the number of Medications: ");
            int N = int.Parse(Console.ReadLine());
            List<Medication> medications = new List<Medication>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter details for Medication {i + 1}:");
                Console.Write("Enter 't' for Tablet Medication or 'j' for Injection Medication: ");
                char medType = char.Parse(Console.ReadLine().ToLower());
                if(medType == 't')
                {
                    TabletMedication t = new TabletMedication();
                    Console.Write("MedicationID: ");
                    t.MedicationID = int.Parse(Console.ReadLine());
                    Console.Write("Tablet Count: ");
                    t.TabletCount =int.Parse(Console.ReadLine());

                    Console.Write("Dosage (in mg): ");
                    t.Dosage = double.Parse(Console.ReadLine());
                    medications.Add(t);
                }

                else if (medType == 'j')
                {
                    InjectionMedication j = new InjectionMedication();
                    Console.Write("MedicationID: ");
                    j.MedicationID = int.Parse(Console.ReadLine());
                    Console.Write("Volume (in ml): ");
                    j.Volume = int.Parse(Console.ReadLine());

                    Console.Write("Dosage (in mg): ");
                    j.Dosage = double.Parse(Console.ReadLine());
                    medications.Add(j);
                }
                else
                {
                    Console.WriteLine("Invalid type. Please enter 't' for Tablet or 'j' for Injection.");
                    i--; // Repeat the iteration for valid input
                }
                
            }
            //display the total cost
            CalcTotalCost(medications);

            // Display details of each medication
            DisplayMedicationDetails(medications);
        }
    }
}

//Output:
//Enter the number of Medications: 3
//Enter details for Medication 1:
//Enter 't' for Tablet Medication or 'j' for Injection Medication: t
//MedicationID: 1
//Tablet Count: 5
//Dosage(in mg): 34
//Enter details for Medication 2:
//Enter 't' for Tablet Medication or 'j' for Injection Medication: j
//MedicationID: 2
//Volume(in ml): 56
//Dosage(in mg): 23
//Enter details for Medication 3:
//Enter 't' for Tablet Medication or 'j' for Injection Medication: t
//MedicationID: 3
//Tablet Count: 5
//Dosage(in mg): 67
//Total cost of all medications: 2828.5
//Details of all medications:
//Tablet Count: 5, Dosage: 34, Total Cost for Tablets: 85
//Volume: 56 ml, Dosage: 23, Total Cost for Injection: 2576
//Tablet Count: 5, Dosage: 67, Total Cost for Tablets: 167.5
//Press any key to continue . . .

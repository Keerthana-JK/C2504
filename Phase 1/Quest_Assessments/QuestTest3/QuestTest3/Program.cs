﻿//Create a `Prescription` Class with Comparison Methods
//- Task: Implement a class `Prescription` that represents
//a prescription with properties `PrescriptionID` and `Dosage` (in milligrams).
//Implement the following methods:
//`Equals`, `NotEquals`, `GreaterThan`,
//`GreaterThanEquals`, `LessThan`, and `LessThanEquals`
//to compare the dosage between two prescriptions.
//- Requirements:
//-Implement the `Equals(Prescription other)` method to check
//if two prescriptions have the same dosage.
//- Implement the `NotEquals(Prescription other)` method to check
//if two prescriptions have different dosages.
//- Implement the `GreaterThan(Prescription other)` method to check
//if one prescription has a higher dosage than another.
//- Implement the `GreaterThanEquals(Prescription other)` method to check
//if one prescription has a higher or equal dosage compared to another.
//- Implement the `LessThan(Prescription other)` method to check
//if one prescription has a lower dosage than another.
//- Implement the `LessThanEquals(Prescription other)` method to check
//if one prescription has a lower or equal dosage compared to another.
//- Example:
//```csharp
//Prescription pres1 = new Prescription("RX001", 500);
//Prescription pres2 = new Prescription("RX002", 400);

//Console.WriteLine(pres1.Equals(pres2)); // Output: False
//Console.WriteLine(pres1.GreaterThan(pres2)); // Output: True
//Console.WriteLine(pres1.LessThanEquals(pres2)); // Output: False


//Program to compare dosage of 2 prescriptions
using System;

namespace QuestTest3
{
    internal class Program
    {
        class Prescription
        {
            string PrescriptionID;
            readonly int Dosage;

            //parameterized constructor
            public Prescription(string prescriptionID, int dosage)
            {
                PrescriptionID = prescriptionID;
                Dosage = dosage;
            }

            public bool Equals(Prescription other)
            {
                if (this.Dosage == other.Dosage) return true;
                else return false;
            }

            public bool NotEquals(Prescription other)
            {
                if (this.Dosage != other.Dosage) return true;
                else return false;
            }
            public bool GreaterThan(Prescription other)
            {
                if (this.Dosage > other.Dosage) return true;
                else return false;
            }

            public bool GreaterThanEquals(Prescription other)
            {
                if (this.Dosage >= other.Dosage) return true;
                else return false;
            }

            public bool LessThan(Prescription other)
            {
                if (this.Dosage < other.Dosage) return true;
                else return false;
            }

            public bool LessThanEquals(Prescription other)
            {
                if (this.Dosage <= other.Dosage) return true;
                else return false;
            }
        }

        static void Main(string[] args)
        {
            Prescription pres1 = new Prescription("RX001", 500);
            Prescription pres2 = new Prescription("RX002", 400);

            Console.WriteLine(pres1.Equals(pres2)); // Output: False
            Console.WriteLine(pres1.GreaterThan(pres2)); // Output: True
            Console.WriteLine(pres1.LessThanEquals(pres2)); // Output: False
        }
    }
}

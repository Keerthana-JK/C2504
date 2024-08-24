//Problem Statement: Medication Dosage Analysis (without using LINQ or in-built C# sorting)
//- Define a class: `Prescription` with the following properties:
//- `PrescriptionID` (integer)
//- `PatientName` (string)
//- `MedicationName` (string)
//- `Dosage` (double, in milligrams)
//- Tasks:
//1.Data Input:
//-Read N `prescriptions` from the keyboard.
//2. Find Maximum Dosage:
//-Display the prescription with the highest dosage among the N `prescriptions`.
//Solve in time complexity of O(N).
//Dont use built-in C# sorting or LINQ.
//3. Find Third Least Dosage:
//-Display the prescription with the third least dosage among the N `prescriptions`.
//Solve in time complexity of O(N).
//Dont use built-in C# sorting or LINQ.
//4. Sort Prescriptions by Medication Name:
//-Implement and call your own sorting algorithm.
//Dont use built-in C# sorting or LINQ.
//Fn:To find minDosage of 1st and last dosage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTest4
{
    public class Prescription
    {
        //1. Class: `Prescription`

        public int PrescriptionID { get; set; }
        public string PatientName { get; set; }
        public string MedicationName { get; set; }
        public double Dosage { get; set; }

        public Prescription(int prescriptionID, string patientName, string medicationName, double dosage)
        {
            PrescriptionID = prescriptionID;
            PatientName = patientName;
            MedicationName = medicationName;
            Dosage = dosage;
        }

        public Prescription()
        {
        }

        public override string ToString()
        {
            return $"PrescriptionID: {PrescriptionID}, PatientName: {PatientName}, MedicationName: {MedicationName}, Dosage: {Dosage}";
        }


        //2. Find Maximum Dosage: (using Insertion Sort - O(N))

        public static void FindMaxDosage(List<Prescription> prescriptions, int N)
        {
            if(N == 0)
            {
                Console.WriteLine("No Prescription available");
                return;
            }

            for (int i = 1; i < prescriptions.Count; i++)
            {
                Prescription key = prescriptions[i];
                int j = i - 1;

                // Move elements of prescriptions[0..i-1], that are greater than key, to one position ahead of their current position
                while (j >= 0 && prescriptions[j].Dosage > key.Dosage)
                {
                    prescriptions[j + 1] = prescriptions[j];
                    j = j - 1;
                }
                prescriptions[j + 1] = key;
            }

            // The last element in the sorted list will have the maximum dosage
            Prescription maxDosage = prescriptions[prescriptions.Count - 1];
            Console.WriteLine($"Prescription with the highest dosage: {maxDosage.MedicationName}, Dosage: {maxDosage.Dosage} mg");
        }
        //3. Find Third Least Dosage: (using Insertion Sort - O(N))
        public static void FindThirdLeastDosage(List<Prescription> prescriptions, int N)
        {
            if (prescriptions.Count < 3)
            {
                Console.WriteLine("Not enough prescriptions to find the third least dosage.");
                return;
            }
            double first = double.MaxValue, second = double.MaxValue, third = double.MaxValue;
            Prescription thirdLeastPrescription = null;

            foreach (var prescription in prescriptions)
            {
                if (prescription.Dosage < first)
                {
                    third = second;
                    second = first;
                    first = prescription.Dosage;
                }
                else if (prescription.Dosage < second)
                {
                    third = second;
                    second = prescription.Dosage;
                }
                else if (prescription.Dosage < third)
                {
                    third = prescription.Dosage;
                    thirdLeastPrescription = prescription;
                }
            }

            Console.WriteLine($"Prescription with the third least dosage: {thirdLeastPrescription.MedicationName}, Dosage: {thirdLeastPrescription.Dosage} mg");
        }


        //4. Sort Prescriptions by Medication Name:
        public static void SortByMedicationName(List<Prescription> prescriptions)
        {
            int n = prescriptions.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(prescriptions[j].MedicationName, prescriptions[j + 1].MedicationName) > 0)
                    {
                        // Swap prescriptions[j] and prescriptions[j + 1]
                        var temp = prescriptions[j];
                        prescriptions[j] = prescriptions[j + 1];
                        prescriptions[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Prescriptions sorted by Medication Name:");
            foreach (var prescription in prescriptions)
            {
                Console.WriteLine($"{prescription.MedicationName} - {prescription.Dosage} mg");
            }
        }

        //Fn:To find minDosage of 1st and last dosage
        public static double FindMinimumDosage(List<Prescription> prescriptions, int N)
        {
            double minDosage = 0;
            double first = prescriptions[0].Dosage;
            Console.WriteLine($"First Dosage: {first}");
            double last = prescriptions[N-1].Dosage;
            Console.WriteLine($"Last Dosage: {last}");
            if (first < last)
            {
                minDosage = first;
            }
            else if(first > last)
            {
                minDosage = last;
            }
            else 
            {
                Console.WriteLine("Both first and last have equal dosage");
                minDosage = first;// (OR) minDosage=last;
            }

            return minDosage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Prescription pres = new Prescription();
            //1.Data Input:
            //-Read N `prescriptions` from the keyboard.

            List<Prescription> prescriptions = new List<Prescription>();
            Console.Write("Enter the number of prescriptions:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter details for prescription {i + 1}:");
                Prescription p = new Prescription();
                Console.Write("Prescription ID: ");
                p.PrescriptionID = int.Parse(Console.ReadLine());
                Console.Write("Patient Name: ");
                p.PatientName = Console.ReadLine();
                Console.Write("Medication Name: ");
                p.MedicationName = Console.ReadLine();
                Console.Write("Dosage (in mg): ");
                p.Dosage = double.Parse(Console.ReadLine());
                prescriptions.Add(p);
            }
            Console.WriteLine();
            Prescription.FindMaxDosage(prescriptions,N);
            Prescription.FindThirdLeastDosage(prescriptions, N);
            Prescription.SortByMedicationName(prescriptions);
            Console.WriteLine($"Min Dosage of 1st and last dosage : {Prescription.FindMinimumDosage(prescriptions, N)}"); 
        }
    }
}

//Output:
//Enter the number of prescriptions:
//5
//Enter details for prescription 1:
//PrescriptionID: 1
//PatientName: Ram
//MedicationName: Paracetamol
//Dosage(in mg): 250
//Enter details for prescription 2:
//PrescriptionID: 2
//PatientName: Seeta
//MedicationName: Cital
//Dosage(in mg): 120
//Enter details for prescription 3:
//PrescriptionID: 3
//PatientName: Yasim
//MedicationName: Dolo
//Dosage(in mg): 350
//Enter details for prescription 4:
//PrescriptionID: 4
//PatientName: Ishaan
//MedicationName: Betadine
//Dosage(in mg): 540
//Enter details for prescription 5:
//PrescriptionID: 5
//PatientName: Ganga
//MedicationName: Dexorange
//Dosage(in mg): 420
//Prescription with the highest dosage: Betadine, Dosage: 540 mg
//Prescription with the third least dosage: Dolo, Dosage: 350 mg
//Prescriptions sorted by Medication Name:
//Betadine - 540 mg
//Cital - 120 mg
//Dexorange - 420 mg
//Dolo - 350 mg
//Paracetamol - 250 mg
//Press any key to continue . . .

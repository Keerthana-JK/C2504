using System;
using System.Collections.Generic;
using QuestTest5Task2;
using QuestTest5Task2PrescriptionDAO;


namespace QuestTest5Task2PrescriptionUI
{
    public class PrescriptionUI
    {
        private PrescriptionDAO prescriptionDAO = new PrescriptionDAO();

        public void CreatePrescription()
        {
            Console.Write("Enter Name: ");
            string PatientName = Console.ReadLine();
            Console.Write("Enter Place: ");
            string MedicationName = Console.ReadLine();
            Console.Write("Enter Skill: ");
            float Dosage = float.Parse(Console.ReadLine());

            Prescription prescription = new Prescription(0, PatientName, MedicationName, Dosage);

            prescriptionDAO.GetPrescriptionsFromDatabase();
            Console.WriteLine("Prescription created successfully.");
        }

        public void ReadPrescription()
        {
            Console.Write("Enter Prescription ID: ");
            int id = int.Parse(Console.ReadLine());

            Prescription prescription = prescriptionDAO.CreatePrescription(p.id);
            if (prescription != null)
            {
                Console.WriteLine($"PrescriptionID: {prescription.PrescriptionID}");
                Console.WriteLine($"PatientName: {prescription.PatientName}");
                Console.WriteLine($"MedicationName: {prescription.MedicationName}");
                Console.WriteLine($"Dosage: {prescription.Dosage}");
            }
            else
            {
                Console.WriteLine("Prescription not found.");
            }
        }

        public void UpdatePrescription()
        {
            Console.Write("Enter Prescription ID: ");
            int id = int.Parse(Console.ReadLine());

            Prescription Prescription = prescriptionDAO.Read(id);
            if (Prescription != null)
            {
                Console.Write("Enter new Patient Name: ");
                Prescription.PatientName = Console.ReadLine();
                Console.Write("Enter new MedicationName: ");
                Prescription.MedicationName = Console.ReadLine();
                Console.Write("Enter new Dosage: ");
                Prescription.Dosage = int.Parse(Console.ReadLine());

                prescriptionDAO.UpdatePrescription(Prescription);
                Console.WriteLine("Prescription updated successfully.");
            }
            else
            {
                Console.WriteLine("Prescription not found.");
            }
        }

        public void DeletePrescription()
        {
            Console.Write("Enter Prescription ID: ");
            int id = int.Parse(Console.ReadLine());

            prescriptionDAO.DeletePrescription(id);
            Console.WriteLine("Prescription deleted successfully.");
        }

        public void ListAllPrescriptions()
        {
            List<Prescription> pres = prescriptionDAO.GetPrescriptionsFromDatabase();
            foreach (Prescription Prescription in pres)
            {
                Console.WriteLine($"ID: {Prescription.PrescriptionID}, PatientName: {Prescription.PatientName}, MedicationName: {Prescription.MedicationName}, Dosage: {Prescription.Dosage}");
            }
        }
    }
}
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
            Console.Write("Enter Patient Name: ");
            string PatientName = Console.ReadLine();
            Console.Write("Enter Medication Name: ");
            string MedicationName = Console.ReadLine();
            Console.Write("Enter Dosage: ");
            float Dosage = float.Parse(Console.ReadLine());

            Prescription prescription = new Prescription(0, PatientName, MedicationName, Dosage);

            prescriptionDAO.CreatePrescription(prescription);
            Console.WriteLine("Prescription created successfully.");
        }

        public void ReadPrescription()
        {
            Console.Write("Enter Prescription ID: ");
            int id = int.Parse(Console.ReadLine());
            Prescription prescription = new Prescription(id);
            Prescription p = prescriptionDAO.GetPrescriptionById(prescription.PrescriptionID);
            //p.PrescriptionID = id;
            //Prescription prescription = prescriptionDAO.CreatePrescription(p.PrescriptionID);
            if (p != null)
            {
                Console.WriteLine($"PrescriptionID: {p.PrescriptionID}");
                Console.WriteLine($"Patient Name: {p.PatientName}");
                Console.WriteLine($"Medication Name: {p.MedicationName}");
                Console.WriteLine($"Dosage: {p.Dosage}");
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
            Prescription prescription = new Prescription(id);

            prescription.PrescriptionID = id;
            //Prescription prescription = prescriptionDAO.Read(prescription);
            if (prescription != null)
            {
                Console.Write("Enter new Patient Name: ");
                prescription.PatientName = Console.ReadLine();
                Console.Write("Enter new Medication Name: ");
                prescription.MedicationName = Console.ReadLine();
                Console.Write("Enter new Dosage: ");
                prescription.Dosage = double.Parse(Console.ReadLine());

                prescriptionDAO.UpdatePrescription(prescription);
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
            if (pres.Count == 0)
            {
                Console.WriteLine("No prescriptions found.");
            }
            else
            {
                foreach (Prescription p in pres)
                {
                    Console.WriteLine($"PrescriptionID: {p.PrescriptionID}, PatientName: {p.PatientName}, MedicationName: {p.MedicationName}, Dosage: {p.Dosage}");
                }
            }
        }
    }
}
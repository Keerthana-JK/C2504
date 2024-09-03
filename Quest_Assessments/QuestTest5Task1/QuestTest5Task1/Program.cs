using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using log4net;
using System.Collections;
using System.Xml.Linq;
namespace QuestTest5Task1
{
    public class ServerException : Exception
    {
        public ServerException(string message) : base(message) { }
    }
    public class Prescription
    {
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
        public override string ToString()
        {
            return $"PrescriptionID:{PrescriptionID},PatientName: {PatientName},MedicationName: {MedicationName},Dosage: {Dosage}";
        }
    }
    public class PrescriptionService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;";
        public static void Read(Prescription[] pres)
        {
            /* for (int i = 0; i < pres.Length; i++)
            {
            Console.Write("Enter the PrescriptionID:");
            int PrescriptionID = int.Parse(Console.ReadLine());
            Console.Write("Enter the PatientName:");
            string PatientName = Console.ReadLine();
            Console.Write("Enter the MedicationName:");
            string MedicationName = Console.ReadLine();
            Console.Write("Enter the Dosage:");
            double Dosage = double.Parse(Console.ReadLine());
            pres[i] = new Prescription(PrescriptionID, PatientName, MedicationName, Dosage);
            }*/
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; i < pres.Length; i++)
                    {
                        if (!reader.Read())
                        {
                            log.Info("There are no more rows to read.");
                        }
                        pres[i] = new Prescription(
                        (int)reader["PrescriptionID"],
                        (string)reader["PatientName"],
                        (string)reader["MedicationName"],
                        (double)reader["Dosage"]
                        );
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                log.Info($"SQL Error: {ex.Message}");
                //throw new ServerException($"[0102]Server Error.{ex.Message}");//throw Error
            }


        }
        public static void Sort(Prescription[] pres)
        {
            int n = pres.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(pres[j].PatientName, pres[minIndex].PatientName) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Prescription temp = pres[minIndex];
                    pres[minIndex] = pres[i];
                    pres[i] = temp;
                }
            }
        }
        //Find Max Dosage
        public static Prescription FindMaxDosage(Prescription[] pres)
        {
            if (pres.Length == 0)
            {
                log.Warn("No prescriptions available.");
                return null;
            }

            Prescription maxPrescription = pres[0];

            foreach (var prescription in pres)
            {
                if (prescription.Dosage > maxPrescription.Dosage)
                {
                    maxPrescription = prescription;
                }
            }

            log.Info($"Prescription with the highest dosage: {maxPrescription.MedicationName}, Dosage: {maxPrescription.Dosage} mg");
            return maxPrescription;
        }
        public static Prescription DisplayThirdMaxDosage(Prescription[] pres)
        {
            for (int i = 0; i < pres.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < pres.Length; j++)
                {
                    if (pres[j].Dosage < pres[min].Dosage)
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    Prescription temp = pres[min];
                    pres[min] = pres[i];
                    pres[i] = temp;
                }
            }
            log.Info($"Third Max Dosage is:{pres[pres.Length - 3]}");
            return pres[pres.Length - 3];
        }
    }
    public class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Prescription[] pres = new Prescription[3];
            log.Info("Loading Data from Database");
            try
            {
                PrescriptionService.Read(pres);
            }
            catch (ServerException ex)
            {
                log.Error($"{ex.Message}");
            }
            PrescriptionService.Read(pres);
            //log.Info("enter the Prescription id to find the minimum dosage:");
            //int PrescriptionID = int.Parse(Console.ReadLine());
            PrescriptionService.FindMaxDosage(pres);
            PrescriptionService.DisplayThirdMaxDosage(pres);
            PrescriptionService.Sort(pres);
            log.Info("sorted by patient name:");
            foreach (Prescription patient in pres)
            {
                log.Info(patient);
            }
        }
    }
}


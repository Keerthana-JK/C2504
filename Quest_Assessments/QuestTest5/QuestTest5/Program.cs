using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuestTest5
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        //#1. Define class Prescription
        public class Prescription
        {
            public int PrescriptionID { get; set; }
            public string PatientName { get; set; }
            public string MedicationName { get; set; }
            public double Dosage { get; set; }
        }

        //Data Input from SQL with Exception Handling and Logging
        public class PrescriptionDataHandler
        {
            public List<Prescription> GetPrescriptionsFromDatabase()
            {
                List<Prescription> prescriptions = new List<Prescription>();

                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
                    {
                        conn.Open();
                        log.Info("Database connection opened.");

                        SqlCommand cmd = new SqlCommand("SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription", conn);
                        log.Info("SQL command created.");
                        SqlDataReader reader = cmd.ExecuteReader();
                        log.Info("SQL query executed.");

                        if (!reader.HasRows)
                        {
                            log.Warn("No rows returned by SQL query.");
                        }
                        while (reader.Read())
                        {
                            prescriptions.Add(new Prescription
                            {
                                PrescriptionID = (int)reader["PrescriptionID"],
                                PatientName = reader["PatientName"].ToString(),
                                MedicationName = reader["MedicationName"].ToString(),
                                Dosage = Convert.ToDouble(reader["Dosage"])   // float -> int
                            });
                        }

                        log.Info($"{prescriptions.Count} prescriptions fetched from the database.");
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error while reading from database: ", ex);
                }

                return prescriptions;
            }

        }

        //Find Max Dosage
        public static Prescription FindMaxDosage(List<Prescription> prescriptions)
        {
             if (prescriptions == null || prescriptions.Count == 0)
                 throw new ArgumentException("Prescription list is empty or null");

             Prescription maxPrescription = prescriptions[0];

             for (int i = 1; i < prescriptions.Count; i++)
             {
                 if (prescriptions[i].Dosage > maxPrescription.Dosage)
                 {
                     maxPrescription = prescriptions[i];
                 }
             }

             return maxPrescription;
        }

        // Find Third Least Dosage
        public static Prescription FindThirdLeastDosage(List<Prescription> prescriptions)
        {
            if (prescriptions == null || prescriptions.Count < 3)
                throw new ArgumentException("Prescription list should have at least 3 items");

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
                else if (prescription.Dosage < second && prescription.Dosage > first)
                {
                    third = second;
                    second = prescription.Dosage;
                }
                else if (prescription.Dosage < third && prescription.Dosage > second)
                {
                    third = prescription.Dosage;
                    thirdLeastPrescription = prescription;
                }
            }

            return thirdLeastPrescription;
        }


        //Sort Prescription By Medication Name
        public static void SortPrescriptionsByMedicationName(List<Prescription> prescriptions)
            {
                int n = prescriptions.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (string.Compare(prescriptions[j].MedicationName, prescriptions[j + 1].MedicationName) > 0)
                        {
                            var temp = prescriptions[j];
                            prescriptions[j] = prescriptions[j + 1];
                            prescriptions[j + 1] = temp;
                        }
                    }
                }
            }

        public static bool IsSqlConnectionEstablished(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        log.Info("SQL connection established.");
                        return true;
                    }
                    else
                    {
                        log.Error("SQL connection state is not open.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("Error establishing SQL connection: ", ex);
                return false;
            }
        }

        static void Main(string[] args)
        {
            // Configure log4net
            XmlConfigurator.Configure();

            // Create an instance of the PrescriptionDataHandler to fetch data from the database
            PrescriptionDataHandler dataHandler = new PrescriptionDataHandler();
            List<Prescription> prescriptions = dataHandler.GetPrescriptionsFromDatabase();

            // Check SQL connection
            if (IsSqlConnectionEstablished("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
            {
                Console.WriteLine("SQL connection established successfully.");
            }
            else
            {
                Console.WriteLine("Failed to establish SQL connection.");
            }

            if (prescriptions.Count == 0)
            {
                Console.WriteLine("No prescriptions found.");
                return;
            }

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Find Prescription with Maximum Dosage");
                Console.WriteLine("2. Find Prescription with Third Least Dosage");
                Console.WriteLine("3. Sort Prescriptions by Medication Name");
                Console.WriteLine("4. Display All Prescriptions");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            var maxDosagePrescription = FindMaxDosage(prescriptions);
                            Console.WriteLine($"\nPrescription with the maximum dosage: {maxDosagePrescription.MedicationName}, Dosage: {maxDosagePrescription.Dosage} mg");
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while finding the maximum dosage: ", ex);
                        }
                        break;

                    case "2":
                        try
                        {
                            var thirdLeastDosagePrescription = FindThirdLeastDosage(prescriptions);
                            Console.WriteLine($"\nPrescription with the third least dosage: {thirdLeastDosagePrescription.MedicationName}, Dosage: {thirdLeastDosagePrescription.Dosage} mg");
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while finding the third least dosage: ", ex);
                        }
                        break;

                    case "3":
                        try
                        {
                            SortPrescriptionsByMedicationName(prescriptions);
                            Console.WriteLine("\nPrescriptions sorted by Medication Name:");
                            foreach (var prescription in prescriptions)
                            {
                                Console.WriteLine($"Medication: {prescription.MedicationName}, Dosage: {prescription.Dosage} mg");
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while sorting prescriptions: ", ex);
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nAll Prescriptions:");
                        foreach (var prescription in prescriptions)
                        {
                            Console.WriteLine($"ID: {prescription.PrescriptionID}, Patient: {prescription.PatientName}, Medication: {prescription.MedicationName}, Dosage: {prescription.Dosage} mg");
                        }
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }    
        }
    }
}

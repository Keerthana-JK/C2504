using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace QuestTest5
{
    public class Program
    {

        //#1. Define class Prescription
        public class Prescription
        {
            //logger instance
            private static readonly ILog log = LogManager.GetLogger(typeof(Prescription));
            public int PrescriptionID { get; set; }
            public string PatientName { get; set; }
            public string MedicationName { get; set; }
            public double Dosage { get; set; }

            public static  List<Prescription> prescriptions = new List<Prescription>();
            private int count = 0;
            //connection string
            private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;";

            //Data Input from SQL with Exception Handling and Logging
            public void LoadDataFromDatabase()
            {
                log.Info("Loading data from database...");
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM Prescription";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();
                        log.Info("Database connection opened.");
                        //log.Info("SQL command created.");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            log.Info("SQL query executed.");

                            if (!reader.HasRows)
                            {
                                log.Warn("No rows returned by SQL query.");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    prescriptions.Add(new Prescription()
                                    {
                                        PrescriptionID = (int)reader["PrescriptionID"],
                                        PatientName = reader["PatientName"].ToString(),
                                        MedicationName = reader["MedicationName"].ToString(),
                                        Dosage = Convert.ToDouble(reader["Dosage"])
                                    });
                                }
                                log.Info($"{prescriptions.Count} prescriptions fetched from the database.");
                            }
                        }
                    }
                    log.Info("Data loaded successfully.");
                }
                catch (Exception ex)
                {
                    log.Error("Error while reading from database: ", ex);
                }
            }

            //Find Max Dosage
            public static Prescription FindMaxDosage(List<Prescription> prescriptions)
            {
                if (prescriptions.Count == 0)
                {
                    log.Warn("No prescriptions available.");
                    return null;
                }

                Prescription maxPrescription = prescriptions[0];

                foreach (var prescription in prescriptions)
                {
                    if (prescription.Dosage > maxPrescription.Dosage)
                    {
                        maxPrescription = prescription;
                    }
                }

                log.Info($"Prescription with the highest dosage: {maxPrescription.MedicationName}, Dosage: {maxPrescription.Dosage} mg");
                return maxPrescription;
            }

            // Find Third Least Dosage
            public static Prescription FindThirdLeastDosage(List<Prescription> prescriptions)
            {
                try
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
                catch (ArgumentException ex)
                {
                    log.Error("Error: ", ex);
                    return null; // Return null or handle the exception as needed
                }
           
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

            static void Main(string[] args)
            {
                //Reads the configuration from App.config
                XmlConfigurator.Configure();
                log.Info("Application is starting.");

                Prescription p = new Prescription();
                log.Info("--------------------------------Loading Data from Database------------------------------");
                p.LoadDataFromDatabase();
                log.Info("");
                log.Info("--------------------------------Find Max Dosage------------------------------");
                Prescription.FindMaxDosage(prescriptions);
                log.Info("");
                log.Info("--------------------------------FindThirdLeastDosage------------------------------");
                Prescription.FindThirdLeastDosage(prescriptions);
                log.Info("");
                log.Info("--------------------------------SortPrescriptionsByMedicationName------------------------------");
                Prescription.SortPrescriptionsByMedicationName(prescriptions);
                log.Info("Application is ending.");
            }
        }
    }
}

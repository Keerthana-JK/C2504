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
                                Dosage = Convert.ToDouble(reader["Dosage"])  // Correct conversion
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

            public void AddPrescription(Prescription prescription)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
                    {
                        conn.Open();
                        string query = "INSERT INTO Prescription (PatientName, MedicationName, Dosage) VALUES (@PatientName, @MedicationName, @Dosage)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PatientName", prescription.PatientName);
                            cmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationName);
                            cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);

                            int result = cmd.ExecuteNonQuery();
                            log.Info($"{result} row(s) inserted into the Prescription table.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error while inserting into the database: ", ex);
                }
            }

            public void UpdatePrescription(Prescription prescription)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
                    {
                        conn.Open();
                        string query = "UPDATE Prescription SET PatientName = @PatientName, MedicationName = @MedicationName, Dosage = @Dosage WHERE PrescriptionID = @PrescriptionID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PrescriptionID", prescription.PrescriptionID);
                            cmd.Parameters.AddWithValue("@PatientName", prescription.PatientName);
                            cmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationName);
                            cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);

                            int result = cmd.ExecuteNonQuery();
                            log.Info($"{result} row(s) updated in the Prescription table.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error while updating the database: ", ex);
                }
            }

            public void DeletePrescription(int prescriptionID)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Prescription WHERE PrescriptionID = @PrescriptionID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionID);

                            int result = cmd.ExecuteNonQuery();
                            log.Info($"{result} row(s) deleted from the Prescription table.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error while deleting from the database: ", ex);
                }
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
                Console.WriteLine("1. Add New Prescription");
                Console.WriteLine("2. Update Existing Prescription");
                Console.WriteLine("3. Delete Prescription");
                Console.WriteLine("4. Display All Prescriptions");
                Console.WriteLine("5. Find Prescription with Maximum Dosage");
                Console.WriteLine("6. Find Prescription with Third Least Dosage");
                Console.WriteLine("7. Sort Prescriptions by Medication Name");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Enter Patient Name: ");
                            string patientName = Console.ReadLine();
                            Console.Write("Enter Medication Name: ");
                            string medicationName = Console.ReadLine();
                            Console.Write("Enter Dosage (mg): ");
                            double dosage = Convert.ToDouble(Console.ReadLine());

                            var newPrescription = new Prescription
                            {
                                PatientName = patientName,
                                MedicationName = medicationName,
                                Dosage = dosage
                            };

                            dataHandler.AddPrescription(newPrescription);
                            Console.WriteLine("Prescription added successfully.");
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while adding a new prescription: ", ex);
                        }
                        break;

                    case "2":
                        try
                        {
                            Console.Write("Enter Prescription ID to update: ");
                            int prescriptionID = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter new Patient Name: ");
                            string patientName = Console.ReadLine();
                            Console.Write("Enter new Medication Name: ");
                            string medicationName = Console.ReadLine();
                            Console.Write("Enter new Dosage (mg): ");
                            double dosage = Convert.ToDouble(Console.ReadLine());

                            var updatedPrescription = new Prescription
                            {
                                PrescriptionID = prescriptionID,
                                PatientName = patientName,
                                MedicationName = medicationName,
                                Dosage = dosage
                            };

                            dataHandler.UpdatePrescription(updatedPrescription);
                            Console.WriteLine("Prescription updated successfully.");
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while updating the prescription: ", ex);
                        }
                        break;

                    case "3":
                        try
                        {
                            Console.Write("Enter Prescription ID to delete: ");
                            int prescriptionID = Convert.ToInt32(Console.ReadLine());

                            dataHandler.DeletePrescription(prescriptionID);
                            Console.WriteLine("Prescription deleted successfully.");
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while deleting the prescription: ", ex);
                        }
                        break;

                    case "4":
                        try
                        {
                            prescriptions = dataHandler.GetPrescriptionsFromDatabase();
                            Console.WriteLine("\nAll Prescriptions:");
                            foreach (var prescription in prescriptions)
                            {
                                Console.WriteLine($"ID: {prescription.PrescriptionID}, Patient: {prescription.PatientName}, Medication: {prescription.MedicationName}, Dosage: {prescription.Dosage} mg");
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while displaying all prescriptions: ", ex);
                        }
                        break;

                    case "5":
                        try
                        {
                            prescriptions = dataHandler.GetPrescriptionsFromDatabase();
                            if (prescriptions.Count > 0)
                            {
                                var maxDosagePrescription = FindMaxDosage(prescriptions);
                                Console.WriteLine($"\nPrescription with the maximum dosage: {maxDosagePrescription.MedicationName}, Dosage: {maxDosagePrescription.Dosage} mg");
                            }
                            else
                            {
                                Console.WriteLine("No prescriptions found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while finding the maximum dosage: ", ex);
                        }
                        break;

                    case "6":
                        try
                        {
                            prescriptions = dataHandler.GetPrescriptionsFromDatabase();
                            if (prescriptions.Count >= 3)
                            {
                                var thirdLeastDosagePrescription = FindThirdLeastDosage(prescriptions);
                                Console.WriteLine($"\nPrescription with the third least dosage: {thirdLeastDosagePrescription.MedicationName}, Dosage: {thirdLeastDosagePrescription.Dosage} mg");
                            }
                            else
                            {
                                Console.WriteLine("Not enough prescriptions to find the third least dosage.");
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while finding the third least dosage: ", ex);
                        }
                        break;

                    case "7":
                        try
                        {
                            prescriptions = dataHandler.GetPrescriptionsFromDatabase();
                            if (prescriptions.Count > 0)
                            {
                                SortPrescriptionsByMedicationName(prescriptions);
                                Console.WriteLine("\nPrescriptions sorted by Medication Name:");
                                foreach (var prescription in prescriptions)
                                {
                                    Console.WriteLine($"Medication: {prescription.MedicationName}, Dosage: {prescription.Dosage} mg");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No prescriptions found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("An error occurred while sorting prescriptions: ", ex);
                        }
                        break;

                    case "8":
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QuestTest5Task2;
using QuestTest5Task2PrescriptionUI;

namespace QuestTest5Task2PrescriptionDAO
{
    public class PrescriptionDAO
    {
        string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;";
        public void CreatePrescription(Prescription prescription)
        {
            string query = "INSERT INTO Prescription (PatientName, MedicationName, Dosage) VALUES (@PatientName, @MedicationName, @Dosage)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@PrescriptionID", prescription.PrescriptionID);
                cmd.Parameters.AddWithValue("@PatientName", prescription.PatientName);
                cmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationName);
                cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);
                conn.Open();
                cmd.ExecuteNonQuery();
                //if (rowsAffected == 0)
                //{
                //    // Handle the case where no rows were affected
                //    Console.WriteLine("No rows inserted. Check if the PrescriptionID already exists.");
                //}
            }
        }

        //Read Particular Prescription
        public Prescription Read(Prescription prescription)
        {
            Prescription p = null;
            string query = "SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription WHERE PrescriptionID = @PrescriptionID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PrescriptionID", prescription.PrescriptionID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    p = new Prescription
                    {
                        PrescriptionID = (int)reader["PrescriptionID"],
                        PatientName = reader["PatientName"].ToString(),
                        MedicationName = reader["MedicationName"].ToString(),
                        Dosage = Convert.ToDouble(reader["Dosage"])
                    };
                }
            }
            return p;
        }

        //Update Prescription
        public void UpdatePrescription(Prescription prescription)
        {
            string query = "UPDATE Prescription SET PatientName = @PatientName, MedicationName = @MedicationName, Dosage = @Dosage WHERE PrescriptionID = @PrescriptionID";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                
                cmd.Parameters.AddWithValue("@PrescriptionID", prescription.PrescriptionID);
                cmd.Parameters.AddWithValue("@PatientName", prescription.PatientName);
                cmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationName);
                cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);

                int rowsAffected = cmd.ExecuteNonQuery();//num of rows affected
                if (rowsAffected == 0)
                {
                    // Handle the case where no rows were affected (e.g., ID not found)
                    Console.WriteLine("No rows updated. Prescription might not exist.");
                }
            }
        }
        //Delete Prescription
        public void DeletePrescription(int prescriptionID)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM Prescription WHERE PrescriptionID = @PrescriptionID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                    int result = cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Prescription> GetPrescriptionsFromDatabase()
        {
            List<Prescription> prescriptions = new List<Prescription>();
            string query = "SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription";
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    prescriptions.Add(new Prescription
                    {
                        PrescriptionID = (int)reader["PrescriptionID"],
                        PatientName = reader["PatientName"].ToString(),//obj to string
                        MedicationName = reader["MedicationName"].ToString(),
                        Dosage = Convert.ToDouble(reader["Dosage"])
                    });
                }
            }
            return prescriptions;
        }
        public Prescription GetPrescriptionById(int prescriptionID)
        {
            Prescription prescription = null;
            string query = "SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription WHERE PrescriptionID = @PrescriptionID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        prescription = new Prescription
                        {
                            PrescriptionID = (int)reader["PrescriptionID"],
                            PatientName = reader["PatientName"].ToString(),
                            MedicationName = reader["MedicationName"].ToString(),
                            Dosage = Convert.ToDouble(reader["Dosage"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception using a logging framework like log4net
                Console.WriteLine($"An error occurred while retrieving the prescription: {ex.Message}");
            }

            return prescription;
        }
    }
}

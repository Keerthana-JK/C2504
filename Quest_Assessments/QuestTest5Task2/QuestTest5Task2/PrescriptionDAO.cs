using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QuestTest5Task2;

namespace QuestTest5Task2PrescriptionDAO
{
    public class PrescriptionDAO
    {
        public void CreatePrescription(Prescription prescription)
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
                }
            }
        }
        public void Read(int id)
        {
            foreach (Prescription p in GetPrescriptionsFromDatabase())
            {
               Console.WriteLine($"PrescriptionID: {p.PrescriptionID}, PatientName: {p.PatientName}, MedicationName: {p.MedicationName}, Dosage: {p.Dosage}");
            }
        }

            public void UpdatePrescription(Prescription prescription)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
            {
                conn.Open();
                //string query = "UPDATE Prescription SET PatientName = @PatientName, MedicationName = @MedicationName, Dosage = @Dosage WHERE PrescriptionID = @PrescriptionID";
                string query = $"UPDATE Prescription SET PatientName = {"Ganga"}, MedicationName = {"Dolo 650"}, Dosage={230}";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PrescriptionID", prescription.PrescriptionID);
                    cmd.Parameters.AddWithValue("@PatientName", prescription.PatientName);
                    cmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationName);
                    cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);

                    int result = cmd.ExecuteNonQuery();//num of rows affected

                }
            }
        }

        public void DeletePrescription(int prescriptionID)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
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

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prescription;Integrated Security=True;"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT PrescriptionID, PatientName, MedicationName, Dosage FROM Prescription", conn);
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

    }
}

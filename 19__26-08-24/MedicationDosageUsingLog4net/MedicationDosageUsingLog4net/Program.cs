//Log4net : Medication Dosage Analysis (without using LINQ or in-built C# sorting)


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using log4net;

namespace QuestTest4
{
    public class ServerException : Exception
    {
        public ServerException(string message) : base(message) { }
    }
    public class Prescription
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Week4AssessmentDb;Integrated Security=True;";
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

        public static void FindMaxDosage(List<Prescription> prescriptions)
        {
            if (prescriptions.Count == 0)
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
        public static void FindThirdLeastDosage(List<Prescription> prescriptions)
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
        public static double FindMinimumDosage(List<Prescription> prescriptions)
        {
            double minDosage = 0;
            double first = prescriptions[0].Dosage;
            Console.WriteLine($"First Dosage: {first}");
            double last = prescriptions[prescriptions.Count - 1].Dosage;
            Console.WriteLine($"Last Dosage: {last}");
            if (first < last)
            {
                minDosage = first;
            }
            else if (first > last)
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

        public static double FindMinOfSecondAndSecondLastDosage(List<Prescription> prescriptions)
        {
            double minDosageSSL = 0;
            double second = prescriptions[1].Dosage;
            Console.WriteLine($"Second Dosage: {second}");
            double secondLast = prescriptions[prescriptions.Count - 2].Dosage;
            Console.WriteLine($"Second Last Dosage: {secondLast}");
            if (second < secondLast)
            {
                minDosageSSL = second;
            }
            else if (second > secondLast)
            {
                minDosageSSL = secondLast;
            }
            else
            {
                Console.WriteLine("Both first and last have equal dosage");
                minDosageSSL = second;// (OR) minDosageSSL=secondLast;
            }
            return minDosageSSL;
        }
        public static void Read(List<Prescription> prescriptions)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT HospitalID, DoctorName, Medication,Dosage FROM Prescription";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; i < prescriptions.Count; i++)
                    {
                        if (!reader.Read())
                        {
                            throw new ServerException("[0101]Server Errror.");//throw error
                        }
                        prescriptions[i] = new Prescription
                        {
                            PrescriptionID = (int)reader["Prescription ID"],
                            PatientName = reader["Patient Name"].ToString(),
                            MedicationName = reader["Medication Name"].ToString(),
                            Dosage = (double)reader["Dosage"]
                        };
                    }

                }

            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                //Console.WriteLine($"SQL Error: {ex.Message}");
                throw new ServerException($"[0102]Server Errror.{ex.Message}");//throw Error
            }
            catch (ServerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                //Console.WriteLine($"Error: {ex.Message}");
                throw new ServerException($"[0103]Server Errror.{ex.Message}");//throw Error
            }
        }
}
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            Prescription pres = new Prescription();
            List<Prescription> prescriptions = new List<Prescription>();
            try
            {
                Prescription.Read(prescriptions);
            }
            catch (ServerException ex)
            {
                log.Error($"{ex.Message}");
            }

            Console.WriteLine();

            Prescription.FindMaxDosage(prescriptions);
            Prescription.FindThirdLeastDosage(prescriptions);
            Prescription.SortByMedicationName(prescriptions);
            log.Info($"Min Dosage of 1st and last dosage : {Prescription.FindMinimumDosage(prescriptions)}");
            log.Info($"Min Of 2nd and 2nd Last Dosage: {Prescription.FindMinOfSecondAndSecondLastDosage(prescriptions)}");
        }
    }
}

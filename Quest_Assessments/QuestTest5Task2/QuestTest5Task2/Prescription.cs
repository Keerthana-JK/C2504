using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTest5Task2
{
    public class Prescription
    {
        public Prescription()
        {
        }

        public Prescription(int prescriptionID, string patientName, string medicationName, double dosage)
        {
            PrescriptionID = prescriptionID;
            PatientName = patientName;
            MedicationName = medicationName;
            Dosage = dosage;
        }

        public int PrescriptionID { get; set; }
        public string PatientName { get; set; }
        public string MedicationName { get; set; }
        public double Dosage { get; set; }
    }
}

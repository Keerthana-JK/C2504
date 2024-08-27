using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestTest4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTest4.Tests
{
    [TestClass()]
    public class PrescriptionTests
    {
        [TestMethod()]
        public void PrescriptionTest()
        {
            List<Prescription> prescriptions = new List<Prescription>();
            FindMaxDosageTest(prescriptions);
            Assert.Fail();
        }

        [TestMethod()]
        public void PrescriptionTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindMaxDosageTest()
        {
            List<Prescription> prescriptions = new List<Prescription>();
            Prescription.Read(prescriptions);
            Prescription expected = new Prescription
            {
                PrescriptionID = 123,
                PatientName = "Sanjay",
                MedicationName = "Paracetamol",
                Dosage = 650
            };
            Prescription actual = Prescription.FindMaxDosage(prescriptions);
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        [TestMethod()]
        public void FindThirdLeastDosaget()
        {
            List<Prescription> prescriptions = new List<Prescription>();
            Prescription.Read(prescriptions);
            Prescription expected = new Prescription
            {
                PrescriptionID = 1,
                PatientName = "Ameya",
                MedicationName = "Paracetamol",
                Dosage = 650
            };
            Prescription actual = Prescription.FindThirdLeastDosage(prescriptions);
            Assert.AreEqual(expected.ToString(), actual.ToString());

            }

            [TestMethod()]
        public void SortByMedicationNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindMinimumDosageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindMinOfSecondAndSecondLastDosageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReadTest()
        {
            Assert.Fail();
        }
    }
}
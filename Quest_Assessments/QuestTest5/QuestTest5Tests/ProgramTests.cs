using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestTest5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuestTest5.Program;

namespace QuestTest5.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        //FindMaxDosage
        [TestMethod()]
        public void FindMaxDosage_SingleElement_ReturnsElement()
        {
            var prescriptions = new List<Prescription>
            {
                new Prescription { Dosage = 10 }
            };
            var result = Program.FindMaxDosage(prescriptions);
            Assert.AreEqual(prescriptions[0], result);
        }

        [TestMethod]
        public void FindMaxDosage_MultipleElementsWithUniqueDosages_ReturnsMaxDosage()
        {
            var prescriptions = new List<Prescription>
        {
            new Prescription { Dosage = 10 },
            new Prescription { Dosage = 20 },
            new Prescription { Dosage = 30 }
        };
            var result = Program.FindMaxDosage(prescriptions);
            Assert.AreEqual(prescriptions[2], result);
        }


        [TestMethod()]
        public void FindThirdLeastDosageTest()
        {
            var prescriptions = new List<Prescription>
        {
            new Prescription { Dosage = 10 },
            new Prescription { Dosage = 20 },
            new Prescription { Dosage = 30 },
            new Prescription { Dosage = 40 }
        };
            var result = Program.FindThirdLeastDosage(prescriptions);
            Assert.AreEqual(prescriptions[2], result);
        }

        [TestMethod()]
        public void SortPrescriptionsByMedicationName_MultipleElementsList_SortedCorrectly()
        {
            var prescriptions = new List<Prescription>
            {
                new Prescription { MedicationName = "Gelusil" },
                new Prescription { MedicationName = "Dolo 650" },
                new Prescription { MedicationName = "Paracetamol" }
            };
            Program.SortPrescriptionsByMedicationName(prescriptions);
            Assert.AreEqual("Dolo 650", prescriptions[0].MedicationName);
            Assert.AreEqual("Gelusil", prescriptions[1].MedicationName);
            Assert.AreEqual("Paracetamol", prescriptions[2].MedicationName);
        }
    }
}
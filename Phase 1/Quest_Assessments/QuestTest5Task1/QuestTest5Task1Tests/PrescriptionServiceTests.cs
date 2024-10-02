using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestTest5Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestTest5Task1Tests
{
    [TestClass()]
    public class PrescriptionServiceTests
    {

        [TestMethod]
        public void Sort_MultipleElements_SortsCorrectly()
        {
            // Arrange
            var prescriptions = new[]
            {
                new Prescription(1, "John", "MedA", 10.0),
                new Prescription(2, "Alice", "MedB", 20.0),
                new Prescription(3, "Bob", "MedC", 30.0)
            };

            // Act
            PrescriptionService.Sort(prescriptions);

            // Assert
            Assert.AreEqual("Alice", prescriptions[0].PatientName);
            Assert.AreEqual("Bob", prescriptions[1].PatientName);
            Assert.AreEqual("John", prescriptions[2].PatientName);
        }

        [TestMethod]
        public void FindMaxDosage_MultipleElements_ReturnsMaxDosage()
        {
            // Arrange
            var prescriptions = new[]
            {
                new Prescription(1, "John", "MedA", 10.0),
                new Prescription(2, "Alice", "MedB", 20.0),
                new Prescription(3, "Bob", "MedC", 30.0)
            };

            // Act
            var result = PrescriptionService.FindMaxDosage(prescriptions);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(30.0, result.Dosage);
            Assert.AreEqual("MedC", result.MedicationName);
        }

        [TestMethod]
        public void DisplayThirdMaxDosage_MultipleElements_ReturnsThirdMaxDosage()
        {
            // Arrange
            var prescriptions = new[]
            {
                new Prescription(1, "John", "MedA", 10.0),
                new Prescription(2, "Alice", "MedB", 20.0),
                new Prescription(3, "Bob", "MedC", 30.0),
                new Prescription(4, "Eve", "MedD", 40.0)
            };

            // Act
            var result = PrescriptionService.DisplayThirdMaxDosage(prescriptions);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(20.0, result.Dosage);
            Assert.AreEqual("MedB", result.MedicationName);
        }
    }
}
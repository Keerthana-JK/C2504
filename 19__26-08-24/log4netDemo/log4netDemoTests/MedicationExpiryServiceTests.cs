using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4netDemo;
using System;

namespace log4netDemo.Tests
{
    [TestClass()]
    public class MedicationExpiryServiceTests
    {
        [TestMethod()]
        public void FindMin_Test()
        {
            MedicationExpiry[] medicationExpiries = new MedicationExpiry[3];
            MedicationExpiryService.Read(medicationExpiries);
            MedicationExpiry expected = new MedicationExpiry
            {
                BatchID = 3,
                Medication = "Halls",
                ExpiryDate = DateTime.Parse("2025-05-31")
            };
            MedicationExpiry actual = MedicationExpiryService.FindMin(medicationExpiries);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod()]
        public void FindSecondMax_Test()
        {
            MedicationExpiry[] medicationExpiries = new MedicationExpiry[3];
            MedicationExpiryService.Read(medicationExpiries);
            MedicationExpiry expected = new MedicationExpiry
            {
                BatchID = 2,
                Medication = "Vicks",
                ExpiryDate = DateTime.Parse("2025-11-20")
            };
            MedicationExpiry actual = MedicationExpiryService.FindSecondMax(medicationExpiries);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod()]
        public void Sort_Test()
        {
            MedicationExpiry[] medicationExpiries = new MedicationExpiry[3];
            MedicationExpiryService.Read(medicationExpiries);
            MedicationExpiry expected = new MedicationExpiry
            {
                BatchID = 3,
                Medication = "Halls",
                ExpiryDate = DateTime.Parse("2025-05-31")
            };
            MedicationExpiryService.Sort(medicationExpiries);
            MedicationExpiry actual = medicationExpiries[0];
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}

/*
Output:
2024-08-27 08:28:45,403 [1] INFO  Week4AssessmentApp.Program - min=[3,Halls,31-05-2025 00:00:00]
2024-08-27 08:28:45,420 [1] INFO  Week4AssessmentApp.Program - secondMax=[2,Vicks,20-11-2025 00:00:00]
2024-08-27 08:28:45,420 [1] INFO  Week4AssessmentApp.Program - [3,Halls,31-05-2025 00:00:00] [2,Vicks,20-11-2025 00:00:00] [1,P 500,12-12-2025 00:00:00]

*/
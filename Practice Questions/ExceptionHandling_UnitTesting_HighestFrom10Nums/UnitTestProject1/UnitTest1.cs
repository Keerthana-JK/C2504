using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionHandling_UnitTesting_HighestFrom10Nums.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FindHighestNum_GivenHigherNumber_ReturnsHigherNumber()
        {
            // Arrange
            int initialHighest = 5;
            int newNumber = 10;

            // Act
            int result = Program.FindHighestNum(newNumber, initialHighest);

            // Assert
            Assert.AreEqual(newNumber, result);
        }

        [TestMethod]
        public void FindHighestNum_GivenLowerNumber_ReturnsInitialHighest()
        {
            // Arrange
            int initialHighest = 10;
            int newNumber = 5;

            // Act
            int result = Program.FindHighestNum(newNumber, initialHighest);

            // Assert
            Assert.AreEqual(initialHighest, result);
        }

        [TestMethod]
        public void FindHighestNum_GivenEqualNumber_ReturnsInitialHighest()
        {
            // Arrange
            int initialHighest = 10;
            int newNumber = 10;

            // Act
            int result = Program.FindHighestNum(newNumber, initialHighest);

            // Assert
            Assert.AreEqual(initialHighest, result);
        }
    }
}

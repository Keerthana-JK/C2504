using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateUnitTestDemo;


namespace CreateUnitTestDemo.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]//attribute
        public void MultiplyTest_Return100for5and20()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(5.0, 20.0);

            Assert.AreEqual(100.0, product);
        }

        [TestMethod()]
        public void MultiplyTest_Return0for5and0()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(5.0, 0);

            Assert.AreEqual(0.0, product);
        }

        [TestMethod()]
        public void MultiplyTest_Return5for5and1()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(5.0, 1.0);

            Assert.AreEqual(5.0, product);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(5.0, 1.0);

            Assert.AreEqual(5.0, product);
        }
    }
}
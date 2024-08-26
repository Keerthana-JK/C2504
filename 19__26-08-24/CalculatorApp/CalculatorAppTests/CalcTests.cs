using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramingFundamentalsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingFundamentalsProject.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void Multiply_ShouldReturn100ForGiven5And20()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(5.0, 20.0);
            Assert.AreEqual(100.0, product);
        }
        [TestMethod()]
        public void Multiply_ShouldReturn12ForGiven3And4()
        {
            Calc calc = new Calc();
            double product = calc.Multiply(3.0, 4.0);
            Assert.AreEqual(12.0, product);
        }
    }
}
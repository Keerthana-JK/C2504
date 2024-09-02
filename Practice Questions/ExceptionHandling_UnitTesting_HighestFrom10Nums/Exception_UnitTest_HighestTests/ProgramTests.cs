using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exception_UnitTest_Highest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_UnitTest_Highest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FindHighestNumTest()
        {
            int num = 20;
            Program p = new Program();
            int highest = Program.FindHighestNum(num, 20);
            Assert.AreEqual(20,highest);
        }
    }
}
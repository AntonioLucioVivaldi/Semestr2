using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial;

namespace FactorialTests
{
    [TestClass]
    public class Factorialtest
    {
        [TestMethod]
        public void factorialTest()
        {
            int check1 = 720;
            int check2 = 6;
            check2 = Program.factorial(check2);
            Assert.AreEqual(check1, check2);
        }
    }
}

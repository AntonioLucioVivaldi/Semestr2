using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial;

namespace FactorialTests
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void TestFactorial()
        {
            int check1 = 720;
            int check2 = 6;
            check2 = Program.Factorial(check2);
            Assert.AreEqual(check1, check2);
        }

        [TestMethod]
        public void TestFactorial1()
        {
            int check1 = 1;
            int check2 = Program.Factorial(1);
            Assert.AreEqual(check1, check2);
        }

        [TestMethod]
        public void TestZero()
        {
            int check = Program.Factorial(0);
            Assert.AreEqual(check, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestNegativeNumberException()
        {
            int check = Program.Factorial(-5);
        }
    }
}

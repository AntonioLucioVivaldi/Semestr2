using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fibonacci;

namespace FibonacciTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciTest()
        {
            int check1 = 7;
            int check2 = 13;
            check1 = Program.Fibonacci(check1);
            Assert.AreEqual(check1, check2);
        }

        [TestMethod]
        public void FibonacciZeroTest()
        {
            int check = 0;
            int check1 = Program.Fibonacci(0);
            Assert.AreEqual(check, check1);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void NegativeNumberTest()
        {
            int check = Program.Fibonacci(-4);
        }
    }
}

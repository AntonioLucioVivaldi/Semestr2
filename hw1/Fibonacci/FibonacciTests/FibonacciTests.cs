using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;

namespace FibonacciTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciTest()
        {
            int check1 = 13;
            int check2 = 7;
            Assert.AreEqual(check1, Program.Fibonacci(check2));
        }

        [TestMethod]
        public void ZeroTest()
        {
            int check1 = 0;
            int check2 = Program.Fibonacci(0);
            Assert.AreEqual(check1, check2);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void NegativeNumberTest()
        {
            int check = Program.Fibonacci(-5);
        }
    }
}

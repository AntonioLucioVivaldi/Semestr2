using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fibonacci;

namespace Fibonaccitests
{
    [TestClass]
    public class fibTest
    {
        [TestMethod]
        public void fibonacciTests()
        {
            int check1 = 7;
            int check2 = 13;
            check1 = Program.fib(check1);
            Assert.AreEqual(check1, check2);
        }
    }
}

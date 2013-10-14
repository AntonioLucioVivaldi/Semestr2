using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StackCalculator.Stack stack = new StackCalculator.Stack();
            stack.Push(4);
            Assert.AreEqual(stack.Pop(), 4);
        }
    }
}

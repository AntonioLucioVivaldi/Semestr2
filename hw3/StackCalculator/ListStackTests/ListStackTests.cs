using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;

namespace ListStackTests
{
    [TestClass]
    public class ListStackTest
    {
        [TestMethod]
        public void PushTest()
        {
            StackCalculator.ListStack newStack = new StackCalculator.ListStack();
            newStack.Push(5);
            Assert.AreEqual(newStack.Pop(), 5);
        }

        [TestMethod]
        public void PopTest()
        {
            StackCalculator.ListStack newStack = new StackCalculator.ListStack();
            newStack.Push(5);
            var result = newStack.Pop();
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(IsEmptyException))]
        public void IsEmptyExceptionTest()
        {
            StackCalculator.ListStack newStack = new StackCalculator.ListStack();
            newStack.Pop();
        }
    }
}

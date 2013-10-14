using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;

namespace ArrayListTests
{
    [TestClass]
    public class ArrayStackTest
    {
        [TestMethod]
        public void PushTest()
        {
            StackCalculator.ArrayStack newStack = new StackCalculator.ArrayStack();
            newStack.Push(5);
            Assert.AreEqual(newStack.Pop(), 5);
        }

        [TestMethod]
        public void PopTest()
        {
            StackCalculator.ArrayStack newStack = new StackCalculator.ArrayStack();
            newStack.Push(4);
            int result = newStack.Pop();
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            StackCalculator.ArrayStack newStack = new StackCalculator.ArrayStack();
            Assert.IsTrue(newStack.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(IsEmptyException))]
        public void IsEmptyExceptionTest()
        {
            StackCalculator.ArrayStack newStack = new StackCalculator.ArrayStack();
            newStack.Pop();
        }
    }
}

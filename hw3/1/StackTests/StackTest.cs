using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace StackTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushTest()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.IsFalse(stack.isEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            Stack stack = new Stack();
            stack.Push(2);
            var result = stack.Pop();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void isEmpty()
        {
            Stack stack = new Stack();
            Assert.IsTrue(stack.isEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void EmptyStackExceptionTest()
        {
            Stack stack = new Stack();
            stack.Pop();
        }
    }
}

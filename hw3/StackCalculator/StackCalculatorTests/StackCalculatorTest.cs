using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;

namespace StackCalculatorTests
{
    [TestClass]
    public class StackCalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            calculator.Push(20);
            calculator.Push(40);
            calculator.Add();
            Assert.AreEqual(calculator.Result(), 60);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            calculator.Push(20);
            calculator.Push(40);
            calculator.Subtract();
            Assert.AreEqual(calculator.Result(), 20);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            calculator.Push(20);
            calculator.Push(40);
            calculator.Multiply();
            Assert.AreEqual(calculator.Result(), 800);
        }

        [TestMethod]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            calculator.Push(20);
            calculator.Push(40);
            calculator.Divide();
            Assert.AreEqual(calculator.Result(), 2);
        }

        [TestMethod]
        public void ResultTest()
        {
            Calculator calculator = new Calculator();
            calculator.Push(10);
            Assert.AreEqual(calculator.Result(), 10);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughNumbersException))]
        public void NotEnoughNumbersExceptionTest()
        {
            Calculator calculator = new Calculator();
            calculator.Push(20);
            calculator.Multiply();
        }
    }
}

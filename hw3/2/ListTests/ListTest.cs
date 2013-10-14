using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;

namespace ListTests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void AddElementTest()
        {
            List list = new List();
            list.AddElement(1);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            List list = new List();
            list.AddElement(5);
            list.DeleteElement(5);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            List list = new List();
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void EmptyListExceptionTest1()
        {
            List list = new List();
            list.DeleteElement(4);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void EmptyListExceptionTest2()
        {
            List list = new List();
            list.PrintList();
        }
    }
}

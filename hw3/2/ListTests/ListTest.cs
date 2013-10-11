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
            Assert.IsTrue(list.IsEmpty());
        }
    }
}

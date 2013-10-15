using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fold;

namespace FoldTests
{
    [TestClass]
    public class FoldTests
    {
        [TestMethod]
        public void TestFold()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            int value = FoldFunction.Fold(list, 1, (acc, elem) => acc * elem);
            Assert.AreEqual(value, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void TestEmptyListException()
        {
            List<int> list = new List<int>();
            int value = FoldFunction.Fold(list, 2, (acc, elem) => acc * elem);
        }
    }
}

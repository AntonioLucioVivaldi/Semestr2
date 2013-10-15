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
        public void TestMethod1()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            int value = FoldFunction.Fold(list, 1, (acc, elem) => acc * elem);
            Assert.AreEqual(value, 6);
        }
    }
}

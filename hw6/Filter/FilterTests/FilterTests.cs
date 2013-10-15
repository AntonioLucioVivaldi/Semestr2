using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Filter;

namespace FilterTests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void TestFilter()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> check = new List<int>() { 2, 4, 6, 8 };
            check = FilterFunc.Filter(list, x => x % 2 == 0);
            CollectionAssert.Equals(list, check);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void TestEmptyListException()
        {
            List<int> list = new List<int>();
            list = FilterFunc.Filter(list, x => x > 4);
        }
    }
}

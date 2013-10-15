using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Map;

namespace MapTests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void TestMap()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            List<int> check = new List<int>() { 2, 4, 6 };
            list = MapFunc.MapFunction(list, x => x * 2);
            CollectionAssert.Equals(list, check);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void TestEmptyListException()
        {
            List<int> list = new List<int>();
            list = MapFunc.MapFunction(list, x => x * 5);
        }
    }
}

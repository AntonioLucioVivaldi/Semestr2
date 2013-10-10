using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace BubbleSortTests
{
    [TestClass]
    public class BubbleSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            int[] toSort = new int[] {10, 5, 2, 1, 8, 9, 4, 3, 7, 6 };
            Program.Sort(toSort);
            for (int i = 0; i < toSort.Length; i++)
            {
                Assert.AreEqual(toSort[i], i + 1);
            }
        }
    }
}

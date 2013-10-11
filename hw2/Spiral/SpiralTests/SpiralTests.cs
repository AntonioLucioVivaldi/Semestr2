using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spiral;

namespace SpiralTests
{
    [TestClass]
    public class SpiralTests
    {
        [TestMethod]
        public void HelixSortTest()
        {
            int[,] toSort = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] array = { 5, 8, 7, 4, 1, 2, 3, 6, 9 };
            int[] array1 = Program.HelixSort(toSort);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array1[i], array[i]);
            }
        }
    }
}

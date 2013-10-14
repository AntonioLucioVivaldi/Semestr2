using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapColumn;

namespace SwapColumnTests
{
    [TestClass]
    public class SwapColumnTest
    {
        [TestMethod]
        public void SortTest()
        {
            int[,] array1 = { { 9, 8, 7 }, { 5, 4, 3 }, { 6, 2, 1 } };
            int[,] array2 = { { 7, 8, 9 }, { 3, 4, 5 }, { 1, 2, 6 } };
            Program.Sort(array1);
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(0); j++)
                {
                    Assert.AreEqual(array1[i, j], array2[i, j]);
                }
            }
        }
    }
}

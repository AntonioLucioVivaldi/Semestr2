using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTree;

namespace ParseTreeTests
{
    [TestClass]
    public class ParseTreeTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var tree = new Tree("C:/Users/Администратор/Documents/Visual Studio 2010/Projects/ParseTree/Input.txt");
            Node head = null;
            tree.Build(ref head);
            Assert.AreEqual(35, head.Calculate());
        }
    }
}

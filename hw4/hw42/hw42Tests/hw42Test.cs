using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw42;

namespace hw42Tests
{
    [TestClass]
    public class hw42Test
    {
        [TestMethod]
        public void Hash1Test()
        {
            Hash1 hash = new Hash1();
            HashTable hashTable = new HashTable(101, hash);
            Assert.IsTrue(hashTable.hash.Hash("o", 101) == 1);
        }

        [TestMethod]
        public void Hash2Test()
        {
            Hash2 hash = new Hash2();
            HashTable hashTable = new HashTable(101, hash);
            Assert.IsTrue(hashTable.hash.Hash("o", 35) == -17);
        }

        [TestMethod]
        public void TestAdd()
        {
            Hash1 hash = new Hash1();
            HashTable hashTable = new HashTable(50, hash);
            hashTable.Add("ololo");
            Assert.IsTrue(hashTable.Search("ololo"));
        }

        [TestMethod]
        public void TestDelete()
        {
            Hash1 hash = new Hash1();
            HashTable hashTable = new HashTable(50, hash);
            hashTable.Add("ololo");
            hashTable.Delete("ololo");
            Assert.IsFalse(hashTable.Search("ololo"));
        }

        [TestMethod]
        public void TestSearch()
        {
            Hash1 hash = new Hash1();
            HashTable hashTable = new HashTable(50, hash);
            hashTable.Add("mololo");
            Assert.IsTrue(hashTable.Search("mololo"));
        }
        
    }
}

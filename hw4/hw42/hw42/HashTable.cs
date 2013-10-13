using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw42
{
    public class HashTable
    {
        private int size;
        private List[] list;
        public IHash hash;

        public HashTable(int number, IHash hash)
        {
            this.size = number;
            this.hash = hash;
            list = new List[number];
            for (int i = 0; i < number; ++i)
            {
                list[i] = new List();
            }
        }

        public void Add(string str)
        {
            int index = hash.Hash(str, size);
            if (list[index].InList(str) == -1)
            {
                list[index].Add(str, 1);
            }
            else
            {
                list[index].Position(list[index].InList(str)).Value++;
            }
        }

        public void Delete(string str)
        {
            int index = hash.Hash(str, size);
            if (list[index].InList(str) >= 0)
            {
                list[index].Position(list[index].InList(str)).Value--;
                if (list[index].Position(list[index].InList(str)).Value == 0)
                    list[index].Delete(str);
            }
        }

        public bool Search(string str)
        {
            int index = hash.Hash(str, size);
            return (list[index].InList(str) != -1);
        }
    }
}

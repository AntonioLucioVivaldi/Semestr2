using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw42
{
    public class Hash2 : IHash
    {
        public int Hash(string str, int value)
        {
            return str.GetHashCode() % (value - 1);
        }
    }
}

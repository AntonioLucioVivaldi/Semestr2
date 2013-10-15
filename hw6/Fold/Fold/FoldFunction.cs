using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fold
{
    public class FoldFunction
    {
        public static int Fold(List<int> list, int value, Func<int, int, int> function)
        {
            if (list.Count == 0)
            {
                throw new EmptyListException();
            }
            foreach (int element in list)
            {
                value = function(value, element);
            }
            return value;
        }
    }
}

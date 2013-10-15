using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class MapFunc
    {
        public static List<int> MapFunction(List<int> list, Func<int, int> function)
        {
            List<int> result = new List<int>();
            if (list.Count == 0)
            {
                throw new EmptyListException();
            }
            foreach (int element in list)
            {
                result.Add(function(element));
            }
            return result;
        }
    }
}

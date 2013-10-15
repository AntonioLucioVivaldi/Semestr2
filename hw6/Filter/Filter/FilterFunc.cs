using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filter
{
    public class FilterFunc
    {
        /// <summary>
        /// Filter function
        /// </summary>
        /// <param name="list">List</param>
        /// <param name="function">Condition</param>
        /// <returns></returns>
        public static List<int> Filter(List<int> list, Func<int, bool> function)
        {
            List<int> result = new List<int>();
            if (list.Count == 0)
            {
                throw new EmptyListException();
            }
            foreach (int element in list)
                if (function(element))
                {
                    result.Add(element);
                }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    public class Program
    {
        /// <summary>
        /// Method which sorts array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
       
        static void Main(string[] args)
        {
        }
    }
}

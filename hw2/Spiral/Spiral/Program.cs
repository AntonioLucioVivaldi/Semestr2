using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spiral
{
    public class Program
    {
        /// <summary>
        /// Methid is used to sort matrix in a spiral
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] HelixSort(int[,] array) 
        {
            int k = 0;
            int n = 5;
            int[] array1 = new int[n * n];
            int length = 0;
            int first = array.GetLength(0) / 2;
            int second = array.GetLength(1) / 2;
            int tool = 1;

            do 
            {
                for (int i = 0; i <= length; i++) 
                {
                    array1[k] = array[first, second];
                    k++;
                    first = first + tool;
                }

                if (length == array.GetLength(0) - 1) 
                {
                    break;
                }

                for (int i = 0; i <= length; i++) 
                {
                    array1[k] = array[first, second];
                    k++;
                    second = second - tool;
                }

                tool = -tool;
                length++;
            } while (length != array.GetLength(0));
            return array1;
        }

        static void Main(string[] args)
        {
        }
    }
}

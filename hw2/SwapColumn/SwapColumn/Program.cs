using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapColumn
{
    public class Program
    {
        /// <summary>
        /// Method is used to change two columns by places
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void SwapColumn(int [,] array, int i, int j)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                int temp = array[k, i];
                array[k, i] = array[k, j];
                array[k, j] = temp;
            }
        }

        /// <summary>
        /// Method is used to sort first elements of columns
        /// </summary>
        /// <param name="array"></param>
        public static void Sort(int[,] array)
        {
            Boolean flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.GetLength(0) - 1; i++)
                {
                    if (array[0, i] > array[0, i + 1])
                    {
                        SwapColumn(array, i, i + 1);
                        flag = true;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

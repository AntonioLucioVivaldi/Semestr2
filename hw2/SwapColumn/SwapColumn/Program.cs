using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapColumn
{
    public class Program
    {
        public static void PrintMatrix(int[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void SwapColumn(int [,] array, int i, int j)
        {
            for (int k = 0; k < 3; k++)
            {
                int temp = array[k, i];
                array[k, i] = array[k, j];
                array[k, j] = temp;
            }
        }

        public static void Sort(int[,] array)
        {
            Boolean flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < 2; i++)
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
            int[,] array = { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Before : \n");
            PrintMatrix(array);
            Sort(array);
            Console.WriteLine("After : \n");
            PrintMatrix(array);
        }
    }
}

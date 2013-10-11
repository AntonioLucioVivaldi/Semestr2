using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spiral
{
    public class Program
    {
        public static void PrintMatrix(int[,] array)
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

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
            int[,] array = { { 5, 6, 4, 7, 5 }, { 1, 2, 3, 2, 1 }, { 7, 8, 9, 6, 5 }, { 7, 0, 3, 6, 5 }, { 7, 8, 9, 6, 5 } };
            
            int[] array1 = HelixSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    public class Program
    {
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
            int length = 10;
            Console.WriteLine("Enter the array : \n");
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(array);
            Console.WriteLine("Sorted arrray: \n");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}

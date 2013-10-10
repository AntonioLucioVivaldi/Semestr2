using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonacci
{
    public class Program
    {
        public static int fib(int k)
        {
            int first = 1;
            int second = 1;
            for (int i = 1; i < k - 1; i++)
            {
                int temp = first;
                first = second + first;
                second = temp;
            }
            return first;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : \n");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fib(k));
        }
    }
}

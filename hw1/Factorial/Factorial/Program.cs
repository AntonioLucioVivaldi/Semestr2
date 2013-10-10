using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    public class Program
    {
        public static int factorial(int k)
        {
            if (k == 1)
                return 1;
            return k = k * factorial(k - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: \n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
    }
}

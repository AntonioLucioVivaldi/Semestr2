using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    public class Program
    {
        public static int Fibonacci(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            if (number == 0)
            {
                return 0;
            }
            int first = 1;
            int second = 1;
            for (int i = 1; i < number - 1; i++)
            {
                int temp = first;
                first = first + second;
                second = temp;
            }
            return first;
        }
        static void Main(string[] args)
        {
        }
    }
}

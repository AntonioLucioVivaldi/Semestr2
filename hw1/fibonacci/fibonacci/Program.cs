using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonacci
{
    public class Program
    {
        /// <summary>
        /// Method used to calculate Fibonacci number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Fibonacci(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            int first = 1;
            int second = 1;
            for (int i = 1; i < number - 1; i++)
            {
                int temp = first;
                first = second + first;
                second = temp;
            }
            return first;
        }

        static void Main(string[] args)
        {
        }
    }
}

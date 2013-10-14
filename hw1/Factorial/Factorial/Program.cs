using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    public class Program
    {
        /// <summary>
        /// Method used for factorial calculation
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Factorial(int number)
        {
            if (number < 1)
            {
                throw new NegativeNumberAndZeroException();
            }
            if (number == 1)
                return 1;
            return number * Factorial(number - 1);
        }

        static void Main(string[] args)
        {
        }
    }
}

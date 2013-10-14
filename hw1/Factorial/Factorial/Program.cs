using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    public class Program
    {
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException();
            }
            if (number == 0)
            {
                return 1;
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

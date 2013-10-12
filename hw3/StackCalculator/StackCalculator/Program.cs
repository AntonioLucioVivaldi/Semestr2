using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray stack = new StackArray(25);
            Calculator calc = new Calculator(stack);
            Console.Write("Enter expression ");
            string str = Console.ReadLine();
            Console.WriteLine("Result is ");
            Console.Write(calc.Realizator(str));
        }
    }
}

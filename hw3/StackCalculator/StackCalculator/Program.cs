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

            Calculator calculator = new Calculator();
            calculator.Push(10);
            calculator.Push(20);
            calculator.Push(40);
            calculator.Divide();
            Console.WriteLine(calculator.Result());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{

    public class Calculator
    {
        private IStack stack;
        private int numericNumber;

        public Calculator()
        {
            stack = new ListStack();
            numericNumber = 0;
        }

        public void Push(int num)
        {
            stack.Push(num);
            numericNumber++;
        }

        public void Add()
        {
            if (numericNumber < 2)
            {
                Console.WriteLine("More number needed");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 + num2);
            numericNumber = numericNumber - 2;
        }

        public void Subtract()
        {
            if (numericNumber < 2)
            {
                Console.WriteLine("More number needed");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 - num2);
            numericNumber = numericNumber - 2;
        }

        public void Multiply()
        {
            if (numericNumber < 2)
            {
                Console.WriteLine("More number needed");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 * num2);
            numericNumber = numericNumber - 2;
        }

        public void Divide()
        {
            if (numericNumber < 2)
            {
                Console.WriteLine("More number needed");
                return;
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 / num2);
            numericNumber = numericNumber - 2;
        }

        public int Result()
        {
            numericNumber--;
            return stack.Pop();
        }
    }

}

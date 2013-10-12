using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    public class Calculator
    {
        private IStack newStack;

        public Calculator(IStack stack)
        {
            this.newStack = stack;
        }

        public int Realizator(string str)
        {
            int temp = 0;
            int number = 0;
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] != '+') && (str[i] != '*') && (str[i] != '-') && (str[i] != '/') && (str[i] != ' '))
                {
                    number = (number * 10) + (int)str[i] - (int)'0';
                }
                else
                {
                    result = number;
                    if (str[i] != ' ')
                    {
                        temp = newStack.Pop();
                    }
                    if (str[i] == '+')
                    {
                        result = temp + number;
                    }
                    if (str[i] == '-')
                    {
                        result = temp - number;
                    }
                    if (str[i] == '*')
                    {
                        result = temp * number;
                    }
                    if (str[i] == '/')
                    {
                        result = temp / number;
                    }
                    newStack.Push(result);
                    result = 0;
                    number = 0;
                }
                
            }
            return newStack.Pop();
        }
    }
}

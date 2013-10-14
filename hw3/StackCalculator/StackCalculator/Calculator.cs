using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{

    public class Calculator
    {
        /// <summary>
        /// Calculator constructor
        /// </summary>
        public Calculator()
        {
            stack = new ListStack();
            numericNumber = 0;
        }

        /// <summary>
        /// allows to choose stack
        /// </summary>
        private IStack stack;

        /// <summary>
        /// Counts number of numbers
        /// </summary>
        private int numericNumber;

        /// <summary>
        /// Method which allow to put an element to stack
        /// </summary>
        /// <param name="num"></param>
        public void Push(int num)
        {
            stack.Push(num);
            numericNumber++;
        }

        /// <summary>
        /// Method that adds two numbers and put result to stack
        /// </summary>
        public void Add()
        {
            if (numericNumber < 2)
            {
                throw new NotEnoughNumbersException();
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 + num2);
            numericNumber = numericNumber - 2;
        }

        /// <summary>
        /// Method that subtracts two numbers and put result to stack
        /// </summary>
        public void Subtract()
        {
            if (numericNumber < 2)
            {
                throw new NotEnoughNumbersException();
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 - num2);
            numericNumber = numericNumber - 2;
        }

        /// <summary>
        /// Method that multiplyes two numbers and put result to stack
        /// </summary>
        public void Multiply()
        {
            if (numericNumber < 2)
            {
                throw new NotEnoughNumbersException();
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 * num2);
            numericNumber = numericNumber - 2;
        }

        /// <summary>
        /// Method that divides two numbers and put result to stack
        /// </summary>
        public void Divide()
        {
            if (numericNumber < 2)
            {
                throw new NotEnoughNumbersException();
            }
            int num1 = stack.Pop();
            int num2 = stack.Pop();
            stack.Push(num1 / num2);
            numericNumber = numericNumber - 2;
        }

        /// <summary>
        /// Method that gets result of operation
        /// </summary>
        /// <returns></returns>
        public int Result()
        {
            numericNumber--;
            return stack.Pop();
        }
    }

}

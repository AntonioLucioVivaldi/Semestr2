using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    public class StackArray : IStack
    {
        private int[] Array;

        private int Current = -1;

        public StackArray(int size)
        {
            Array = new int[size];
        }

        public void Push(int value)
        {
            Array[Current++] = value;
        }

        public int Pop()
        {
            if (Current == -1)
            {
                Console.WriteLine("Empty stack");
                return 0;
            }
            return Array[Current--];
        }
    }
}

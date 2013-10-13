using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{

    public class ArrayStack : IStack
    {
        private int length;
        private int[] array;

        public ArrayStack()
        {
            length = 0;
            array = new int[100];
        }

        public bool IsEmpty()
        {
            if (length == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            return (length == 0);
        }

        private bool CheckLength()
        {
            return (array.Length - 2 > length);
        }

        public void Push(int value)
        {
            if (!(CheckLength()))
            {
                int[] temp = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];
                }
                array = temp;
            }
            array[length] = value;
            length++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return 0;
            }
            int temp = array[length - 1];
            length--;
            array[length] = 0;
            return temp;
        }
    }
}

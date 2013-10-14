using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{

    public class ArrayStack : IStack
    {
        /// <summary>
        /// Stack constructor
        /// </summary>
        public ArrayStack()
        {
            length = 0;
            array = new int[100];
        }

        private int length;
        private int[] array;

        /// <summary>
        /// Method is used to check if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return length == 0;
        }

        /// <summary>
        /// Method is used 
        /// </summary>
        /// <returns></returns>
        private bool CheckLength()
        {
            return (array.Length - 2 > length);
        }

        /// <summary>
        /// Method is used to add an element
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Method is used to delete an element
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new IsEmptyException();
            }
            int temp = array[length - 1];
            length--;
            array[length] = 0;
            return temp;
        }
    }
}

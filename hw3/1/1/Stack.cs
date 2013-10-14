using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    public class Stack
    {
        /// <summary>
        /// Stack constructor
        /// </summary>
        private class StackElement
        {
            public int Val { get; set; }

            public StackElement Next { get; set; }
        }

        /// <summary>
        /// Head of stack
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Method is used to add a value to stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            StackElement newElement = new StackElement();
            newElement.Val = value;
            newElement.Next = head;
            head = newElement;
        }

        /// <summary>
        /// Method is used to delete element from top of the stack
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (head == null)
            {
                throw new EmptyStackException();
            }
            int toDelete = head.Val;
            head = head.Next;
            return toDelete;
        }

        /// <summary>
        /// Method used to check if stack empty or not
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return head == null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    public class ListStack : IStack
    {
        /// <summary>
        /// Stack constructor
        /// </summary>
        private class StackElement
        {
            public int Value { get; set; }

            public StackElement Next { get; set; }

        }

        /// <summary>
        /// Head of stack
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Method which adds an element to stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            StackElement newStackElement = new StackElement();
            newStackElement.Value = value;
            newStackElement.Next = head;
            head = newStackElement;
        }

        /// <summary>
        /// Method which deletes an element from top of stack
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (head == null)
            {
                throw new IsEmptyException();
            }
            int toDelete = head.Value;
            head = head.Next;
            return toDelete;
        }
    }
}

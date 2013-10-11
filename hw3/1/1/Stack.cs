using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    public class Stack
    {
        private class StackElement
        {
            public int Val { get; set; }

            public StackElement Next { get; set; }
        }

        private StackElement head;

        public Stack()
        {
            head = null;
        }

        public void Push(int value)
        {
            StackElement newElement = new StackElement();
            newElement.Val = value;
            newElement.Next = head;
            head = newElement;
        }

        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Empty stack");
                return 0;
            }
            int toDelete = head.Val;
            head = head.Next;
            return toDelete;
        }

        public bool isEmpty()
        {
            return head == null;
        }
    }
}

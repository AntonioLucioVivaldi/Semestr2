using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    public class Stack : IStack
    {
        private class StackElement
        {
            public int Value { get; set; }

            public StackElement Next { get; set; }
        }

        private StackElement head = null;

        public void Push(int value)
        {
            StackElement newStackElement = head;
            newStackElement.Value = value;
            newStackElement.Next = head;
            head = newStackElement;
        }

        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Empty stack");
                return 0;
            }
            StackElement toDelete = head;
            head = toDelete.Next;
            return toDelete.Value;
        }
    }
}

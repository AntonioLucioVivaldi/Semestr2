using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    public class ListStack : IStack
    {
        private class StackElement
        {
            public int Value { get; set; }

            public StackElement Next { get; set; }

        }

        private StackElement head = null;

        public void Push(int value)
        {
            StackElement newStackElement = new StackElement();
            newStackElement.Value = value;
            newStackElement.Next = head;
            head = newStackElement;
        }

        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            int toDelete = head.Value;
            StackElement pointer = head;
            head = head.Next;
            return toDelete;
        }
    }
}

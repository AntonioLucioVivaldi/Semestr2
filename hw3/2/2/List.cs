using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    public class List
    {
        private class ListElement
        {
            public int Value { get; set; }
            public ListElement Next { get; set; }
        }

        private ListElement firstElement;

        public List()
        {
            firstElement = null;
        }

        public void AddElement(int value)
        {
            ListElement newListElement = new ListElement();
            newListElement.Value = value;
            if (firstElement == null)
            {
                firstElement = newListElement;
            }
            else
            {
                ListElement pointer = firstElement;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = newListElement;
            }
        }

        public void DeleteElement(int value)
        {
            if (firstElement == null)
            {
                Console.WriteLine("List is Empty \n ");
            }
            else
            {
                if (firstElement.Value == value)
                {
                    if (firstElement.Next != null)
                    {
                        firstElement = firstElement.Next;
                    }
                    else
                    {
                        firstElement = null;
                    }
                }
                else
                {
                    ListElement pointer = firstElement;
                    while ((pointer.Next.Value != value) && (pointer != null))
                    {
                        pointer = pointer.Next;
                    }
                    pointer.Next = pointer.Next.Next;
                }
            }
        }

        public void PrintList()
        {
            if (firstElement == null)
            {
                Console.WriteLine("List is empty \n");
            }
            else
            {
                ListElement pointer = firstElement;
                while (pointer != null)
                {
                    Console.Write(pointer.Value + " ");
                    pointer = pointer.Next;
                }
            }
        }

        public bool IsEmpty()
        {
            return firstElement == null; 
        }
    }
}

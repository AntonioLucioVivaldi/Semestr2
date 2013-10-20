using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    public class List
    {
        /// <summary>
        /// Class used to build list
        /// </summary>
        private class ListElement
        {
            public int Value { get; set; }
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// First element of list
        /// </summary>
        private ListElement firstElement = null;
        private int length = 0;

        /// <summary>
        /// Methos is used to add an element to list
        /// </summary>
        /// <param name="value"></param>
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
            length++;
        }

        /// <summary>
        /// Method is used to add an element to a current position
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="index">position</param>
        public void AddToPosition(int value, int index)
        {
            ListElement pointer = firstElement;
            ListElement newListElement = new ListElement();
            newListElement.Value = value;
            if (IsEmpty())
            {
                firstElement = newListElement;
            }
            else
            {
                if (index == 0)
                {
                    firstElement = newListElement;
                    newListElement.Next = firstElement.Next;
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        pointer = pointer.Next;
                    }
                    newListElement.Next = pointer.Next;
                }
            }
            length++;
        }

        /// <summary>
        /// Method is used to delete an element from list
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(int value)
        {
            if (IsEmpty())
            {
                throw new EmptyListException();
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
            length--;
        }

        /// <summary>
        /// Method is used to print list
        /// </summary>
        public void PrintList()
        {
            if (IsEmpty())
            {
                throw new EmptyListException();
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

        /// <summary>
        /// Value of length
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return length;
        }

        public int GetFirst()
        {
            return firstElement.Value;
        }

        /// <summary>
        /// Method is used to check if list is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return firstElement == null; 
        }
    }
}

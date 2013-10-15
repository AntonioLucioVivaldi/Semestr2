using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniqueList
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
                if (Exists(value))
                {
                    throw new AlreadyExistsException();
                }
                ListElement pointer = firstElement;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = newListElement;
            }
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
            if (!Exists(value))
            {
                throw new NoSuchElementException();
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
                    while ((pointer.Next.Value != value))
                    {
                        pointer = pointer.Next;
                    }
                    pointer.Next = pointer.Next.Next;
                }
            }
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
        /// Method is used to search for an element
        /// </summary>
        /// <param name="value">element of List</param>
        /// <returns></returns>
        public bool Exists(int value)
        {
            ListElement pointer = firstElement;
            while (pointer != null)
            {
                if (pointer.Value == value)
                {
                    return true;
                }
                pointer = pointer.Next;
            }
            return false;
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
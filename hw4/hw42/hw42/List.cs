using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw42
{
    public class List
    {
        public class ListElement
        {
            public string Str { get; set; }
            public ListElement Next { get; set; }
            public int Value { get; set; }

            public ListElement(string str, int value)
            {
                this.Str = str;
                this.Value = value;
                this.Next = null;
            }
        }

        public ListElement firstElement = null;

        public void Add(string str, int value)
        {
            ListElement newElement = new ListElement(str, value);
            if (firstElement == null)
            {
                firstElement = newElement;
            }
            else
            {
                ListElement pointer = firstElement;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = newElement;
            }
        }

        public void Delete(string str)
        {
            if (firstElement == null)
            {
                Console.WriteLine("Empty list");
            }
            ListElement pointer = firstElement;
            if (pointer.Str == str)
            {
                firstElement = pointer.Next;
            }
            while (pointer.Next != null)
            {
                if (pointer.Next.Str == str)
                {
                    pointer.Next = pointer.Next.Next;
                }
                pointer = pointer.Next;
            }
            Console.WriteLine("Error");
        }

        public int InList(string str)
        {
            ListElement pointer = firstElement;
            int i = -1;
            while (pointer != null)
            {
                if (pointer.Str == str)
                {
                    return i + 1;
                }
                else
                {
                    pointer = pointer.Next;
                }
                i++;
            }
            return i;
        }

        public ListElement Position(int position)
        {
            ListElement pointer = firstElement;
            for (int i = 0; i < position; i++)
            {
                pointer = pointer.Next;
            }
            return pointer;
        }
    }
}

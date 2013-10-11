using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            for (int i = 0; i < 5; i++)
            {
                list.AddElement(i);
            }
            list.DeleteElement(3);
            list.PrintList();

        }
    }
}

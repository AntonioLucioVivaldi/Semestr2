using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCalculator
{
    interface IStack
    {
        void Push(int value);

        int Pop();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseTree
{
    public interface Node
    {
        double Calculate();

        void Print();
    }
}

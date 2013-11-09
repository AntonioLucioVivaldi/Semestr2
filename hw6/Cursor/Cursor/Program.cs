using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cursor
{
    public class Program
    {
        static void Main(string[] args)
        {
            CursorEvent move = new CursorEvent();
            Move cursor = new Move(move);
            move.Run();
        }
    }
}

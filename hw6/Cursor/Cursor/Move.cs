using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cursor
{
    public class Move
    {
        public Move(CursorEvent ev)
        {
            ev.left += new EventHandler(CursoreMoveLeft);
            ev.right += new EventHandler(CursoreMoveRight);
            ev.up += new EventHandler(CursoreMoveTop);
            ev.down += new EventHandler(CursoreMoveBottom);
        }

        /// <summary>
        /// Moves cursor to the left
        /// </summary>
        public void CursoreMoveLeft(Object sender, EventArgs e)
        {
            if (Console.CursorLeft > 0)
                Console.CursorLeft--;
        }

        /// <summary>
        /// Moves cursor to the right
        /// </summary>
        public void CursoreMoveRight(Object sender, EventArgs e)
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
                Console.CursorLeft++;
        }

        /// <summary>
        /// Moves cursor to the top
        /// </summary>
        public void CursoreMoveTop(Object sender, EventArgs e)
        {
            if (Console.CursorTop > 0)
                Console.CursorTop--;
        }

        /// <summary>
        /// Moves cursor to the bottom
        /// </summary>
        public void CursoreMoveBottom(Object sender, EventArgs e)
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
                Console.CursorTop++;
        }
    }
}
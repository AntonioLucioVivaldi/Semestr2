using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseTree
{
    public class NodeOperand : Node
    {
        private double value;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="value"></param>
        public NodeOperand(double value)
        {
            this.value = value;
        }

        public void Print()
        {
            Console.Write(string.Format(" {0} ", this.value));
        }

        public double Calculate()
        {
            return value;
        }
    }
}

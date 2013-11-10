using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseTree
{
    public class NodeOperation : Node
    {
        private Node left;
        private Node right;
        private string signature;
        private Func<double, double, double> perform;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public NodeOperation(string sign, Func<double, double, double> performOperation)
        {
            this.perform = performOperation;
            this.signature = sign;
        }

        public double Calculate()
        {
            return perform(left.Calculate(), right.Calculate());
        }

        public void Print()
        {
            Console.Write("({0} ", signature);
            left.Print();
            right.Print();
            Console.Write(")");
        }

        /// <summary>
        /// Add an operand
        /// </summary>
        public Node AddOperand(Node operand)
        {
            if (left == null)
            {
                return left = operand;
            }
            else
            {
                if (right == null)
                {
                    return right = operand;
                }
                else
                {
                    throw new ExtraNodeException();
                }
            }
        }
    }
}

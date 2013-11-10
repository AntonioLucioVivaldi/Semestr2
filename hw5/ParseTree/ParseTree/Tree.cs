using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ParseTree
{
    public class Tree
    {
        private string[] tokens;
        private Dictionary<string, Func<double, double, double>> operation;
        private int counter;

        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        /// <param name="path"></param>
        public Tree(string path)
        {
            string expression = "";
            using (StreamReader f = new StreamReader(path))
            {
                expression = f.ReadLine();
            }
            this.operation = new Dictionary<string, Func<double, double, double>>
            {
                { "+", (x, y) => x + y },
                { "-", (x, y) => x - y },
                { "*", (x, y) => x * y },
                { "/", (x, y) => x / y }
            };
            this.tokens = expression.Split(new char[] { ' ' });
            this.counter = 0;
        }

        public double Calculate(Node tree)
        {
            return tree.Calculate();
        }

        public void PrintTree(Node tree)
        {
            tree.Print();
        }

        /// <summary>
        /// Build tree
        /// </summary>
        public void Build(ref Node current)
        {
            string token = tokens[counter++];
            if (token == ")")
            {
                return;
            }

            if (operation.ContainsKey(token))
            {
                if (current != null)
                {
                    var currentOperation = current as NodeOperation;
                    Node newCurrent = currentOperation.AddOperand(new NodeOperation(token, operation[token]));
                    Build(ref newCurrent);
                }
                else
                {
                    current = new NodeOperation(token, operation[token]);
                }
            }
            else
            {
                double value;
                if (double.TryParse(token, out value))
                {
                    if (current != null)
                    {
                        (current as NodeOperation).AddOperand(new NodeOperand(value));
                    }
                    else
                    {
                        current = new NodeOperand(value);
                    }
                }
            }
            Build(ref current);
        }
    }
}


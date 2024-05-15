using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Node
    {
        private int Value { get; set; }
        private Node Next { get; set; }

        public Node(int value)
        {
            this.Value = value;
        }

        public Node(int value, Node next) 
        { 
            this.Value = value;
            this.Next = next;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Node<T>
    {
        public int Value { get; set; }
        public Node<int> Next { get; set; }
        public Node(int value)
        {
            this.Value = value;
        }
        public Node(int value, Node<int> next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}

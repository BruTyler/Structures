using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        public Node(T data, Node<T> next)
        {
            Value = data;
            Next = next;
        }

        public Node<T> Next
        {
            get;
            private set;
        }

        public T Value
        {
            get;
            private set;
        }
    }
}

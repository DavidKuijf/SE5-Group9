using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_5_DataTypeLib
{
    public class Node<T>
    {
        public T Data { get; set; }
    }

    public class BinearyNode<T> : Node<T>
    {

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public BinearyNode(T item)
        {
            Data = item;
        }
    }
}

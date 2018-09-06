using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5DataTypes
{
    class BinearyTree
    {
        public BinearyNode Root { get; }

        public bool Add(Type item)
        {
            return false;
        }

        public BinearyTree(Type item)
        {
            Root = new BinearyNode(item);
        }

    }
    class Node
    {
        public Type Data { get; set; }
    }

    class BinearyNode : Node
    {

        public Node Left { get; set; }
        public Node Right { get; set; }

        public BinearyNode(Type item)
        {
            Data = item;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_5_DataTypeLib
{
    public class BinearyTree<T>
    {
        public BinearyNode<T> Root { get; }

        public bool Add(T item)
        {

            return false;
        }

        public BinearyTree(T item)
        {
            Root = new BinearyNode<T>(item);
        }

    }
   
}

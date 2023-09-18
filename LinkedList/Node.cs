using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public Node(object data)
        {
            this.Data = data;
            this.Next = null;
        }

        public object Data;
        public Node Next;
    }
}

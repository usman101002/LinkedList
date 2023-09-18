using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public object Data { get; }
        public Node Next { get; set; }

        public Node(object data)
        {
            this.Data = data;
            this.Next = null;
        }

        
    }
}

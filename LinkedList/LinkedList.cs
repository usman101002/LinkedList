using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        private Node head { get; set; }
        public void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node cur = head;
                while (cur.Next != null)
                {
                    cur = cur.Next;
                }
                cur.Next = new Node(data);

            }
        }
    }
}

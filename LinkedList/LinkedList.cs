using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList<T> : IEnumerable
    {
        public LinkedList(T data)
        {
            this.head = new Node<T>(data);
        }

        private Node<T> head { get; set; }
        public void Add(T data)
        {
            Node<T> cur = head;
            while (cur.Next != null)
            {
                cur = cur.Next;
            }
            cur.Next = new Node<T>(data);
        }

        

        public void Loop(Action<T> action)
        {
            Node<T> cur = head;
            while (cur != null)
            {
                action(cur.Data);
                cur = cur.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node<T> cur = head;
            while (cur != null)
            {
                yield return cur.Data;
                cur = cur.Next;
            }
        }
    }
}

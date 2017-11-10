using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLibrary1
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }
        public LinkedList<T> Next { get; internal set; }
        public LinkedList<T> Prev { get; internal set; }
    }

    public class LinkList<T>: IEnumerable<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public GenericsLibrary1.LinkedListNode<T> Last { get; private set; }

        public LinkedListNode<T> AddLast(T node)
        {
            var newNode = new GenericsLibrary1.LinkedListNode<T>(node);
            if (First == null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                Last.Next = newNode.Next;
                Last = newNode;
            }
            return newNode;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = First;

            while (current != null)
            {
                yield return current.Value;
                //current = current.Next.First;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericsLibrary1
{
    public class LinkedListNode
    {
        public LinkedListNode(object value)
        {
            this.Value = value;
        }

        public object Value { get; private set; }

        public LinkedListNode Next { get; internal set; }
        public LinkedListNode Prev { get; internal set; }
    }

    public class LinkedList : IEnumerable
    {
        public LinkedListNode First { get; private set; }
        public LinkedListNode Last { get; private set; }

        public LinkedListNode AddLast(object node)
        {
            var newNode = new LinkedListNode(node);
            if (this.First == null)
            {
                this.First = newNode;
                this.Last = this.First;
            }
            else
            {
                this.Last.Next = newNode;
                this.Last = newNode;
            }
            return newNode;
        }

        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = this.First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }

}

using System;

namespace MyDelicatessen.Queues
{
    public class Queue<T>
    {
        private class Node { public T value; public T next; };

        int length;
        Node<T> first;
        Node<T> last;

        public void Enqueue(T value)
        {

            if (length == 0)
            {
                first = new Node<T> { Value = value };
                last = first;
            }
            else
            {
                last.Next = new Node<T> { Value = value };
                last = last.Next;
            }

            length++;
        }

        public T Dequeue()
        {
            var result = Peek();

            first = first.next;
            length--;
            if (length == 0)
            {
                last = null;
            }
            return result;
        }

        public T Peek()
        {
            if (length == 0) throw new InvalidOperationException("Queue is empty");
            return first.Value;
        }

    }
}
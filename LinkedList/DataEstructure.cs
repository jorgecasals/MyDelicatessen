using System;

namespace MyDelicatessen.LinkedLists
{
    public class Node<T>
    {
        public T Value;

        public Node<T> Next;
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int Length;

        public LinkedList(T value)
        {
            head = new Node<T>
            {
                Value = value,
                Next = null
            };

            tail = head;

            this.Length = 1;
        }

        public void Append(T value)
        {
            tail.Next = new Node<T> { Value = value };
            tail = tail.Next;
            Length++;
        }

        public void Prepend(T value)
        {
            Node<T> newHead = new Node<T>
            {
                Value = value,
                Next = head
            };
            head = newHead;

            Length++;
        }

        public T Get(int index)
        {
            var node = GetNode(index);

            return node.Value;
        }

        public void Insert(int index, T value)
        {

            if (index <= 0)
            {
                Prepend(value);
            }
            else if (index >= Length)
            {
                Append(value);
            }
            else
            {
                Node<T> previous = GetNode(index - 1);
                Node<T> newNode = new Node<T> { Value = value, Next = previous.Next };
                previous.Next = newNode;
            }
        }

        public void Delete(int index)
        {

            if (index == 0)
            {
                head = head.Next;
            }//tail case needs to be checked while deleting normally.

            Node<T> node = GetNode(index - 1);
            node.Next = node.Next.Next;
            if (node.Next == null)
            {
                tail = node;
            }
            Length--;
        }

        //first option is to add alements to stack and then iterate over them re-building the linked list;
        //second option is to use inductive procedure by calling recursively reversing the rest of the list and adding the current element as the next of the tail.
        //Third option is to do it manually saving the current.next.next element and reversing what we have. Memory O(1), Time O(N)
        //Fourth option is to iterate and call append on a new list: Memory O(N), time O(1)
        public void Reverse()
        {
            if (Length <= 1)
                return;

            var current = head;
            var next = head.Next;
            current.Next = null;
            while (next.Next != null)
            {
                var nonReversedYet = next.Next;
                next.Next = current;
                current = next;
                next = nonReversedYet;
            }
            next.Next = current;

            var mytail = head;
            head = tail;
            tail = mytail;
        }

        private Node<T> GetNode(int index)
        {
            if (index < 0 || index > Length)
                throw new InvalidOperationException($"Cannot get element at position: {index}");

            int currentIndext = 0;
            var node = head;

            while (currentIndext < index)
            {
                node = node.Next;
            }
            return node;
        }

    }
}

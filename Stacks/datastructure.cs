using System;

namespace MyDelicatessen.Stacks
{
    /// <summary>
    /// Represents a last-in first-out data structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        Node<T> top;
        int length;

        public T Pop()
        {
            var result = Peek();
            top = top.Next;
            length--;
        }

        public void Push(T value)
        {
            top = new Node<T> { Value = value, Next = top };
            length++;
        }

        public T Peek()
        {
            if (length == 0) throw new InvalidOperationException("stack is empty");

            return top.Value;
        }

        public int Length => length;

        private class Node<T>
        {
            Node Next;
            T Value;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListInCsharp
{
    public class Node<T>
    {
        public T Data { get; private set; }
        public Node<T> Next { get; private set; }
        public Node<T> Prev { get; private set; }


        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
        public void setData(T data)
        {
            Data = data;
        }
        public void setNext(Node<T> next)
        {
            Next = next;
        }
        public void setPrev(Node<T> prev)
        {
            Prev = prev;
        }
    }
}

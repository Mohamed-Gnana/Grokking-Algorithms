using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListInCsharp
{
    class LinkedListy<T>
    {
        int count;
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        
        public LinkedListy()
        {
            count = 0;
            Head = null;
            Tail = null;
        }
        void setHead(Node<T> head)
        {
            Head = head;
        }
        void setTail(Node<T> tail)
        {
            Tail = tail;
        }
        public void insertFront(T data)
        {
            Node<T> DNode = new Node<T>(data);
            DNode.setNext(Head);
            if (Head == null)
                Tail = DNode;
            else
                Head.setPrev(DNode);
            setHead(DNode);
            count++;
        }
        public void insert(T data)
        {
            Node<T> DNode = new Node<T>(data);
            DNode.setPrev(Tail);
            DNode.setNext(null);
            if (Tail == null)
                Head = DNode;
            else
                Tail.setNext(DNode);
            setTail(DNode);
            count++;
        }
        public void insertWithIndex(T data, int index)
        {
            if (index > count)
            {
                Console.WriteLine("The List doesn't have that many items!!!");
                return;
            }
            Node<T> DNode = new Node<T>(data), next = Head, prev = null;
            for(int i = 0; i< index; i++)
            {
                prev = next;
                next = Head.Next;
            }
            if (next != null && prev != null)
            {
                DNode.setNext(next);
                DNode.setPrev(prev);
                prev.setNext(DNode);
                next.setPrev(DNode);
            }
            else if (next == null && prev != null)
            {
                DNode.setPrev(prev);
                DNode.setNext(next);
                prev.setNext(DNode);
                Tail = DNode;
            }
            else if (next != null && prev == null)
            {
                DNode.setNext(next);
                DNode.setPrev(prev);
                next.setPrev(DNode);
                Head = DNode;
            }
            else
            {
                Head = DNode;
                Tail = DNode;
            }
            count++;
        }

        public T getLastNode()
        {
            return Tail.Data;
        }
        public T getFirtNode()
        {
            return Head.Data;
        }
        public int getCount()
        {
            return count;
        }
    }
}

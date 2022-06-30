using System;
using System.Collections.Generic;
using System.Text;

namespace StackinCsharp
{
    public class Stack<T>
    {
        List<T> list;
        int sp;

        public Stack()
        {
            list = new List<T>();
            sp = -1;
        }
        public Stack(T item)
        {
            list = new List<T>() { item };
            sp = 0;
        }
        public Stack(List<T> list)
        {
            this.list = list;
            sp = list.Count - 1;
        }
        public void Push(T element)
        {
            list.Add(element);
            sp++;
        }

        public T Pop()
        {
            T item = list[sp];
            list.RemoveAt(sp);
            sp--;
            return item;
        }

        public int Count()
        {
            return list.Count;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public void Print()
        {
            foreach(T item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
    }
}

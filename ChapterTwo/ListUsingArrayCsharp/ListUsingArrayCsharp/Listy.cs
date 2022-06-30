using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListUsingArrayCsharp
{
    public class Listy<T>
    {
        T[] list;
        public Listy(T element)
        {
            list = new T[] { element };
        }
        public Listy(T[] arr)
        {
            list = new T[arr.Length];
            arr.CopyTo(list, 0);
        }

        public void push(T key)
        {
            list = list.Concat(new T[] { key }).ToArray();
        }
        public bool IsEmpty()
        {
            return list.Length == 0;
        }

        public T pop()
        {
            T element;
            if (!IsEmpty())
            {
                element = list[list.Length - 1];
                Array.Resize(ref list, list.Length - 1);
            }
            else
            {
                element = default;
            }
            return element;
        }
    }
}

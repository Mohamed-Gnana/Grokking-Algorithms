using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleHashTableAKADictionary
{
    public class HashTable<T,U>
    {
        U[] elements;
        int count;

        public HashTable()
        {
            elements = new U[10];
            count = 0;
        }
        public void Add(string t, U u)
        {
            if (checkLoadFactor() >= 0.7)
            {
                Array.Resize(ref elements, elements.Length * 2);
            }
            int index = getIndexThroughHashFunction(t.ToLower());
            elements[index] = u;
            count++;
        }

        public U getValue(string t)
        {
            int index = getIndexThroughHashFunction(t.ToLower());
            return elements[index];
        }

        public U[] getDic()
        {
            return elements;
        }



        private int getIndexThroughHashFunction(string t)
        {
            int index = 0;
            for (int i = 0; i < t.Length; i++)
            {
                index += getValue(t[i]);
            }
            return index % elements.Length;
        }

        private int getValue(char v)
        {
            Dictionary<char, int> value = new Dictionary<char, int>();
            value.Add('a', 2);
            value.Add('b', 3);
            value.Add('c', 5);
            value.Add('d', 7);
            value.Add('e', 11);
            value.Add('f', 13);
            value.Add('g', 17);
            value.Add('h', 19);
            value.Add('i', 23);
            value.Add('j', 29);
            value.Add('k', 31);
            value.Add('l', 37);
            value.Add('m', 41);
            value.Add('n', 43);
            value.Add('o', 47);
            value.Add('p', 53);
            value.Add('q', 59);
            value.Add('r', 61);
            value.Add('s', 67);
            value.Add('t', 71);
            value.Add('u', 73);
            value.Add('v', 79);
            value.Add('w', 83);
            value.Add('x', 89);
            value.Add('y', 97);
            value.Add('z', 101);

            return value[v];
        }

        private double checkLoadFactor()
        {
            double ret = (double)count / (double)elements.Length;
            return ret;
        }
    }
}

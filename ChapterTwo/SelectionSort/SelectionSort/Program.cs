using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 1, 2, 5, 18, 4, 3, 11 };
            ints = Sort<int>.SS(ints, comparator);
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
        public static int comparator(int x, int y)
        {
            if (x == y)
                return 0;
            else if (x > y)
                return 1;
            else
                return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> strings = new List<string>() { "a", "aa", "aaa", "b", "bb", "bbb" };
            int? exist1 = strings.BS<string>("aaa", pl2);
            if (exist1 != null)
                Console.WriteLine("The location is : " + (exist1+1));
            else
                Console.WriteLine("Doesn't exist");
        }

        public static int pl(int x, int y)
        {
            if (x == y)
                return 0;
            else if (x > y)
                return 1;
            else
                return -1;
        }
        public static int pl2(string x, string y)
        {
            int e = String.Compare(x, y);
            return e; 
        }
    }
}

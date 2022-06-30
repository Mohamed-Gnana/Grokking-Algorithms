using System;
using System.Collections.Generic;
namespace BinarySearchRecursionCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search.BS<int>(new List<int>() { 1, 2, 3, 4, 5 }, 1, compare));
        }
        internal static int compare(int x, int y)
        {
            if (x == y)
                return 0;
            else if (x < y)
                return -1;
            else
                return 1;
        }
    }
}

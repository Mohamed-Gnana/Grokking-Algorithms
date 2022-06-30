using System;
using System.Collections.Generic;

namespace QuickSortInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> print = Console.WriteLine;
            Sort.QS(new List<int>() { 5, 2, 4, 1, 3 }, compare).ForEach(print);
            Sort.QSV2(new List<int>() { 5, 2, 4, 1, 3 }, compare).ForEach(print);
            Sort.QSV3(new List<int>() { 5, 2, 4, 1, 3 }, compare).ForEach(print);
        }
        internal static bool compare(int x, int y)
        {
            return x >= y;
        }
    }
}

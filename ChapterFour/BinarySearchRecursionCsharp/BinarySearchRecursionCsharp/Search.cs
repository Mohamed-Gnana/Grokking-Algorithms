using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchRecursionCsharp
{
    public delegate int typeComparator<T>(T x, T y);
    public static class Search
    {
        public static int? BS<T>(List<T> list, T key, typeComparator<T> compare, int low = 0, int high = 0)
        {
            if (low > high)
                return null;
            if (high == 0)
                high = list.Count - 1;
            int mid = (low + high)/2;
            T guess = list[mid];
            if (compare(key, guess) == 0)
                return mid;
            else if (compare(key, guess) < 0)
                return BS(list, key, compare, low, mid - 1);
            else
                return BS(list, key, compare, mid + 1, high);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public static class Common
    {
        public delegate int intcomparator<T>(T x, T y);
        public static int? BS<T>(this List<T> list, T key, intcomparator<T> p)
        {
            int low = 0, high = list.Count - 1, mid;
            while(low <= high)
            {
                mid = (low + high) / 2;
                T guess = list[mid];
                if (p(guess, key) == 0)
                    return mid;
                if (p(guess, key) < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public delegate int Typecomparator<T>(T x, T y);
    public static class Sort<T>
    {
        public static List<T> SS(List<T> list, Typecomparator<T> compare)
        {
            List<T> sortedList = new List<T>();
            int smallest;
            int count = list.Count;
            for(int i = 0; i < count; i++)
            {
                smallest = getSmallest(list, compare);
                sortedList.Add(list[smallest]);
                list.RemoveAt(smallest);
            }
            return sortedList;
        }

        private static int getSmallest(List<T> list, Typecomparator<T> compare)
        {
            int smallestIndex = 0;
            for(int i = 1; i < list.Count; i++)
            {
                if (compare(list[i], list[smallestIndex]) < 0)
                    smallestIndex = i;
            }
            return smallestIndex;
        }
    }
}

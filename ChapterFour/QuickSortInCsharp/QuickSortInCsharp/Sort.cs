using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickSortInCsharp
{
    public delegate bool typeComparator<T>(T x, T y);
    public static class Sort
    {
        public static List<T> QS<T>(List<T> list, typeComparator<T> compare)
        {
            if (list.Count < 2)
                return list;
            T pivot = list[0];
            List<T> newList = list.GetRange(1, list.Count - 1);
            List<T> less = newList.FindAll(e => compare(pivot, e));
            List<T> greater = newList.FindAll(item => compare(pivot, item) == false);

            List<T> ListSorted = QS(less, compare);
            ListSorted = ListSorted.Concat(new List<T>() { pivot }).ToList();
            ListSorted = ListSorted.Concat(QS(greater, compare)).ToList();

            return ListSorted;
        }

        public static List<T> QSV2<T>(List<T> list, typeComparator<T> compare)
        {
            if (list.Count < 2)
                return list;
            T pivot = list[0];
            int pivotIndex;
            (list, pivotIndex) = FindPivotIndex<T>(list, 1, list.Count - 1, pivot, compare);
            T temp = list[pivotIndex];
            list[pivotIndex] = pivot;
            list[0] = temp;
            return QSV2(list.GetRange(0, pivotIndex), compare).Concat(new List<T>() { pivot }).ToList().Concat(QSV2(list.GetRange(pivotIndex + 1, list.Count - pivotIndex - 1), compare)).ToList();
        }
        public static List<T> QSV3<T>(List<T> list, typeComparator<T> compare)
        {
            if (list.Count < 2)
                return list;
            int pivotIndex = new Random().Next(list.Count);
            T pivot = list[pivotIndex];
            list.RemoveAt(pivotIndex);
            (list, pivotIndex) = FindPivotIndex(list, 0, list.Count - 1, pivot, compare);
            return QSV2(list.GetRange(0, pivotIndex + 1), compare).Concat(new List<T>() { pivot }).ToList().Concat(QSV2(list.GetRange(pivotIndex + 1, list.Count - pivotIndex - 1), compare)).ToList();
        }

        static (List<T>, int) FindPivotIndex<T>(List<T> list, int low, int high, T pivot, typeComparator<T> compare)
        {
            while(low < high)
            {
                if (compare(pivot, list[low]))
                    low++;
                else
                {
                    while(compare(pivot,list[high]) == false)
                    {
                        high--;
                    }
                    T temp = list[high];
                    list[high] = list[low];
                    list[low] = temp;
                    low++;
                }
            }
            if (compare(pivot, list[low]) == false)
                low = low - 1;
            return (list, low);
        }
    }
}

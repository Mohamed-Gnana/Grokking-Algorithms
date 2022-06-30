using System;
using System.Collections.Generic;
using System.Text;

namespace SumFunctionInCsharp
{
    public delegate T Add<T>(T x, T y);
    public delegate bool typeComparator<T>(T x, T y);
    public static class General
    {
        public static T sum<T>(List<T> values, Add<T> add)
        {
            if (values.Count == 0)
                return default;
            return add(values[0], sum(values.GetRange(1, values.Count - 1), add));
        }

        public static int count<T>(List<T> values)
        {
            if (values.Count == 0)
                return 0;
            return 1 + count(values.GetRange(1, values.Count - 1));
        }

        public static T maximum<T> (List<T> values, typeComparator<T> compare)
        {
            if (values.Count == 1)
                return values[0];
            T max = maximum(values.GetRange(1, values.Count - 1), compare);
            if (compare(max, values[0]))
                return max;
            else
                return values[0];
        }
    }
}

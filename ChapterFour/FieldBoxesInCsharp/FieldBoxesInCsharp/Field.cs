using System;
using System.Collections.Generic;
using System.Text;

namespace FieldBoxesInCsharp
{
    public static class Field
    {
        public static (int, int) LargestFieldBox(int x, int y)
        {
            if (x % y == 0)
                return (y,y);
            return LargestFieldBox(y, x % y);
        }
    }
}

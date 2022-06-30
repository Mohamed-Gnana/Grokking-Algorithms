using System;
using System.Collections.Generic;
using System.Text;

namespace KnapsackProblemUsingDynamicProgramming
{
    public static class Create
    {
        public static (double, List<(string, double, double)>) StoreAndBag()
        {
            var store = new List<(string, double, double)>()
            {
                ("Guitar", 1500, 1),
                ("Labtop", 2000, 3),
                ("Stereo", 3000, 4),
                ("Iphone", 2000, 1),
                ("Maclaptop", 7000, 3)
            };

            return (4, store);
        }
    }
}

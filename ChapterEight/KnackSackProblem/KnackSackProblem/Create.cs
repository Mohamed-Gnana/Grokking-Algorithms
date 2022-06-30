using System;
using System.Collections.Generic;
using System.Text;

namespace KnackSackProblem
{
    public static class Create
    {
        public static List<(string, double, double)> Store()
        {
            var store = new List<(string, double, double)>()
            {
                ("streo", 3000, 15),
                ("monitor", 2000, 20),
                ("laptop", 2500, 10),
                ("piano", 5000, 50)
            };
            return store;
        }
    }
}

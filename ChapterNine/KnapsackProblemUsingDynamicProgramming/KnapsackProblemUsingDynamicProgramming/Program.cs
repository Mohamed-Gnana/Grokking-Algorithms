using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackProblemUsingDynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            (double maxWeight, List<(string, double, double)> store) = Create.StoreAndBag();
            KnapsackDP p = new KnapsackDP(maxWeight, store.Count);
            Console.WriteLine(p.maxValue(store));
        }
    }
}

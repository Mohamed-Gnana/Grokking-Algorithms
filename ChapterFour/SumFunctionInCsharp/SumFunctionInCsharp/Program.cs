using System;
using System.Collections.Generic;

namespace SumFunctionInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(General.sum<double>(new List<double>() { 1.5, 2.6, 3.4 }, Addme));
            Console.WriteLine(General.count<double>(new List<double>() { 1.5, 2.6, 3.4 }));
            Console.WriteLine(General.maximum<int>(new List<int>() { 1, 2, 4, 3, 6, 5 }, compare));
        }
        internal static double Addme(double x, double y)
        {
            return x + y;
        }
        internal static bool compare(int x, int y)
        {
            return x > y;
        }
    }
}

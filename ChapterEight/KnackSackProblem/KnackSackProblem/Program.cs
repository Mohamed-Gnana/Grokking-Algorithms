using System;
using System.Collections.Generic;
using System.Linq;

namespace KnackSackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = Create.Store();
            double capNow = 0, maxCap = 100, mnPrice;
            List<(string, double, double)> theft = new List<(string, double, double)>();
            while(capNow < maxCap)
            {
                mnPrice = double.MinValue;
                (string, double, double) element = default;
                foreach((string dev, double price, double weight) item in store)
                {
                    if(item.price > mnPrice && capNow + item.weight <= maxCap)
                    {
                        mnPrice = item.price;
                        element = item;
                    }
                }
                if (element == default)
                    break;
                theft.Add(element);
                capNow += element.Item3;
            }
            theft.ForEach(item => Console.WriteLine($"We stole : {item.Item1}, and its price is : {item.Item2}, and its weight is : {item.Item3}"));
        }
    }
}

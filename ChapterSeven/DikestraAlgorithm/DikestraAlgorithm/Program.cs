using System;
using System.Collections.Generic;
using System.Linq;

namespace DikestraAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> graph = Create.createGraph();
            Dictionary<string, double> costs = Create.creatCostTable();
            Dictionary<string, string> parent = Create.createParentTable();

            Console.WriteLine($"The shortest path is : {SP.Dikestra(graph, costs, parent)}");
            string node = "FIN";
            Console.Write("Path : ");
            while(node != "START")
            {
                Console.Write($"{node} ---> ");
                node = parent[node];
            }
            Console.Write("START\n");

            graph = Create.createGraph2();
            costs = Create.creatCostTable2();
            parent = Create.createParentTable2();

            Console.WriteLine($"The shortest path is : {SP.Dikestra(graph, costs, parent)}");
            node = "FIN";
            Console.Write("Path : ");
            while (node != "START")
            {
                Console.Write($"{node} ---> ");
                node = parent[node];
            }
            Console.Write("START\n");

            //////////////////////////
            ///
            graph = Create.createGraph3();
            costs = Create.creatCostTable3();
            parent = Create.createParentTable3();

            Console.WriteLine($"The shortest path is : {SP.Dikestra(graph, costs, parent)}");
            node = "FIN";
            Console.Write("Path : ");
            while (node != "START")
            {
                Console.Write($"{node} ---> ");
                node = parent[node];
            }
            Console.Write("START\n");
        }
    }
}

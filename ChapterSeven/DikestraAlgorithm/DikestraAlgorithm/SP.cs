using System;
using System.Collections.Generic;
using System.Text;

namespace DikestraAlgorithm
{
    public static class SP
    {
        public static double Dikestra(
            Dictionary<string, Dictionary<string, double>> graph,
            Dictionary<string, double> costs,
            Dictionary<string, string> parent)
        {
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            string node = NodeUnprocessedWithCheapestCost(costs, visited);
            while(node != null)
            {
                double cost = costs[node];
                var neighbors = graph[node];
                foreach(string neighbor in neighbors.Keys)
                {
                    double new_cost = cost + neighbors[neighbor];
                    if (new_cost < costs[neighbor])
                    {
                        costs[neighbor] = new_cost;
                        parent[neighbor] = node;
                    }
                }
                visited.Add(node, true);
                node = NodeUnprocessedWithCheapestCost(costs, visited);
            }
            return costs["FIN"];
        }

        private static string NodeUnprocessedWithCheapestCost(Dictionary<string, double> costs, Dictionary<string, bool> visited)
        {
            double lowestCost = double.MaxValue;
            string cheapestNode = null;
            foreach(string node in costs.Keys)
            {
                if (costs[node] < lowestCost && !visited.ContainsKey(node))
                {
                    lowestCost = costs[node];
                    cheapestNode = node;
                }
            }
            return cheapestNode;
        }
    }
}

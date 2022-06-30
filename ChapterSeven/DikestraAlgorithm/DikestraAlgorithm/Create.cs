using System;
using System.Collections.Generic;
using System.Text;

namespace DikestraAlgorithm
{
    public static class Create
    {
        public static Dictionary<string, Dictionary<string, double>> createGraph()
        {
            var graph = new Dictionary<string, Dictionary<string, double>>();
            graph.Add("START", new Dictionary<string, double>());
            graph["START"].Add("A", 6);
            graph["START"].Add("B", 2);
            graph.Add("A", new Dictionary<string, double>());
            graph["A"].Add("FIN", 1);
            graph.Add("B", new Dictionary<string, double>());
            graph["B"].Add("A", 3);
            graph["B"].Add("FIN", 5);
            graph.Add("FIN", new Dictionary<string, double>());
            return graph;
        }

        public static Dictionary<string, double> creatCostTable()
        {
            var costs = new Dictionary<string, double>();
            costs.Add("A", 6);
            costs.Add("B", 2);
            costs.Add("FIN", double.MaxValue);
            return costs;
        }

        public static Dictionary<string, string> createParentTable()
        {
            var parent = new Dictionary<string, string>();
            parent.Add("A", "START");
            parent.Add("B", "START");
            parent.Add("FIN", null);
            return parent;
        }


        ///////////////////////////////////////////////
        ///
        public static Dictionary<string, Dictionary<string, double>> createGraph2()
        {
            var graph = new Dictionary<string, Dictionary<string, double>>();
            graph.Add("START", new Dictionary<string, double>());
            graph["START"].Add("A", 5);
            graph["START"].Add("B", 2);
            graph.Add("A", new Dictionary<string, double>());
            graph["A"].Add("C", 4);
            graph["A"].Add("D", 2);
            graph.Add("B", new Dictionary<string, double>());
            graph["B"].Add("A", 8);
            graph["B"].Add("D", 7);
            graph.Add("C", new Dictionary<string, double>());
            graph["C"].Add("D", 6);
            graph["C"].Add("FIN", 3);
            graph.Add("D", new Dictionary<string, double>());
            graph["D"].Add("FIN", 1);
            graph.Add("FIN", new Dictionary<string, double>());
            return graph;
        }

        public static Dictionary<string, double> creatCostTable2()
        {
            var costs = new Dictionary<string, double>();
            costs.Add("A", 5);
            costs.Add("B", 2);
            costs.Add("C", double.MaxValue);
            costs.Add("D", double.MaxValue);
            costs.Add("FIN", double.MaxValue);
            return costs;
        }

        public static Dictionary<string, string> createParentTable2()
        {
            var parent = new Dictionary<string, string>();
            parent.Add("A", "START");
            parent.Add("B", "START");
            parent.Add("C", null);
            parent.Add("D", null);
            parent.Add("FIN", null);
            return parent;
        }

        ///////////////////////////////////////
        ///
        public static Dictionary<string, Dictionary<string, double>> createGraph3()
        {
            var graph = new Dictionary<string, Dictionary<string, double>>();
            graph.Add("START", new Dictionary<string, double>());
            graph["START"].Add("A", 10);
            graph.Add("A", new Dictionary<string, double>());
            graph["A"].Add("B", 20);
            graph.Add("B", new Dictionary<string, double>());
            graph["B"].Add("C", 1);
            graph["B"].Add("FIN", 30);
            graph.Add("C", new Dictionary<string, double>());
            graph["C"].Add("A", 1);
            graph.Add("FIN", new Dictionary<string, double>());
            return graph;
        }

        public static Dictionary<string, double> creatCostTable3()
        {
            var costs = new Dictionary<string, double>();
            costs.Add("A", 10);
            costs.Add("B", double.MaxValue);
            costs.Add("C", double.MaxValue);
            costs.Add("FIN", double.MaxValue);
            return costs;
        }

        public static Dictionary<string, string> createParentTable3()
        {
            var parent = new Dictionary<string, string>();
            parent.Add("A", "START");
            parent.Add("B", null);
            parent.Add("C", null);
            parent.Add("FIN", null);
            return parent;
        }
    }
}

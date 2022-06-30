using System;
using System.Collections.Generic;

namespace FindingANearestDoctorInANetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var search = new Search();
            search.addNode("Mohamed", new List<string>() { "Ahmed", "Ali", "Mama" });
            search.addNode("Ahmed", new List<string>() { "Asmaa", "Alaa", "Papa" });
            search.addNode("Ali", new List<string>() { "Arwa", "MeD" });
            search.addNode("Mama", new List<string>() { "MeD", "Ali", "Papa" });
            search.addNode("Asmaa", new List<string>());
            search.addNode("Alaa", new List<string>());
            search.addNode("Papa", new List<string>());
            search.addNode("MeD", new List<string>());
            search.addNode("Arwa", new List<string>());

            Console.WriteLine(search.BFS("Mohamed"));

            Node d = new Node("MeD");
            Node Ar = new Node("Alaa");
            Node As = new Node("Asmaa");
            Node Pa = new Node("Papa");
            Node Ma = new Node("MAma");
            Node Al = new Node("Ali");
            Al.addNeighbor(Ar);
            Al.addNeighbor(d);
            Ma.addNeighbor(d);
            Ma.addNeighbor(Al);
            Ma.addNeighbor(Pa);
            Node Ah = new Node("Ahmed");
            Ah.addNeighbor(As);
            Ah.addNeighbor(Al);
            Ah.addNeighbor(Pa);
            Node m = new Node("Mohamed");
            m.addNeighbor(Ah);
            m.addNeighbor(Al);
            m.addNeighbor(Ma);
            Console.WriteLine(search.BFS(m));
            Console.WriteLine(search.DFS(m, new Dictionary<string, bool>()));
        }
    }
}

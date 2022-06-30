using System;
using System.Collections.Generic;
using System.Text;

namespace FindingANearestDoctorInANetwork
{
    public class Node
    {
        string data;
        List<Node> neighbors;

        public Node(string data)
        {
            this.data = data;
            this.neighbors = new List<Node>();
        }

        public string getData()
        {
            return data;
        }

        public List<Node> getNeighbors()
        {
            return neighbors;
        }
        public void addNeighbor(string name)
        {
            this.neighbors.Add(new Node(name));
        }
        public void addNeighbor(Node node)
        {
            neighbors.Add(node);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FindingANearestDoctorInANetwork
{
    public class Search
    {
        Dictionary<string, List<string>> graph;

        public Search()
        {
            graph = new Dictionary<string, List<string>>();
        }

        public void addNode(string name, List<string> neighbors)
        {
            graph.Add(name, neighbors);
        }
        public bool BFS(string name)
        {
            Queue<string> searchQue = new Queue<string>();
            foreach (string node in graph[name])
                searchQue.Enqueue(node);
            Dictionary<string, bool> searched = new Dictionary<string, bool>();

            while(searchQue.Count != 0)
            {
                string friend = searchQue.Dequeue();
                if (!searched.ContainsKey(friend))
                {
                    if (FriendIsADoctor(friend))
                    {
                        Console.WriteLine($"{friend} : is a doctor.");
                        return true;
                    }
                    else
                    {
                        searched.Add(friend, true);
                        foreach (string node in graph[friend])
                            searchQue.Enqueue(node);
                    }
                }
            }
            return false;
        }

        private bool FriendIsADoctor(string friend)
        {
            return friend[^1] == 'D';
        }


        public bool BFS(Node node)
        {
            Queue<Node> searchQue = new Queue<Node>();
            foreach (Node n in node.getNeighbors())
                searchQue.Enqueue(n);
            Dictionary<string, bool> searched = new Dictionary<string, bool>();

            while(searchQue.Count != 0)
            {
                Node friend = searchQue.Dequeue();
                if (!searched.ContainsKey(friend.getData()))
                {
                    if (FriendIsADoctor(friend.getData()))
                    {
                        Console.WriteLine($"{friend.getData()} : is a doctor.");
                        return true;
                    }
                    else
                    {
                        searched.Add(friend.getData(), true);
                        foreach (Node n in friend.getNeighbors())
                            searchQue.Enqueue(n);
                    }
                }    

            }
            return false;
        }

        public bool DFS(Node node, Dictionary<string, bool> searched)
        {
            if (FriendIsADoctor(node.getData()))
            {
                Console.WriteLine("Found!!!");
                return true;
            }
            bool ret = false;
            foreach(Node n in node.getNeighbors())
            {
                if (!searched.ContainsKey(n.getData()))
                {
                    Console.WriteLine($"{n.getData()} : Visited : Not there.");
                    searched.Add(n.getData(), true);
                    ret = DFS(n, searched);
                }
                if (ret)
                    break;
            }
            return ret;
        }
    }
}

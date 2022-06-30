using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCoveringProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededStates = Create.States();
            var stations = Create.Stations();
            List<string> finalStations = new List<string>();

            while(neededStates.Count != 0)
            {
                string bestStation = null;
                HashSet<string> coveredState = new HashSet<string>();
                foreach(KeyValuePair<string, HashSet<string>> stationgroup in stations)
                {
                    HashSet<string> covered = new HashSet<string>(neededStates);
                    covered.IntersectWith(stationgroup.Value);
                    if (covered.Count > coveredState.Count)
                    {
                        bestStation = stationgroup.Key;
                        coveredState = covered;
                    }
                }
                neededStates.ExceptWith(coveredState);
                finalStations.Add(bestStation);
            }

            finalStations.ForEach(item => Console.WriteLine(item));
        }
    }
}

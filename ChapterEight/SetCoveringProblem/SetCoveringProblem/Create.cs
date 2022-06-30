using System;
using System.Collections.Generic;
using System.Text;

namespace SetCoveringProblem
{
    public static class Create
    {
        public static HashSet<string> States()
        {
            return new HashSet<string>() { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
        }

        public static Dictionary<string, HashSet<string>> Stations()
        {
            return new Dictionary<string, HashSet<string>>()
            {
                { "kone", new HashSet<string> { "id", "nv", "ut" } },
                { "ktwo", new HashSet<string> { "wa", "id", "mt" } },
                { "kthree", new HashSet<string> { "or", "nv", "ca" } },
                { "kfour", new HashSet<string> { "nv", "ut" } },
                { "kfive", new HashSet<string> { "ca", "az" } }
            };
        }
    }
}

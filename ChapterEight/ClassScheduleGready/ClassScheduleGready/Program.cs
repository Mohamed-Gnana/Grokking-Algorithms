using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassScheduleGready
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = Create.Classes();
            double timeNow = 9;
            double SoonestToFinish;
            List<(Class, double, double)> scheduale = new List<(Class, double, double)>();
            (Class, double, double) sub = default;
            Dictionary<Class, bool> visited = new Dictionary<Class, bool>();
            while(timeNow < 12)
            {
                SoonestToFinish = double.MaxValue;
                foreach((Class subject, double start, double finish) clas in classes)
                {
                    if(clas.finish < SoonestToFinish && timeNow <= clas.start && !visited.ContainsKey(clas.subject))
                    {
                        SoonestToFinish = clas.finish;
                        sub = clas;
                    }
                }
                scheduale.Add(sub);
                timeNow = sub.Item3;
                visited.Add(sub.Item1, true);
            }
            scheduale.ForEach(item => Console.WriteLine($"Subject : {item.Item1}, starts at : {item.Item2}, ends at : {item.Item3}"));
        }
    }
}

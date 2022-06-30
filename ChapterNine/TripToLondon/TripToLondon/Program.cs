using System;
using System.Collections.Generic;
using System.Linq;

namespace TripToLondon
{
    class Program
    {
        static void Main(string[] args)
        {
            (double maxStay, List<(string, double, double)> activities) = Create.ActivitiesAndDuration();
            var trip = new Calculatethebestroute(maxStay, activities.Count);
            Console.WriteLine(trip.maxPoints(activities));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TripToLondon
{
    public static class Create
    {
        public static (double, List<(string, double, double)>) ActivitiesAndDuration()
        {
            var activities = new List<(string, double, double)>()
            {
                ("Museum", 5, .5),
                ("Palace", 9, 1),
                ("Park", 4, .5),
                ("GOT", 10, 1),
                ("Scotland", 9, 1)
            };

            return (2, activities);
        }
    }
}

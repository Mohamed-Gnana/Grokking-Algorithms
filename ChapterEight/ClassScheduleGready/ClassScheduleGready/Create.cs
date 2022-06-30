using System;
using System.Collections.Generic;
using System.Text;

namespace ClassScheduleGready
{
    public static class Create
    {
        public static List<(Class, double, double)> Classes()
        {
            List<(Class, double, double)> classes = new List<(Class, double, double)>()
            {
                (Class.math, 9,10),
                (Class.science,9.5, 10.5),
                (Class.english,10,11),
                (Class.chemistry,10.5,11.5),
                (Class.geography,11,12)
            };
            return classes;
        }
    }
}

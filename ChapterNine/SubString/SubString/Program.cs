using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            var compare = new Compare("hish", "fish");
            Console.WriteLine(compare.MaxSubString());
        }
    }
}

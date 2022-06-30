using System;
using System.Collections.Generic;

namespace StackinCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s1 = new Stack<string>();
            Stack<int> s2 = new Stack<int>(1);
            Stack<int> s3 = new Stack<int>(new List<int>() { 0, 1, 2, 3, 4, 5 });

            s1.Push("Mohamed");
            s1.Push("Mohamed");
            s1.Push("Mustafa");
            s1.Push("Gnana");
            s1.Print();
            Console.WriteLine(s2.Pop());
            s3.Print();
        }
    }
}
